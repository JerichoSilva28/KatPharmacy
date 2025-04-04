namespace KatPharmacySytem
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashBoardButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1526, 67);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1475, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(183)))));
            this.Panel2.Location = new System.Drawing.Point(419, 64);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1107, 796);
            this.Panel2.TabIndex = 10;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.Panel1.Controls.Add(this.LogoutButton);
            this.Panel1.Controls.Add(this.DashBoardButton);
            this.Panel1.Controls.Add(this.ViewUserButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.userNameLabel);
            this.Panel1.Location = new System.Drawing.Point(0, 64);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(419, 796);
            this.Panel1.TabIndex = 9;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Animated = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.LogoutButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.LogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.LogoutButton.FocusedColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(183)))));
            this.LogoutButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageSize = new System.Drawing.Size(45, 45);
            this.LogoutButton.Location = new System.Drawing.Point(0, 559);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(5);
            this.LogoutButton.Size = new System.Drawing.Size(419, 74);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseTransparentBackground = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.Animated = true;
            this.DashBoardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoardButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.DashBoardButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.DashBoardButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DashBoardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.DashBoardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashBoardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.DashBoardButton.FocusedColor = System.Drawing.Color.Transparent;
            this.DashBoardButton.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.ForeColor = System.Drawing.Color.Black;
            this.DashBoardButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(183)))));
            this.DashBoardButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.DashBoardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashBoardButton.Image")));
            this.DashBoardButton.ImageSize = new System.Drawing.Size(45, 45);
            this.DashBoardButton.Location = new System.Drawing.Point(0, 355);
            this.DashBoardButton.Margin = new System.Windows.Forms.Padding(5);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Padding = new System.Windows.Forms.Padding(5);
            this.DashBoardButton.Size = new System.Drawing.Size(419, 77);
            this.DashBoardButton.TabIndex = 13;
            this.DashBoardButton.Text = "Dashboard";
            this.DashBoardButton.UseTransparentBackground = true;
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // ViewUserButton
            // 
            this.ViewUserButton.Animated = true;
            this.ViewUserButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewUserButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.ViewUserButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ViewUserButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewUserButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.ViewUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewUserButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.ViewUserButton.FocusedColor = System.Drawing.Color.Transparent;
            this.ViewUserButton.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserButton.ForeColor = System.Drawing.Color.Black;
            this.ViewUserButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(183)))));
            this.ViewUserButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ViewUserButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewUserButton.Image")));
            this.ViewUserButton.ImageSize = new System.Drawing.Size(45, 45);
            this.ViewUserButton.Location = new System.Drawing.Point(0, 456);
            this.ViewUserButton.Margin = new System.Windows.Forms.Padding(5);
            this.ViewUserButton.Name = "ViewUserButton";
            this.ViewUserButton.Padding = new System.Windows.Forms.Padding(5);
            this.ViewUserButton.Size = new System.Drawing.Size(419, 74);
            this.ViewUserButton.TabIndex = 12;
            this.ViewUserButton.Text = "Users";
            this.ViewUserButton.UseTransparentBackground = true;
            this.ViewUserButton.Click += new System.EventHandler(this.ViewUserButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(30, 263);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(362, 51);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ADMINISTRATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(119, 120);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(419, 51);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "admin";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Kat Pharmacy";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 860);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private Guna.UI2.WinForms.Guna2Button DashBoardButton;
        private Guna.UI2.WinForms.Guna2Button ViewUserButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label1;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}