namespace KatPharmacySytem.View
{
    partial class ProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BrowseButton = new Guna.UI2.WinForms.Guna2Button();
            this.CostBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarcodeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.PicB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicB)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Parent = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.guna2Panel1.Controls.Add(this.Label1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1119, 114);
            this.guna2Panel1.TabIndex = 67;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 37.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(23, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(452, 69);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Medicine Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 38);
            this.label5.TabIndex = 66;
            this.label5.Text = "Category";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.BorderRadius = 20;
            this.Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Category.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.IntegralHeight = false;
            this.Category.ItemHeight = 35;
            this.Category.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.Category.Location = new System.Drawing.Point(408, 213);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(262, 41);
            this.Category.TabIndex = 55;
            this.Category.Tag = "v";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BorderRadius = 25;
            this.BrowseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BrowseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BrowseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BrowseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BrowseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.BrowseButton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseButton.Location = new System.Drawing.Point(866, 359);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(177, 60);
            this.BrowseButton.TabIndex = 57;
            this.BrowseButton.Text = "BROWSE";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CostBox
            // 
            this.CostBox.BorderRadius = 20;
            this.CostBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostBox.DefaultText = "";
            this.CostBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CostBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CostBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostBox.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.CostBox.ForeColor = System.Drawing.Color.Black;
            this.CostBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostBox.Location = new System.Drawing.Point(408, 343);
            this.CostBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CostBox.Name = "CostBox";
            this.CostBox.PasswordChar = '\0';
            this.CostBox.PlaceholderText = "";
            this.CostBox.SelectedText = "";
            this.CostBox.Size = new System.Drawing.Size(140, 48);
            this.CostBox.TabIndex = 58;
            this.CostBox.Tag = "v";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 38);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cost";
            // 
            // PriceBox
            // 
            this.PriceBox.BorderRadius = 20;
            this.PriceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBox.DefaultText = "";
            this.PriceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceBox.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.PriceBox.ForeColor = System.Drawing.Color.Black;
            this.PriceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceBox.Location = new System.Drawing.Point(601, 343);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PasswordChar = '\0';
            this.PriceBox.PlaceholderText = "";
            this.PriceBox.SelectedText = "";
            this.PriceBox.Size = new System.Drawing.Size(138, 48);
            this.PriceBox.TabIndex = 56;
            this.PriceBox.Tag = "v";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 38);
            this.label3.TabIndex = 63;
            this.label3.Text = "Sale Price";
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.BorderRadius = 20;
            this.BarcodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarcodeBox.DefaultText = "";
            this.BarcodeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BarcodeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BarcodeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BarcodeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BarcodeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BarcodeBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.BarcodeBox.ForeColor = System.Drawing.Color.Black;
            this.BarcodeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BarcodeBox.Location = new System.Drawing.Point(44, 343);
            this.BarcodeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.PasswordChar = '\0';
            this.BarcodeBox.PlaceholderText = "";
            this.BarcodeBox.SelectedText = "";
            this.BarcodeBox.Size = new System.Drawing.Size(301, 48);
            this.BarcodeBox.TabIndex = 55;
            this.BarcodeBox.Tag = "v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 62;
            this.label2.Text = "Barcode";
            // 
            // NameBox
            // 
            this.NameBox.BorderRadius = 20;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(183)))));
            this.NameBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.NameBox.Location = new System.Drawing.Point(44, 213);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(301, 48);
            this.NameBox.TabIndex = 54;
            this.NameBox.Tag = "v";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(46, 163);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(118, 38);
            this.Username.TabIndex = 61;
            this.Username.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 25;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(255, 459);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 60);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 25;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(44, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 60);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PicB
            // 
            this.PicB.FillColor = System.Drawing.Color.Transparent;
            this.PicB.Image = ((System.Drawing.Image)(resources.GetObject("PicB.Image")));
            this.PicB.ImageRotate = 0F;
            this.PicB.Location = new System.Drawing.Point(793, 140);
            this.PicB.Name = "PicB";
            this.PicB.Size = new System.Drawing.Size(300, 200);
            this.PicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB.TabIndex = 73;
            this.PicB.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "*per capsule or bottle";
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1119, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PicB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Username);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox Category;
        private Guna.UI2.WinForms.Guna2Button BrowseButton;
        public Guna.UI2.WinForms.Guna2TextBox CostBox;
        internal System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox PriceBox;
        internal System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox BarcodeBox;
        internal System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox NameBox;
        internal System.Windows.Forms.Label Username;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2PictureBox PicB;
        private System.Windows.Forms.Label label6;
    }
}