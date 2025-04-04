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
    public partial class Medicineform : Sample
    {
        public Medicineform()
        {
            InitializeComponent();
        }

        private void Medicineform_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new ProductAdd());
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvbarcode);
            lb.Items.Add(dgvCost);
            lb.Items.Add(dgvSale);

            string qry = @"Select proID, pName, pCatID,catName, pBarcode,pCost,pPrice from Product
                         inner join category on catID = pCatID
                         where pName like '%" + SearchBox.Text + "%' order by proID desc ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }


        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                ProductAdd user = new ProductAdd();
                user.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                user.catID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                user.NameBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);
                user.BarcodeBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvbarcode"].Value);
                user.CostBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCost"].Value);
                user.PriceBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvSale"].Value);

                MainClass.BlurBackground(user);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {

                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from Product where proID = " + id + "";
                Hashtable ht = new Hashtable();
                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Deleted Successfully");
                    LoadData();
                }


            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
