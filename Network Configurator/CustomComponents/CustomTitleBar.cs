using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Network_Configurator
{
    public partial class CustomTitleBar : UserControl
    {
        public CustomTitleBar()
        {
            InitializeComponent();

            // Set up event handlers for the buttons
            closeButton.Click += CloseButton_Click;
            minimizeButton.Click += MinimizeButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Handle the close button click event
            Form form = FindForm();
            if (form != null)
            {
                form.Close(); // Close the form
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            // Handle the minimize button click event
            Form form = FindForm();
            if (form != null)
            {
                form.WindowState = FormWindowState.Minimized; // Minimize the form
            }
        }

        // Rest of your code...

        // Declare the CloseButtonClick event
        public event EventHandler CloseButtonClick;

       
    }
}
