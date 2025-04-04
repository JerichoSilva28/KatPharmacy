namespace KatPharmacySytem
{
    partial class Reportform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportform));
            this.Label1 = new System.Windows.Forms.Label();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedList = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(49, 64);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(193, 57);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Reports";
            // 
            // btnStock
            // 
            this.btnStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.btnStock.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.Black;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStock.Location = new System.Drawing.Point(290, 165);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(235, 49);
            this.btnStock.TabIndex = 17;
            this.btnStock.Text = "Stock Balance";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnMedList
            // 
            this.btnMedList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.btnMedList.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMedList.ForeColor = System.Drawing.Color.Black;
            this.btnMedList.Image = ((System.Drawing.Image)(resources.GetObject("btnMedList.Image")));
            this.btnMedList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedList.Location = new System.Drawing.Point(49, 165);
            this.btnMedList.Name = "btnMedList";
            this.btnMedList.Size = new System.Drawing.Size(235, 49);
            this.btnMedList.TabIndex = 18;
            this.btnMedList.Text = "Medicine List";
            this.btnMedList.Click += new System.EventHandler(this.btnMedList_Click);
            // 
            // Reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1115, 767);
            this.Controls.Add(this.btnMedList);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.Label1);
            this.Name = "Reportform";
            this.Text = "Reportform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnMedList;
    }
}