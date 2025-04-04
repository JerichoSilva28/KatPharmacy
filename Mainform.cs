using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem
{
    public partial class Mainform : System.Windows.Forms.Form
    {

        String user = "";
        public Mainform()
        {
            InitializeComponent();
        }
        public Mainform(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
        }

            private void btnExit_Click(object sender, EventArgs e)
            {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

            if (guna2MessageDialog1.Show("Are you sure you want to Exit?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ViewUserButton_Click(object sender, EventArgs e)
        {
            ViewUser view = new ViewUser();
            view.TopLevel = false;
            Panel2.Controls.Add(view);
            view.BringToFront();
            view.Show();
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var log = new KatPharmacySytem.Login();
            log.Show();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboard board = new Dashboard();
            board.TopLevel = false;
            Panel2.Controls.Add(board);
            board.BringToFront();
            board.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
