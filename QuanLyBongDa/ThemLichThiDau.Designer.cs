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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // ThemLichThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tBmaTD);
            this.Controls.Add(this.lbVongDau);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.lbMaTD);
            this.Name = "ThemLichThiDau";
            this.Text = "ThemLichThiDau";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}