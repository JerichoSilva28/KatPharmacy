using CrystalDecisions.Shared;
using KatPharmacySytem.Report;
using KatPharmacySytem.View;
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

namespace KatPharmacySytem
{
    public partial class Reportform : Sample
    {
        public Reportform()
        {
            InitializeComponent();
        }

        private DataTable dTable(string qry)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        private void btnStock_Click(object sender, EventArgs e)
        {

            string qry = @"Select proID, pName,
            (select SUM(qty) From Details d inner join PurchaseMain m on m.MainID = d.dMainID where m.mType = 'PUR' and d.productID = proID) -  
            (select SUM(qty) From Details d inner join PurchaseMain m on m.MainID = d.dMainID where m.mType = 'SAL' and d.productID = proID) 
            as pStock from Product";

            DataTable dt = dTable(qry);

            ReportPrint rep = new ReportPrint();
            Stock stock = new Stock();

            stock.SetDataSource(dt);
            rep.crystalReportViewer1.ReportSource = stock;
            rep.crystalReportViewer1.Refresh();
            rep.Show();



        }

        private void btnMedList_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from Product p inner join Category c on p.pCatID = c.catID";
            DataTable dt = dTable(qry);

            ReportPrint rep = new ReportPrint();
            Medicine medicine = new Medicine();

            medicine.SetDataSource(dt);
            rep.crystalReportViewer1.ReportSource = medicine;
            rep.crystalReportViewer1.Refresh();
            rep.Show();
             


        }
    }
}
