using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KatPharmacySytem.View
{
    public partial class ProductAdd : Sample
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int catID = 0;

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id' , catName 'name' from Category";
            MainClass.CBFill(qry, Category);

            if (id>0)
            {
                Category.SelectedValue = catID;
                LoadImage();
            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please try again");
                
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"Insert into Product Values(@name,@CatID,@barcode,@cost,@saleprice,@image)";

                }
                else
                {
                    qry = @"UPDATE Product set pName =@name,
                                            pCatID = @pCatID ,
                                            pBarcode = @barcode, 
                                            pCost = @cost,
                                            pPrice = @saleprice,
                                            pImage = @image
                                            where proID = @id";
                }

                Image temp = new Bitmap(PicB.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", NameBox.Text);
                ht.Add("@pCatID", Convert.ToInt32(Category.SelectedValue));
                ht.Add("@barcode", BarcodeBox.Text);
                ht.Add("@cost", Convert.ToDouble(CostBox.Text));
                ht.Add("@saleprice", Convert.ToDouble(PriceBox.Text));
                ht.Add("@image", imageByteArray);



                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Data Saved Successfully");

                    id = 0;
                   
                    NameBox.Text = "";
                    BarcodeBox.Text = "";
                    Category.SelectedIndex = 0;
                    Category.SelectedIndex = -1;
                    CostBox.Text = "";
                    PriceBox.Text = "";
                    NameBox.Focus();
                }
            }
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public string filePath = "";
        Byte[] imageByteArray;
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Images(.JPG, .PNG)|*.JPG, *.PNG|ALL FILES(*.*)|*.*";  //"Images(.jpg, .png)|*.png, *jpg ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                PicB.Image = new Bitmap(filePath);
            }
        }

        private void LoadImage()
        {
            string qry = @"Select pImage from Product where proID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageAraay = (byte[])dt.Rows[0]["pImage"];
                byte[] imageByteArray = imageAraay;
                PicB.Image = Image.FromStream(new MemoryStream(imageAraay));
            }
        }
    }
}
