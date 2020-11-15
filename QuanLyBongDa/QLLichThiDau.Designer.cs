namespace QuanLyBongDa
{
    partial class QLLichThiDau
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dGVlichThiDau = new System.Windows.Forms.DataGridView();
            this.tBmaTD = new System.Windows.Forms.TextBox();
            this.lbVongDau = new System.Windows.Forms.Label();
            this.lbSan = new System.Windows.Forms.Label();
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.lbMaDoi2 = new System.Windows.Forms.Label();
            this.lbMaDoi1 = new System.Windows.Forms.Label();
            this.lbMaTD = new System.Windows.Forms.Label();
            this.tBsanThiDau = new System.Windows.Forms.TextBox();
            this.tBngayGio = new System.Windows.Forms.TextBox();
            this.cBvongDau = new System.Windows.Forms.ComboBox();
            this.cBdoi1 = new System.Windows.Forms.ComboBox();
            this.cBdoi2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVlichThiDau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(360, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(360, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dGVlichThiDau
            // 
            this.dGVlichThiDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVlichThiDau.Location = new System.Drawing.Point(32, 200);
            this.dGVlichThiDau.Name = "dGVlichThiDau";
            this.dGVlichThiDau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVlichThiDau.Size = new System.Drawing.Size(739, 238);
            this.dGVlichThiDau.TabIndex = 34;
            // 
            // tBmaTD
            // 
            this.tBmaTD.Enabled = false;
            this.tBmaTD.Location = new System.Drawing.Point(348, 12);
            this.tBmaTD.Name = "tBmaTD";
            this.tBmaTD.Size = new System.Drawing.Size(162, 20);
            this.tBmaTD.TabIndex = 1;
            // 
            // lbVongDau
            // 
            this.lbVongDau.AutoSize = true;
            this.lbVongDau.Location = new System.Drawing.Point(29, 138);
            this.lbVongDau.Name = "lbVongDau";
            this.lbVongDau.Size = new System.Drawing.Size(57, 13);
            this.lbVongDau.TabIndex = 22;
            this.lbVongDau.Text = "Vòng đấu:";
            // 
            // lbSan
            // 
            this.lbSan.AutoSize = true;
            this.lbSan.Location = new System.Drawing.Point(486, 96);
            this.lbSan.Name = "lbSan";
            this.lbSan.Size = new System.Drawing.Size(65, 13);
            this.lbSan.TabIndex = 23;
            this.lbSan.Text = "Sân thi đấu:";
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Location = new System.Drawing.Point(29, 93);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(52, 13);
            this.lbNgayGio.TabIndex = 24;
            this.lbNgayGio.Text = "Ngày giờ:";
            // 
            // lbMaDoi2
            // 
            this.lbMaDoi2.AutoSize = true;
            this.lbMaDoi2.Location = new System.Drawing.Point(486, 49);
            this.lbMaDoi2.Name = "lbMaDoi2";
            this.lbMaDoi2.Size = new System.Drawing.Size(35, 13);
            this.lbMaDoi2.TabIndex = 25;
            this.lbMaDoi2.Text = "Đội 2:";
            // 
            // lbMaDoi1
            // 
            this.lbMaDoi1.AutoSize = true;
            this.lbMaDoi1.Location = new System.Drawing.Point(29, 49);
            this.lbMaDoi1.Name = "lbMaDoi1";
            this.lbMaDoi1.Size = new System.Drawing.Size(35, 13);
            this.lbMaDoi1.TabIndex = 26;
            this.lbMaDoi1.Text = "Đội 1:";
            // 
            // lbMaTD
            // 
            this.lbMaTD.AutoSize = true;
            this.lbMaTD.Location = new System.Drawing.Point(274, 15);
            this.lbMaTD.Name = "lbMaTD";
            this.lbMaTD.Size = new System.Drawing.Size(61, 13);
            this.lbMaTD.TabIndex = 27;
            this.lbMaTD.Text = "Mã thi đấu:";
            // 
            // tBsanThiDau
            // 
            this.tBsanThiDau.Enabled = false;
            this.tBsanThiDau.Location = new System.Drawing.Point(555, 93);
            this.tBsanThiDau.Name = "tBsanThiDau";
            this.tBsanThiDau.Size = new System.Drawing.Size(216, 20);
            this.tBsanThiDau.TabIndex = 5;
            // 
            // tBngayGio
            // 
            this.tBngayGio.Location = new System.Drawing.Point(98, 90);
            this.tBngayGio.Name = "tBngayGio";
            this.tBngayGio.Size = new System.Drawing.Size(132, 20);
            this.tBngayGio.TabIndex = 4;
            // 
            // cBvongDau
            // 
            this.cBvongDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBvongDau.FormattingEnabled = true;
            this.cBvongDau.Location = new System.Drawing.Point(98, 135);
            this.cBvongDau.Name = "cBvongDau";
            this.cBvongDau.Size = new System.Drawing.Size(132, 21);
            this.cBvongDau.TabIndex = 6;
            // 
            // cBdoi1
            // 
            this.cBdoi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoi1.FormattingEnabled = true;
            this.cBdoi1.Location = new System.Drawing.Point(98, 45);
            this.cBdoi1.Name = "cBdoi1";
            this.cBdoi1.Size = new System.Drawing.Size(219, 21);
            this.cBdoi1.TabIndex = 2;
            this.cBdoi1.SelectedValueChanged += new System.EventHandler(this.cBdoi1_SelectedValueChanged);
            // 
            // cBdoi2
            // 
            this.cBdoi2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBdoi2.FormattingEnabled = true;
            this.cBdoi2.Location = new System.Drawing.Point(555, 45);
            this.cBdoi2.Name = "cBdoi2";
            this.cBdoi2.Size = new System.Drawing.Size(216, 21);
            this.cBdoi2.TabIndex = 3;
            // 
            // QLLichThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBdoi2);
            this.Controls.Add(this.cBdoi1);
            this.Controls.Add(this.cBvongDau);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dGVlichThiDau);
            this.Controls.Add(this.tBsanThiDau);
            this.Controls.Add(this.tBngayGio);
            this.Controls.Add(this.tBmaTD);
            this.Controls.Add(this.lbVongDau);
            this.Controls.Add(this.lbSan);
            this.Controls.Add(this.lbNgayGio);
            this.Controls.Add(this.lbMaDoi2);
            this.Controls.Add(this.lbMaDoi1);
            this.Controls.Add(this.lbMaTD);
            this.Name = "QLLichThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Thi Đấu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLLichThiDau_FormClosing);
            this.Load += new System.EventHandler(this.QLLichThiDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVlichThiDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dGVlichThiDau;
        private System.Windows.Forms.TextBox tBmaTD;
        private System.Windows.Forms.Label lbVongDau;
        private System.Windows.Forms.Label lbSan;
        private System.Windows.Forms.Label lbNgayGio;
        private System.Windows.Forms.Label lbMaDoi2;
        private System.Windows.Forms.Label lbMaDoi1;
        private System.Windows.Forms.Label lbMaTD;
        private System.Windows.Forms.TextBox tBsanThiDau;
        private System.Windows.Forms.TextBox tBngayGio;
        private System.Windows.Forms.ComboBox cBvongDau;
        private System.Windows.Forms.ComboBox cBdoi1;
        private System.Windows.Forms.ComboBox cBdoi2;
    }
}