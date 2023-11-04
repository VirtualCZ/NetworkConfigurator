using System.Windows.Forms;

namespace Network_Configurator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxNetworkInterfaces = new System.Windows.Forms.ListBox();
            this.listBoxNetworkInterfaces_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ip_label = new System.Windows.Forms.Label();
            this.mask_label = new System.Windows.Forms.Label();
            this.listAddresses_label = new System.Windows.Forms.Label();
            this.listAddresses = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customTitleBar1 = new Network_Configurator.CustomTitleBar();
            this.ip_textbox = new Network_Configurator.CustomTextBox();
            this.mask_textbox = new Network_Configurator.CustomTextBox();
            this.btnSave = new Network_Configurator.CustomComponents.CustomButton();
            this.btnApply = new Network_Configurator.CustomComponents.CustomButton();
            this.btnSaveApply = new Network_Configurator.CustomComponents.CustomButton();
            this.btnDHCP = new Network_Configurator.CustomComponents.CustomButton();
            this.btnRewrite = new Network_Configurator.CustomComponents.CustomButton();
            this.btnDelete = new Network_Configurator.CustomComponents.CustomButton();
            this.btnRefresh = new Network_Configurator.CustomComponents.CustomButton();
            this.SuspendLayout();
            // 
            // listBoxNetworkInterfaces
            // 
            this.listBoxNetworkInterfaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.listBoxNetworkInterfaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNetworkInterfaces.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxNetworkInterfaces.FormattingEnabled = true;
            this.listBoxNetworkInterfaces.Location = new System.Drawing.Point(12, 80);
            this.listBoxNetworkInterfaces.Name = "listBoxNetworkInterfaces";
            this.listBoxNetworkInterfaces.Size = new System.Drawing.Size(776, 91);
            this.listBoxNetworkInterfaces.TabIndex = 0;
            // 
            // listBoxNetworkInterfaces_label
            // 
            this.listBoxNetworkInterfaces_label.AutoSize = true;
            this.listBoxNetworkInterfaces_label.ForeColor = System.Drawing.Color.White;
            this.listBoxNetworkInterfaces_label.Location = new System.Drawing.Point(9, 64);
            this.listBoxNetworkInterfaces_label.Name = "listBoxNetworkInterfaces_label";
            this.listBoxNetworkInterfaces_label.Size = new System.Drawing.Size(97, 13);
            this.listBoxNetworkInterfaces_label.TabIndex = 1;
            this.listBoxNetworkInterfaces_label.Text = "Network Interfaces";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.ForeColor = System.Drawing.Color.White;
            this.ip_label.Location = new System.Drawing.Point(12, 218);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(17, 13);
            this.ip_label.TabIndex = 5;
            this.ip_label.Text = "IP";
            // 
            // mask_label
            // 
            this.mask_label.AutoSize = true;
            this.mask_label.ForeColor = System.Drawing.Color.White;
            this.mask_label.Location = new System.Drawing.Point(493, 218);
            this.mask_label.Name = "mask_label";
            this.mask_label.Size = new System.Drawing.Size(33, 13);
            this.mask_label.TabIndex = 6;
            this.mask_label.Text = "Mask";
            // 
            // listAddresses_label
            // 
            this.listAddresses_label.AutoSize = true;
            this.listAddresses_label.ForeColor = System.Drawing.Color.White;
            this.listAddresses_label.Location = new System.Drawing.Point(12, 282);
            this.listAddresses_label.Name = "listAddresses_label";
            this.listAddresses_label.Size = new System.Drawing.Size(89, 13);
            this.listAddresses_label.TabIndex = 7;
            this.listAddresses_label.Text = "Saved addresses";
            // 
            // listAddresses
            // 
            this.listAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.listAddresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.IP,
            this.Mask});
            this.listAddresses.ForeColor = System.Drawing.SystemColors.Window;
            this.listAddresses.FullRowSelect = true;
            this.listAddresses.GridLines = true;
            this.listAddresses.HideSelection = false;
            this.listAddresses.Location = new System.Drawing.Point(12, 298);
            this.listAddresses.MultiSelect = false;
            this.listAddresses.Name = "listAddresses";
            this.listAddresses.Size = new System.Drawing.Size(776, 121);
            this.listAddresses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAddresses.TabIndex = 16;
            this.listAddresses.UseCompatibleStateImageBehavior = false;
            this.listAddresses.View = System.Windows.Forms.View.Details;
            this.listAddresses.ItemActivate += new System.EventHandler(this.listAddresses_ItemActivate);
            this.listAddresses.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listAddresses_ItemSelectionChanged);
            // 
            // Index
            // 
            this.Index.Text = "Index";
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 300;
            // 
            // Mask
            // 
            this.Mask.Text = "Mask";
            this.Mask.Width = 300;
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.Transparent;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.customTitleBar1.Size = new System.Drawing.Size(800, 48);
            this.customTitleBar1.TabIndex = 20;
            // 
            // ip_textbox
            // 
            this.ip_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.ip_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ip_textbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.ip_textbox.BorderRadius = 10;
            this.ip_textbox.BorderSize = 1;
            this.ip_textbox.ForeColor = System.Drawing.Color.White;
            this.ip_textbox.Location = new System.Drawing.Point(12, 236);
            this.ip_textbox.Multiline = false;
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ip_textbox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            this.ip_textbox.PlaceholderText = "192.168.0.1";
            this.ip_textbox.Size = new System.Drawing.Size(292, 28);
            this.ip_textbox.TabIndex = 19;
            this.ip_textbox.Texts = "";
            // 
            // mask_textbox
            // 
            this.mask_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.mask_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mask_textbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.mask_textbox.BorderRadius = 10;
            this.mask_textbox.BorderSize = 1;
            this.mask_textbox.ForeColor = System.Drawing.Color.White;
            this.mask_textbox.Location = new System.Drawing.Point(496, 236);
            this.mask_textbox.Multiline = false;
            this.mask_textbox.Name = "mask_textbox";
            this.mask_textbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mask_textbox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            this.mask_textbox.PlaceholderText = "255.255.255.0";
            this.mask_textbox.Size = new System.Drawing.Size(292, 28);
            this.mask_textbox.TabIndex = 18;
            this.mask_textbox.Texts = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApply.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApply.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApply.BorderRadius = 10;
            this.btnApply.BorderSize = 0;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(96, 468);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 22;
            this.btnApply.Text = "Apply";
            this.btnApply.TextColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSaveApply
            // 
            this.btnSaveApply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveApply.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveApply.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveApply.BorderRadius = 10;
            this.btnSaveApply.BorderSize = 0;
            this.btnSaveApply.FlatAppearance.BorderSize = 0;
            this.btnSaveApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveApply.ForeColor = System.Drawing.Color.White;
            this.btnSaveApply.Location = new System.Drawing.Point(177, 468);
            this.btnSaveApply.Name = "btnSaveApply";
            this.btnSaveApply.Size = new System.Drawing.Size(100, 23);
            this.btnSaveApply.TabIndex = 23;
            this.btnSaveApply.Text = "Save and apply";
            this.btnSaveApply.TextColor = System.Drawing.Color.White;
            this.btnSaveApply.UseVisualStyleBackColor = false;
            this.btnSaveApply.Click += new System.EventHandler(this.btnSaveApply_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDHCP.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDHCP.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDHCP.BorderRadius = 10;
            this.btnDHCP.BorderSize = 0;
            this.btnDHCP.FlatAppearance.BorderSize = 0;
            this.btnDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDHCP.ForeColor = System.Drawing.Color.White;
            this.btnDHCP.Location = new System.Drawing.Point(283, 468);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(75, 23);
            this.btnDHCP.TabIndex = 24;
            this.btnDHCP.Text = "Set DHCP";
            this.btnDHCP.TextColor = System.Drawing.Color.White;
            this.btnDHCP.UseVisualStyleBackColor = false;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // btnRewrite
            // 
            this.btnRewrite.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRewrite.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRewrite.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRewrite.BorderRadius = 10;
            this.btnRewrite.BorderSize = 0;
            this.btnRewrite.FlatAppearance.BorderSize = 0;
            this.btnRewrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewrite.ForeColor = System.Drawing.Color.White;
            this.btnRewrite.Location = new System.Drawing.Point(15, 425);
            this.btnRewrite.Name = "btnRewrite";
            this.btnRewrite.Size = new System.Drawing.Size(156, 23);
            this.btnRewrite.TabIndex = 26;
            this.btnRewrite.Text = "Rewrite selected";
            this.btnRewrite.TextColor = System.Drawing.Color.White;
            this.btnRewrite.UseVisualStyleBackColor = false;
            this.btnRewrite.Click += new System.EventHandler(this.btnRewrite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(177, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete selected address";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(15, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh interfaces";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRewrite);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.btnSaveApply);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.mask_textbox);
            this.Controls.Add(this.listAddresses);
            this.Controls.Add(this.listAddresses_label);
            this.Controls.Add(this.mask_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.listBoxNetworkInterfaces_label);
            this.Controls.Add(this.listBoxNetworkInterfaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Network Configurator 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNetworkInterfaces;
        private System.Windows.Forms.Label listBoxNetworkInterfaces_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label mask_label;
        private System.Windows.Forms.Label listAddresses_label;
        private System.Windows.Forms.ListView listAddresses;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Mask;
        private CustomTextBox mask_textbox;
        private CustomTextBox ip_textbox;
        private CustomTitleBar customTitleBar1;
        private CustomComponents.CustomButton btnSave;
        private CustomComponents.CustomButton btnApply;
        private CustomComponents.CustomButton btnSaveApply;
        private CustomComponents.CustomButton btnDHCP;
        private CustomComponents.CustomButton btnRewrite;
        private CustomComponents.CustomButton btnDelete;
        private CustomComponents.CustomButton btnRefresh;
    }
}

