using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Configurator.CustomComponents
{
    internal class CustomListView : ListView
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 10;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("Custom")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value < this.Height)
                    borderRadius = value;
                else BorderRadius = this.Height;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        public Color TextColor
        {
            get => this.ForeColor;
            set
            {
                this.ForeColor = value;
                this.Invalidate();
            }
        }

        //Contstructor
        public CustomListView()
        {
            this.View = View.Details;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
           // this.Resize += new EventHandler();
        }
    }
}
