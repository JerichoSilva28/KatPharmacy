using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem
{
    public partial class Pharmacistform : System.Windows.Forms.Form
    {
        public Pharmacistform()
        {
            InitializeComponent();
        }
        String user = "";


        public string ID
        {
            get { return user.ToString(); }
        }
        public Pharmacistform(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            guna2CirclePictureBox1.Image = MainClass.img;
           
        }
        public void setUser(String User)
        {
            userNameLabel.Text = User;
           
        }

        
        private void Pharmacistform_Load(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Image = MainClass.img;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var log = new KatPharmacySytem.Login();
            log.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Categoryform view = new Categoryform();
            view.TopLevel = false;
            Panel2.Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier view = new Supplier();
            view.TopLevel = false;
            Panel2.Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

            if(guna2MessageDialog1.Show("Are you sure you want to Exit?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Medicineform med = new Medicineform();
            med.TopLevel = false;
            Panel2.Controls.Add(med);
            med.BringToFront();
            med.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.TopLevel = false;
            Panel2.Controls.Add(cus);
            cus.BringToFront();
            cus.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Purchaseform pur = new Purchaseform();
            pur.TopLevel = false;
            Panel2.Controls.Add(pur);
            pur.BringToFront();
            pur.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Saleform sal = new Saleform();
            sal.TopLevel = false;
            Panel2.Controls.Add(sal);
            sal.BringToFront();
            sal.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reportform sal = new Reportform();
            sal.TopLevel = false;
            Panel2.Controls.Add(sal);
            sal.BringToFront();
            sal.Show();
        }
    }
}
