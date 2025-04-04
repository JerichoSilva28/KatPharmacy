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
    public partial class Dashboard : System.Windows.Forms.Form
    {
        MainClass ma = new MainClass();
        String qry;
        DataSet ds;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            qry = "select count(uUserRole) from users where uUserRole = 'Administrator'";
            ds = ma.getData(qry);
            setLabel(ds, adminLabel);

            qry = "select count(uUserRole) from users where uUserRole = 'Pharmacist'";
            ds = ma.getData(qry);
            setLabel(ds, PharLabel);
        }
    }
}
