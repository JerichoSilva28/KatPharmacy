using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem.View
{
    public partial class uMed : UserControl
    {
        public event EventHandler onSelect = null;
        public uMed()
        {
            InitializeComponent();
        }

        private void  uPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        public int id {  get; set; }

        public string PCost { get; set; }

        public string Pname
        {
            get { return lblMedicine.Text; }
            set { lblMedicine.Text = value;}
        }

        public string Price {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; } 
        }

        public Image PImage
        {
            get { return uPic.Image; }
            set { uPic.Image = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
