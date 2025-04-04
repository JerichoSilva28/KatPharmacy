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
    public partial class Purchaseform : Sample
    {
        public Purchaseform()
        {
            InitializeComponent();
        }

        private void Purchaseform_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvSupID);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvAmount);

            string qry = @"Select dMainID, mdate, m.mSupCusID,s.supName, SUM(d.amount) from PurchaseMain m
                         inner join Details d on d.dMainID = m.MainID
                         inner join Supplier s on s.supID = m.mSupCusID
                         where m.mType = 'PUR' and supName like '%" + SearchBox.Text + "%' group by dMainID, mdate, m.mSupCusID, s.supName ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                PurchaseAdd user = new PurchaseAdd();
                user.mainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                user.supID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvSupID"].Value);
              

                MainClass.BlurBackground(user);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
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

        private void SearchBox_TextChanged_1(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new PurchaseAdd());
            LoadData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
