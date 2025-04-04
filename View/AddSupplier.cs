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

namespace KatPharmacySytem.View
{
    public partial class AddSupplier : Sample
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please try again");
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"Insert into Supplier values(@name,@phone,@email)";

                }
                else
                {
                    qry = @"UPDATE Supplier set supName = @name,
                                            supPhone = @phone,
                                            supEmail = @email
                                            where supID = @id";
                }



                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", NameBox.Text);
                ht.Add("@phone", PhoneBox.Text);
                ht.Add("@email", Emailbox.Text);


                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Data Saved Successfully");

                    id = 0;
                    NameBox.Text = "";
                    PhoneBox.Text = "";
                    Emailbox.Text = "";
                    NameBox.Focus();
                }
            }
        }
    }
}

