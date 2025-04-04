using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem
{
    public partial class ViewUser : System.Windows.Forms.Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        public virtual void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new User());
            LoadData();
        }

        public virtual void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvuserRole);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvuserName);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvphone);

            string qry = @"Select userID, uUserRole, uName, uUsername,uPass , uPhone from users
                         where uName like '%" + SearchBox.Text + "%' order by userID desc ";
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                User user = new User();
                user.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                user.UserRole.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvuserRole"].Value);
                user.NameBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);
                user.PhoneBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvphone"].Value);
                user.UsernameBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvuserName"].Value);
                user.PassBox.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvpass"].Value);

                MainClass.BlurBackground(user);
                LoadData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {

                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from users where userID = " + id + "";
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

        private void ViewUser_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}

