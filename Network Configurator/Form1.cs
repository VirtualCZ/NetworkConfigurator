using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Drawing.Drawing2D;

namespace Network_Configurator
{
    public partial class Form1 : Form
    {
        private List<NetworkInterfaceData> savedAddresses = new List<NetworkInterfaceData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the addresses when the form is closing
            SaveSavedAddresses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSavedAddresses();
            RefreshNetworkInterfaces();
        }

        private void RefreshNetworkInterfaces()
        {
            System.Console.WriteLine("Refreshing network interfaces");
            listBoxNetworkInterfaces.Items.Clear();

            foreach (var nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                listBoxNetworkInterfaces.Items.Add(nic.Description);
            }
        }

        private void UpdateSavedAddressesListView()
        {
            System.Console.WriteLine("Updating Saved Addresses ListView");
            listAddresses.Items.Clear();

            for (int i = 0; i < savedAddresses.Count; i++)
            {
                NetworkInterfaceData address = savedAddresses[i];

                ListViewItem item = new ListViewItem((i + 1).ToString()); // Index column
                item.SubItems.Add(address.IPAddress); // IP column
                item.SubItems.Add(address.SubnetMask); // Mask column

                listAddresses.Items.Add(item);
            }
        }

        private void SaveSavedAddresses()
        {
            System.Console.WriteLine("Saving saved addresses");
            string filePath = "addresses.csv";
            File.WriteAllLines(filePath, savedAddresses.Select(addr => $"{addr.IPAddress},{addr.SubnetMask}"));
        }

        private void LoadSavedAddresses()
        {
            System.Console.WriteLine("Loading saved addresses");
            string filePath = "addresses.csv";

            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath);
                savedAddresses.AddRange(lines.Select(line =>
                {
                    string[] parts = line.Split(',');
                    return new NetworkInterfaceData(parts[0], parts[1]);
                }));
            }

            UpdateSavedAddressesListView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshNetworkInterfaces();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listAddresses.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listAddresses.SelectedItems[0];

                // Check if the selected item index is within the range of the savedAddresses list
                if (selectedRow.Index >= 0 && selectedRow.Index < savedAddresses.Count)
                {
                    // Remove the item from the savedAddresses list
                    savedAddresses.RemoveAt(selectedRow.Index);

                    // Update the indexes in the ListView and in the savedAddresses list
                    for (int i = selectedRow.Index; i < listAddresses.Items.Count - 1; i++)
                    {
                        // Update the "Index" column in the ListView
                        listAddresses.Items[i + 1].SubItems[0].Text = (i + 1).ToString();

                        // Update the index in the savedAddresses list
                        savedAddresses[i] = new NetworkInterfaceData(savedAddresses[i].IPAddress, savedAddresses[i].SubnetMask);
                    }

                    // Remove the selected row from the ListView
                    listAddresses.Items.Remove(selectedRow);

                    SaveSavedAddresses(); // Update the saved addresses file
                }
            }
        }

        private void btnRewrite_Click(object sender, EventArgs e)
        {
            if (listAddresses.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listAddresses.SelectedItems[0];
                string ipAddress = ip_textbox.Texts;
                string subnetMask = mask_textbox.Texts;

                if (IsValidIPAddress(ipAddress) && IsValidSubnetMask(subnetMask))
                {
                    // Update the selected row with new values
                    selectedRow.SubItems[1].Text = ipAddress; // IP column
                    selectedRow.SubItems[2].Text = subnetMask; // Mask column

                    // Update the savedAddresses list
                    int selectedIndex = selectedRow.Index;
                    savedAddresses[selectedIndex] = new NetworkInterfaceData(ipAddress, subnetMask);

                    SaveSavedAddresses(); // Update the saved addresses file
                }
                else
                {
                    MessageBox.Show("Please enter a valid IP address and subnet mask.");
                }
            }
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            if (listBoxNetworkInterfaces.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a network interface.");
                return;
            }

            string selectedInterface = listBoxNetworkInterfaces.SelectedItem.ToString();

            // Set the network interface to use DHCP for IPv4
            SetNetworkInterfaceToDHCP(selectedInterface);
        }

        private void SetNetworkInterfaceToDHCP(string interfaceDescription)
        {
            ManagementObject networkInterface = null;

            try
            {
                // Create a WMI query to find the network interface by description
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Description = '" + interfaceDescription + "'");

                // Get the first result (assuming there's only one with the given description)
                ManagementObjectCollection results = searcher.Get();
                if (results.Count > 0)
                {
                    networkInterface = results.OfType<ManagementObject>().First();

                    // Set the interface to use DHCP
                    PropertyDataCollection properties = networkInterface.Properties;
                    foreach (PropertyData property in properties)
                    {
                        if (property.Name == "DHCPEnabled")
                        {
                            property.Value = true;
                        }
                    }

                    // Call the "EnableDHCP" method to apply the changes
                    networkInterface.InvokeMethod("EnableDHCP", null, null);
                }

                MessageBox.Show("DHCP configuration applied successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying DHCP configuration: " + ex.Message);
            }
            finally
            {
                networkInterface?.Dispose();
            }
        }

        private void btnSaveApply_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ipAddress = ip_textbox.Texts;
            string subnetMask = mask_textbox.Texts;

            if (!string.IsNullOrEmpty(ipAddress) && !string.IsNullOrEmpty(subnetMask))
            {
                savedAddresses.Add(new NetworkInterfaceData(ipAddress, subnetMask));
                UpdateSavedAddressesListView();
                SaveSavedAddresses();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listBoxNetworkInterfaces.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a network interface.");
                return;
            }

            string selectedInterface = listBoxNetworkInterfaces.SelectedItem.ToString();
            string ipAddress = ip_textbox.Texts;
            string subnetMask = mask_textbox.Texts;

            if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(subnetMask))
            {
                MessageBox.Show("Please enter both an IP address and subnet mask.");
                return;
            }

            if (!IsValidIPAddress(ipAddress) || !IsValidSubnetMask(subnetMask))
            {
                MessageBox.Show("Please enter a valid IP address and subnet mask.");
                return;
            }

            // Set the network interface to use a static IP and subnet mask
            SetNetworkInterfaceToStaticIP(selectedInterface, ipAddress, subnetMask);
        }

        private bool IsValidIPAddress(string ipAddress)
        {
            // Use regular expression to validate the IP address format
            string ipPattern = @"^(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)){3}$";
            return System.Text.RegularExpressions.Regex.IsMatch(ipAddress, ipPattern);
        }

        private bool IsValidSubnetMask(string subnetMask)
        {
            // Use regular expression to validate the subnet mask format
            string maskPattern = @"^(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)){3}$";
            return System.Text.RegularExpressions.Regex.IsMatch(subnetMask, maskPattern);
        }

        private void SetNetworkInterfaceToStaticIP(string interfaceDescription, string ipAddress, string subnetMask)
        {
            ManagementObject networkInterface = null;

            try
            {
                // Create a WMI query to find the network interface by description
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE Description = '" + interfaceDescription + "'");

                // Get the first result (assuming there's only one with the given description)
                ManagementObjectCollection results = searcher.Get();
                if (results.Count > 0)
                {
                    networkInterface = results.OfType<ManagementObject>().First();

                    // Configure the network interface with a static IP
                    ManagementBaseObject setIP = networkInterface.GetMethodParameters("EnableStatic");
                    setIP["IPAddress"] = new string[] { ipAddress };
                    setIP["SubnetMask"] = new string[] { subnetMask };
                    networkInterface.InvokeMethod("EnableStatic", setIP, null);

                    // Call the "SetGateways" method to set the default gateway (if needed)
                    ManagementBaseObject setGateway = networkInterface.GetMethodParameters("SetGateways");
                    setGateway["DefaultIPGateway"] = new string[] { "your_default_gateway" }; // Set your default gateway here
                    networkInterface.InvokeMethod("SetGateways", setGateway, null);
                }

                MessageBox.Show("Static IP configuration applied successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying static IP configuration: " + ex.Message);
            }
            finally
            {
                networkInterface?.Dispose();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSavedAddresses();
        }

        private void listAddresses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected item
                ListViewItem selectedItem = listAddresses.SelectedItems[0];

                // Update the IP and Mask text fields with the values from the selected row
                ip_textbox.Texts = selectedItem.SubItems[1].Text; // IP column
                mask_textbox.Texts = selectedItem.SubItems[2].Text; // Mask column
            }
        }

        private void listAddresses_ItemActivate(object sender, EventArgs e)
        {
            if (listBoxNetworkInterfaces.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a network interface.");
                return;
            }
            if (listAddresses.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listAddresses.SelectedItems[0];

                // Extract IP and Mask from the selected row
                string ipAddress = selectedItem.SubItems[1].Text; // IP column
                string subnetMask = selectedItem.SubItems[2].Text; // Mask column

                // Apply the IP and Mask to the selected network interface
                string selectedInterface = listBoxNetworkInterfaces.SelectedItem.ToString();
                SetNetworkInterfaceToStaticIP(selectedInterface, ipAddress, subnetMask);
            }
        }
        private Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20; // Adjust the radius to control the roundness

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int arcWidth = borderRadius * 2;
            int arcHeight = borderRadius * 2;

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias; // Enable anti-aliasing

                path.AddLine(rect.Left + borderRadius, rect.Top, rect.Right - borderRadius, rect.Top);
                path.AddArc(rect.Right - arcWidth, rect.Top, arcWidth, arcHeight, 270, 90);
                path.AddLine(rect.Right, rect.Top + borderRadius, rect.Right, rect.Bottom - borderRadius);
                path.AddArc(rect.Right - arcWidth, rect.Bottom - arcHeight, arcWidth, arcHeight, 0, 90);
                path.AddLine(rect.Right - borderRadius, rect.Bottom, rect.Left + borderRadius, rect.Bottom);
                path.AddArc(rect.Left, rect.Bottom - arcHeight, arcWidth, arcHeight, 90, 90);
                path.AddLine(rect.Left, rect.Bottom - borderRadius, rect.Left, rect.Top + borderRadius);
                path.AddArc(rect.Left, rect.Top, arcWidth, arcHeight, 180, 90);
            }

            this.Region = new Region(path);
        }

        private void listAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
