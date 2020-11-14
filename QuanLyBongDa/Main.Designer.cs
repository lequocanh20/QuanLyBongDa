namespace QuanLyBongDa
{
    partial class Main
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
            this.btnXepHang = new System.Windows.Forms.Button();
            this.btnDanhSachGB = new System.Windows.Forms.Button();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.btnLichThiDau = new System.Windows.Forms.Button();
            this.btnCauThu = new System.Windows.Forms.Button();
            this.btnDoiBong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXepHang
            // 
            this.btnXepHang.Location = new System.Drawing.Point(205, 164);
            this.btnXepHang.Name = "btnXepHang";
            this.btnXepHang.Size = new System.Drawing.Size(167, 50);
            this.btnXepHang.TabIndex = 13;
            this.btnXepHang.Text = "Bảng Xếp Hạng";
            this.btnXepHang.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachGB
            // 
            this.btnDanhSachGB.Location = new System.Drawing.Point(205, 87);
            this.btnDanhSachGB.Name = "btnDanhSachGB";
            this.btnDanhSachGB.Size = new System.Drawing.Size(167, 50);
            this.btnDanhSachGB.TabIndex = 14;
            this.btnDanhSachGB.Text = "Danh Sách Cầu Thủ Ghi Bàn";
            this.btnDanhSachGB.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(205, 12);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(167, 50);
            this.btnKetQua.TabIndex = 15;
            this.btnKetQua.Text = "Kết Quả Thi Đấu";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // btnLichThiDau
            // 
            this.btnLichThiDau.Location = new System.Drawing.Point(12, 164);
            this.btnLichThiDau.Name = "btnLichThiDau";
            this.btnLichThiDau.Size = new System.Drawing.Size(167, 50);
            this.btnLichThiDau.TabIndex = 16;
            this.btnLichThiDau.Text = "Quản Lý Lịch Thi Đấu";
            this.btnLichThiDau.UseVisualStyleBackColor = true;
            this.btnLichThiDau.Click += new System.EventHandler(this.btnLichThiDau_Click);
            // 
            // btnCauThu
            // 
            this.btnCauThu.Location = new System.Drawing.Point(12, 87);
            this.btnCauThu.Name = "btnCauThu";
            this.btnCauThu.Size = new System.Drawing.Size(167, 50);
            this.btnCauThu.TabIndex = 17;
            this.btnCauThu.Text = "Quản Lý Cầu Thủ";
            this.btnCauThu.UseVisualStyleBackColor = true;
            this.btnCauThu.Click += new System.EventHandler(this.btnCauThu_Click);
            // 
            // btnDoiBong
            // 
            this.btnDoiBong.Location = new System.Drawing.Point(12, 12);
            this.btnDoiBong.Name = "btnDoiBong";
            this.btnDoiBong.Size = new System.Drawing.Size(167, 50);
            this.btnDoiBong.TabIndex = 18;
            this.btnDoiBong.Text = "Quản Lý Đội Bóng";
            this.btnDoiBong.UseVisualStyleBackColor = true;
            this.btnDoiBong.Click += new System.EventHandler(this.btnDoiBong_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 223);
            this.Controls.Add(this.btnXepHang);
            this.Controls.Add(this.btnDanhSachGB);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.btnLichThiDau);
            this.Controls.Add(this.btnCauThu);
            this.Controls.Add(this.btnDoiBong);
            this.Name = "Main";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepHang;
        private System.Windows.Forms.Button btnDanhSachGB;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Button btnLichThiDau;
        private System.Windows.Forms.Button btnCauThu;
        private System.Windows.Forms.Button btnDoiBong;
    }
}

