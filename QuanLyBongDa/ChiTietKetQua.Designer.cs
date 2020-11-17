
namespace QuanLyBongDa
{
    partial class ChiTietKetQua
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
            this.lbSTT = new System.Windows.Forms.Label();
            this.lbCauThu = new System.Windows.Forms.Label();
            this.lbDoiBong = new System.Windows.Forms.Label();
            this.lbLoaiBanThang = new System.Windows.Forms.Label();
            this.lbThoiDiem = new System.Windows.Forms.Label();
            this.lbMaKQ = new System.Windows.Forms.Label();
            this.tBstt = new System.Windows.Forms.TextBox();
            this.tBthoiDiem = new System.Windows.Forms.TextBox();
            this.tBloaiBT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dGVketQua = new System.Windows.Forms.DataGridView();
            this.cBcauThu = new System.Windows.Forms.ComboBox();
            this.cBdoiBong = new System.Windows.Forms.ComboBox();
            this.cBmaKQ = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVketQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Location = new System.Drawing.Point(29, 13);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(31, 13);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "STT:";
            // 
            // lbCauThu
            // 
            this.lbCauThu.AutoSize = true;
            this.lbCauThu.Location = new System.Drawing.Point(29, 57);
            this.lbCauThu.Name = "lbCauThu";
            this.lbCauThu.Size = new System.Drawing.Size(47, 13);
            this.lbCauThu.TabIndex = 0;
            this.lbCauThu.Text = "Cầu thủ:";
            // 
            // lbDoiBong
            // 
            this.lbDoiBong.AutoSize = true;
            this.lbDoiBong.Location = new System.Drawing.Point(283, 13);
            this.lbDoiBong.Name = "lbDoiBong";
            this.lbDoiBong.Size = new System.Drawing.Size(53, 13);
            this.lbDoiBong.TabIndex = 0;
            this.lbDoiBong.Text = "Đội bóng:";
            // 
            // lbLoaiBanThang
            // 
            this.lbLoaiBanThang.AutoSize = true;
            this.lbLoaiBanThang.Location = new System.Drawing.Point(283, 57);
            this.lbLoaiBanThang.Name = "lbLoaiBanThang";
            this.lbLoaiBanThang.Size = new System.Drawing.Size(81, 13);
            this.lbLoaiBanThang.TabIndex = 0;
            this.lbLoaiBanThang.Text = "Loại bàn thắng:";
            // 
            // lbThoiDiem
            // 
            this.lbThoiDiem.AutoSize = true;
            this.lbThoiDiem.Location = new System.Drawing.Point(29, 103);
            this.lbThoiDiem.Name = "lbThoiDiem";
            this.lbThoiDiem.Size = new System.Drawing.Size(57, 13);
            this.lbThoiDiem.TabIndex = 0;
            this.lbThoiDiem.Text = "Thời điểm:";
            // 
            // lbMaKQ
            // 
            this.lbMaKQ.AutoSize = true;
            this.lbMaKQ.Location = new System.Drawing.Point(283, 103);
            this.lbMaKQ.Name = "lbMaKQ";
            this.lbMaKQ.Size = new System.Drawing.Size(64, 13);
            this.lbMaKQ.TabIndex = 0;
            this.lbMaKQ.Text = "Mã kết quả:";
            // 
            // tBstt
            // 
            this.tBstt.Enabled = false;
            this.tBstt.Location = new System.Drawing.Point(97, 10);
            this.tBstt.Name = "tBstt";
            this.tBstt.Size = new System.Drawing.Size(56, 20);
            this.tBstt.TabIndex = 1;
            // 
            // tBthoiDiem
            // 
            this.tBthoiDiem.Location = new System.Drawing.Point(97, 96);
            this.tBthoiDiem.Name = "tBthoiDiem";
            this.tBthoiDiem.Size = new System.Drawing.Size(56, 20);
            this.tBthoiDiem.TabIndex = 5;
            // 
            // tBloaiBT
            // 
            this.tBloaiBT.Location = new System.Drawing.Point(384, 54);
            this.tBloaiBT.Name = "tBloaiBT";
            this.tBloaiBT.Size = new System.Drawing.Size(100, 20);
            this.tBloaiBT.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(97, 135);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(209, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(322, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dGVketQua
            // 
            this.dGVketQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVketQua.Location = new System.Drawing.Point(32, 178);
            this.dGVketQua.Name = "dGVketQua";
            this.dGVketQua.Size = new System.Drawing.Size(452, 260);
            this.dGVketQua.TabIndex = 3;
            // 
            // cBcauThu
            // 
            this.cBcauThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcauThu.FormattingEnabled = true;
            this.cBcauThu.Location = new System.Drawing.Point(97, 54);
            this.cBcauThu.Name = "cBcauThu";
            this.cBcauThu.Size = new System.Drawing.Size(145, 21);
            this.cBcauThu.TabIndex = 3;
            // 
            // cBdoiBong
            // 
            this.cBdoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoiBong.FormattingEnabled = true;
            this.cBdoiBong.Location = new System.Drawing.Point(342, 10);
            this.cBdoiBong.Name = "cBdoiBong";
            this.cBdoiBong.Size = new System.Drawing.Size(145, 21);
            this.cBdoiBong.TabIndex = 2;
            // 
            // cBmaKQ
            // 
            this.cBmaKQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBmaKQ.FormattingEnabled = true;
            this.cBmaKQ.Location = new System.Drawing.Point(369, 100);
            this.cBmaKQ.Name = "cBmaKQ";
            this.cBmaKQ.Size = new System.Drawing.Size(118, 21);
            this.cBmaKQ.TabIndex = 6;
            // 
            // ChiTietKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.cBdoiBong);
            this.Controls.Add(this.cBmaKQ);
            this.Controls.Add(this.cBcauThu);
            this.Controls.Add(this.dGVketQua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tBloaiBT);
            this.Controls.Add(this.tBthoiDiem);
            this.Controls.Add(this.tBstt);
            this.Controls.Add(this.lbMaKQ);
            this.Controls.Add(this.lbThoiDiem);
            this.Controls.Add(this.lbLoaiBanThang);
            this.Controls.Add(this.lbDoiBong);
            this.Controls.Add(this.lbCauThu);
            this.Controls.Add(this.lbSTT);
            this.Name = "ChiTietKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Kết Quả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietKetQua_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVketQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Label lbCauThu;
        private System.Windows.Forms.Label lbDoiBong;
        private System.Windows.Forms.Label lbLoaiBanThang;
        private System.Windows.Forms.Label lbThoiDiem;
        private System.Windows.Forms.Label lbMaKQ;
        private System.Windows.Forms.TextBox tBstt;
        private System.Windows.Forms.TextBox tBthoiDiem;
        private System.Windows.Forms.TextBox tBloaiBT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dGVketQua;
        private System.Windows.Forms.ComboBox cBcauThu;
        private System.Windows.Forms.ComboBox cBdoiBong;
        private System.Windows.Forms.ComboBox cBmaKQ;
    }
}