using System;
using System.Collections;
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
    public partial class Login : System.Windows.Forms.Form
    {
        MainClass fn = new MainClass();
        String qry;
        DataSet ds;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            qry = "select * from users";
            DataSet ds = fn.getData(qry);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (UsernameBox.Text == "admin" && PasswordBox.Text == "katpharmacy")
                {
                    Mainform admin = new Mainform();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    qry = "select * from users where uUsername ='" + UsernameBox.Text + "' and uPass ='" + PasswordBox.Text + "'";
                    ds = fn.getData(qry);
                    if (MainClass.IsValidUser(UsernameBox.Text, PasswordBox.Text) == true)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();
                        if (role == "Administrator")
                        {
                            Mainform ad = new Mainform(UsernameBox.Text);
                            ad.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmacist")
                        {
                            Pharmacistform pharm = new Pharmacistform();
                            pharm.setUser(UsernameBox.Text);
                            pharm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                       // MessageBox.Show("Invalid username or password");
                       guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
                       guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                        guna2MessageDialog1.Show("Invalid username or password");

              

                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
        }

        private void CheckShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckShowpass.Checked)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
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
    }
}
