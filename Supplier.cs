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
    public partial class Supplier : Sample
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvEmail);


            string qry = @"Select * from Supplier
                         where supName like '%" + SearchBox.Text + "%' order by supID desc ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddSupplier sup = new AddSupplier();
                sup.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                sup.NameBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);
                sup.PhoneBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                sup.Emailbox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvEmail"].Value);


                MainClass.BlurBackground(sup);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Are you sure want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from Supplier where supID = " + id + "";
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
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new AddSupplier());
            LoadData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
        
 