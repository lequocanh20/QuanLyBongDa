namespace QuanLyBongDa
{
    partial class ThemLichThiDau
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tBmaTD = new System.Windows.Forms.TextBox();
            this.lbVongDau = new System.Windows.Forms.Label();
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.lbMaTD = new System.Windows.Forms.Label();
            this.cBvongDau = new System.Windows.Forms.ComboBox();
            this.dTPlichThiDau = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(143, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(46, 128);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 52;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tBmaTD
            // 
            this.tBmaTD.Location = new System.Drawing.Point(84, 6);
            this.tBmaTD.Name = "tBmaTD";
            this.tBmaTD.Size = new System.Drawing.Size(162, 20);
            this.tBmaTD.TabIndex = 49;
            // 
            // lbVongDau
            // 
            this.lbVongDau.AutoSize = true;
            this.lbVongDau.Location = new System.Drawing.Point(15, 90);
            this.lbVongDau.Name = "lbVongDau";
            this.lbVongDau.Size = new System.Drawing.Size(57, 13);
            this.lbVongDau.TabIndex = 38;
            this.lbVongDau.Text = "Vòng đấu:";
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Location = new System.Drawing.Point(15, 49);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(52, 13);
            this.lbNgayGio.TabIndex = 40;
            this.lbNgayGio.Text = "Ngày giờ:";
            // 
            // lbMaTD
            // 
            this.lbMaTD.AutoSize = true;
            this.lbMaTD.Location = new System.Drawing.Point(15, 9);
            this.lbMaTD.Name = "lbMaTD";
            this.lbMaTD.Size = new System.Drawing.Size(61, 13);
            this.lbMaTD.TabIndex = 43;
            this.lbMaTD.Text = "Mã thi đấu:";
            // 
            // cBvongDau
            // 
            this.cBvongDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBvongDau.FormattingEnabled = true;
            this.cBvongDau.Location = new System.Drawing.Point(84, 87);
            this.cBvongDau.Name = "cBvongDau";
            this.cBvongDau.Size = new System.Drawing.Size(162, 21);
            this.cBvongDau.TabIndex = 53;
            // 
            // dTPlichThiDau
            // 
            this.dTPlichThiDau.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dTPlichThiDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPlichThiDau.Location = new System.Drawing.Point(84, 45);
            this.dTPlichThiDau.Name = "dTPlichThiDau";
            this.dTPlichThiDau.Size = new System.Drawing.Size(162, 20);
            this.dTPlichThiDau.TabIndex = 54;
            this.dTPlichThiDau.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // ThemLichThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.dTPlichThiDau);
            this.Controls.Add(this.cBvongDau);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tBmaTD);
            this.Controls.Add(this.lbVongDau);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.lbMaTD);
            this.Name = "ThemLichThiDau";
            this.Text = "ThemLichThiDau";
            this.Load += new System.EventHandler(this.ThemLichThiDau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox tBmaTD;
        private System.Windows.Forms.Label lbVongDau;
        private System.Windows.Forms.Label lbNgayGio;
        private System.Windows.Forms.Label lbMaTD;
        private System.Windows.Forms.ComboBox cBvongDau;
        private System.Windows.Forms.DateTimePicker dTPlichThiDau;
    }
}