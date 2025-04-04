using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem.View
{
    public partial class SaleAdd : Sample
    {
        public SaleAdd()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BarcodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        public int id = 0; 
        public int cusID = 0;
        private void SaleAdd_Load(object sender, EventArgs e)
        {
            string qry = @"Select cusID 'id' , cusName 'name' from Customer";
            MainClass.CBFill(qry, cbCustomer);

            if(cusID>0)
            {
                cbCustomer.SelectedValue = cusID;
                LoadForEdit();
                Total();
            }

            LoadMedicineFromDatabase();
        }

        public void AddItems(string id, string name, string price, Image pimage, string cost)
        {
            var w = new uMed()
            {
                Pname = name,
                Price = price,
                PImage = pimage,
                PCost = cost,
                id = Convert.ToInt32(id)
            };

            flowLayoutPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (uMed)ss;
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproid"].Value) == wdg.id)
                    {
                        item.Cells["dgvqty"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) + 1;
                       

                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) * 
                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        Total();
                        return;
                    }
                }

                guna2DataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.Pname, 1, wdg.Price, wdg.Price, wdg.PCost });
                Total();
            };
        }

        public void Total()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows )
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");
        }

        private void LoadMedicineFromDatabase()
        {
            string qry = "Select * from Product";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                foreach(DataRow row in dt.Rows ) 
                {
                    Byte[] imageArray = (byte[])row["PImage"];
                    byte[] imageByteArray = imageArray;

                    AddItems(row["proID"].ToString(), row["pName"].ToString(), row["pPrice"].ToString(),
                        Image.FromStream(new MemoryStream(imageArray)), row["pCost"].ToString());
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            Datebox.Value = DateTime.Now;
            cbCustomer.SelectedIndex = 0;
            cbCustomer.SelectedIndex = -1;
            lblTotal.Text = "0.00";
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in flowLayoutPanel1.Controls)
            {
                var pro = (uMed)item;
                pro.Visible = pro.Pname.ToLower().Contains(SearchBox.Text.Trim().ToLower());
            }
        }

        private void BarcodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BarcodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qry = "Select * from Product where pBarcode  like '" + BarcodeBox.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                    {

                        if (Convert.ToInt32(item.Cells["dgvproid"].Value) == int.Parse(row["proID"].ToString()))
                        {
                            item.Cells["dgvqty"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) + 1;
                            item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) *
                                      double.Parse(item.Cells["dgvPrice"].Value.ToString());
                            Total();
                            BarcodeBox.Text = "";
                            return;
                        }
                    }

                    guna2DataGridView1.Rows.Add(new object[] { 0, row["proID"].ToString(),
                               row["pName"].ToString(), 1, row["pPrice"].ToString(),
                               row["pPrice"].ToString(), row["pCost"].ToString() });
                    BarcodeBox.Text = "";

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";

            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please try again");
                return;
            }



            int record = 0;

            if (id == 0)
            {
                qry1 = @"Insert into PurchaseMain Values (@date,@type,@supID);
                                Select SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"UPDATE PurchaseMain set mdate = @date, mType = @type, 
                                                 mSupCusID = @supID where MainID = @id";
            }

            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(Datebox.Value).Date);
            cmd1.Parameters.AddWithValue("@type", "SAL");
            cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(cbCustomer.SelectedValue));
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }


            if (id == 0)
            {
                id = Convert.ToInt32(cmd1.ExecuteScalar());
            }
            else
            {
                cmd1.ExecuteNonQuery();
            }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                int did = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (did == 0)
                {
                    qry2 = @"Insert into Details Values (@mID,@proID,@qty,@price,@amount,@cost)";
                }
                else
                {
                    qry2 = @"UPDATE Details set dMainID =@mID, productID = @proID, qty =@qty,  
                                                price =@price,amount =@amount, cost =@cost where detailID = @id";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@id", did);
                cmd2.Parameters.AddWithValue("@mID", id);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproid"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@cost", Convert.ToDouble(row.Cells["dgvCost"].Value));

                record += cmd2.ExecuteNonQuery();
            }

            if (record > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Saved Successfully");

                id = 0;
                cusID = 0;
                Datebox.Value = DateTime.Now;
                cbCustomer.SelectedIndex = 0;
                cbCustomer.SelectedIndex = -1;
                guna2DataGridView1.Rows.Clear();
                lblTotal.Text = "0.00";
            }
        }

        private void LoadForEdit()
        {
            string qry = "Select * from Details inner join product on proID= productID where dMainID like '" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string did;
                string pid;
                string pname;
                string qty;
                string cost;
                string amt;

                did = row["detailID"].ToString();
                pname = row["pName"].ToString();
                pid = row["proID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();
                cost = row["cost"].ToString();

                guna2DataGridView1.Rows.Add(did, pid, pname, qty, cost, amt, cost);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
                {

                    int rowindex = guna2DataGridView1.CurrentCell.RowIndex;
                    guna2DataGridView1.Rows.RemoveAt(rowindex);



                    string qry = "Delete from PurchaseMain where MainID = " + id + "";
                    string qry2 = "Delete from Details where dMainID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    if (MainClass.SQl(qry2, ht) > 0)
                    {
                        //guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        // guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        //guna2MessageDialog1.Show("Deleted Successfully");

                    }
                Total();
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

