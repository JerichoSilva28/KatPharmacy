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
    public partial class Categoryform : Sample
    {
        public Categoryform()
        {
            InitializeComponent();
        }

        private void Categoryform_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
        

            string qry = @"Select * from Category
                         where catName like '%" + SearchBox.Text + "%' order by catID desc ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }


        public virtual void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new View.CategoryAdd());
            LoadData();
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                CategoryAdd user = new CategoryAdd();
                user.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                user.NameBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);


                MainClass.BlurBackground(user);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Are you sure want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from Category where catID = " + id + "";
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

        private void SearchBox_TextChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
