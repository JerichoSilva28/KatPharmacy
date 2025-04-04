using KatPharmacySytem.View;
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
    public partial class Saleform : Sample
    {
        public Saleform()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new SaleAdd());
            LoadData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvCusID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvAmount);


            string qry = @"Select dMainID, mdate, m.mSupCusID,c.cusName, SUM(d.amount) from PurchaseMain m
                         inner join Details d on d.dMainID = m.MainID
                         inner join Customer c on c.cusID = m.mSupCusID
                         where m.mType = 'SAL' and cusName like '%" + SearchBox.Text + "%' group by dMainID, mdate, m.mSupCusID, c.cusName ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                SaleAdd user = new SaleAdd();
                user.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                user.cusID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCusID"].Value);


                MainClass.BlurBackground(user);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.OK)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from PurchaseMain where MainID = " + id + "";
                    string qry2 = "Delete from Details where dMainID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    if (MainClass.SQl(qry2, ht) > 0)
                    {
                        guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        guna2MessageDialog1.Show("Deleted Successfully");
                        LoadData();
                    }
                }
            }
        }

        private void Saleform_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
