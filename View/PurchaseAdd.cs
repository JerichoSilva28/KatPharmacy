using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatPharmacySytem.View
{
    public partial class PurchaseAdd : Sample
    {
        
        public PurchaseAdd()
        {
            InitializeComponent();
            Datebox.Value = DateTime.Now;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MedCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Supplierbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Datebox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BarcodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MedCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(MedCb.SelectedIndex !=-1)
            {
                qtybox.Text = "";
                GetDetails();
            }
        }

        private void GetDetails()
        {
            string qry = "Select * from Product where proID = " + Convert.ToInt32(MedCb.SelectedValue) + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                CostBox.Text = dt.Rows[0]["pCost"].ToString();
                Calculate();
            }
        }

        private void Calculate()
        {
            double qty = 0;
            double cost = 0;
            double amt = 0;

            double.TryParse(qtybox.Text, out qty);
            double.TryParse(CostBox.Text, out cost);

            amt = qty * cost;
            Amountbox.Text = amt.ToString();
        }

        public int mainID = 0;
        public int supID = 0;
        private void PurchaseAdd_Load(object sender, EventArgs e)
        {
            MedCb.SelectedIndexChanged -= new EventHandler(MedCb_SelectedIndexChanged);
            string qry = "Select proID 'id' , pName 'name' from Product";
            string qry2 = "Select supID 'id' , supName 'name' from Supplier";

            MainClass.CBFill(qry, MedCb);
            MainClass.CBFill(qry2, SupplierCb);

            if (supID>0)
            {
                SupplierCb.SelectedValue = supID;
                LoadForEdit();
                
            }

            MedCb.SelectedIndexChanged += new EventHandler(MedCb_SelectedIndexChanged);
        }

        private void qtybox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void BarcodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string qry = "Select * from Product where pBarcode  like '" + BarcodeBox.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MedCb.SelectedValue = Convert.ToInt32(dt.Rows[0]["proID"].ToString());
                    Calculate();
                    BarcodeBox.Text = "";
                }
            }
        }
        

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string pid;
            string pname;
            string qty;
            string cost;
            string amt;

            pname = MedCb.Text;
            pid = MedCb.SelectedValue.ToString();
            qty = qtybox.Text;
            cost = CostBox.Text;
            amt = Amountbox.Text;

            guna2DataGridView1.Rows.Add(0,0, pid, pname, qty, cost,amt);
            MedCb.SelectedIndex = 0;
            MedCb.SelectedIndex = -1;
            qtybox.Text = "";
            CostBox.Text = "";
            Amountbox.Text = "";

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int count = 0; 

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;

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

            if (mainID == 0)
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
            cmd1.Parameters.AddWithValue("@id", mainID);
            cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(Datebox.Value).Date);
            cmd1.Parameters.AddWithValue("@type", "PUR");
            cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(SupplierCb.SelectedValue));
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }


            if (mainID == 0)
            {
                mainID = Convert.ToInt32(cmd1.ExecuteScalar());
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
                cmd2.Parameters.AddWithValue("@mID", mainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproid"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvCost"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@cost", Convert.ToDouble(row.Cells["dgvCost"].Value));

                record += cmd2.ExecuteNonQuery();
            }

            if (record > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Saved Successfully");

                mainID = 0;
                supID = 0;
                Datebox.Value = DateTime.Now;
                SupplierCb.SelectedIndex = 0;
                SupplierCb.SelectedIndex = -1;
                guna2DataGridView1.Rows.Clear();
            }

        }

        private void LoadForEdit()
        {
            string qry = "Select * from Details inner join product on proID= productID where dMainID like '" + mainID + "'";
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
                pid = row["productID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();

                guna2DataGridView1.Rows.Add(0, did, pid, pname, qty, cost, amt);
            }
        }

        private void SupplierCb_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
