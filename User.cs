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

namespace KatPharmacySytem
{
    public partial class User : System.Windows.Forms.Form
    {
        MainClass fn = new MainClass();
        String qry;
        DataSet ds;
        public User()
        {
            InitializeComponent();
        }
        public int id = 0;
        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Please try again");
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"Insert into users values(@userrole,@name,@username,@pass,@phone,@image)";

                }
                else
                {
                    qry = @"UPDATE users set uUserRole =@userrole,
                                            uName = @name ,
                                            uUsername = @username, 
                                            uPass = @pass, 
                                            uPhone = @phone,
                                            uImage = @image
                                            where userID = @id";
                }

                Image temp = new Bitmap(PicB.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);

                ht.Add("@userrole", UserRole.Text);
                ht.Add("@name", NameBox.Text);
                ht.Add("@username", UsernameBox.Text);
                ht.Add("@pass", PassBox.Text);
                ht.Add("phone", PhoneBox.Text);
                ht.Add("image", imageByteArray);
            
                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("Data Saved Successfully");

                    id = 0;
                    NameBox.Text = "";
                    UserRole.Text = "";
                    UsernameBox.Text = "";
                    PassBox.Text = "";
                    PhoneBox.Text = "";

                    //PicB.Image = KatPharmacySytem.Properties.Resources.userPic;
                    NameBox.Focus();
                }
            }
        }

        public string filePath = "";
        Byte[] imageByteArray;

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Images(*.JPG)|*.JPG|ALL FILES(*.*)|*.*";  //"Images(.jpg, .png)|*.png, *jpg ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                PicB.Image = new Bitmap(filePath);
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
             qry = "select * from users where uUsername='" + UsernameBox.Text + "'";
            DataSet ds = fn.getData(qry);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\\Users\\jeril\\Downloads\\Kat Pharmacy System\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\\Users\\jeril\\Downloads\\Kat Pharmacy System\no.png";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LoadImage()
        {
            string qry = @"Select uImage from users where userID = "+id+"";
            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                Byte[] imageAraay = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArray = imageAraay;
                PicB.Image =Image.FromStream(new MemoryStream(imageAraay));
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            if (id>0)
            {
                LoadImage();
            }
        }
    }
}
