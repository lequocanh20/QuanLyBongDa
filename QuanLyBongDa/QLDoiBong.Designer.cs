﻿namespace QuanLyBongDa
{
    partial class QLDoiBong
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
            this.dGVdoiBong = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tBsanNha = new System.Windows.Forms.TextBox();
            this.tBtenDB = new System.Windows.Forms.TextBox();
            this.tBmaDB = new System.Windows.Forms.TextBox();
            this.lbSanNha = new System.Windows.Forms.Label();
            this.lbTenDB = new System.Windows.Forms.Label();
            this.lbMaDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdoiBong)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVdoiBong
            // 
            this.dGVdoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdoiBong.Location = new System.Drawing.Point(14, 140);
            this.dGVdoiBong.Margin = new System.Windows.Forms.Padding(2);
            this.dGVdoiBong.Name = "dGVdoiBong";
            this.dGVdoiBong.RowTemplate.Height = 28;
            this.dGVdoiBong.Size = new System.Drawing.Size(478, 226);
            this.dGVdoiBong.TabIndex = 36;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(236, 105);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(54, 31);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(438, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(54, 31);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(363, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 31);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(286, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(54, 31);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tBsanNha
            // 
            this.tBsanNha.Location = new System.Drawing.Point(85, 71);
            this.tBsanNha.Margin = new System.Windows.Forms.Padding(2);
            this.tBsanNha.Name = "tBsanNha";
            this.tBsanNha.Size = new System.Drawing.Size(181, 20);
            this.tBsanNha.TabIndex = 30;
            // 
            // tBtenDB
            // 
            this.tBtenDB.Location = new System.Drawing.Point(85, 40);
            this.tBtenDB.Margin = new System.Windows.Forms.Padding(2);
            this.tBtenDB.Name = "tBtenDB";
            this.tBtenDB.Size = new System.Drawing.Size(181, 20);
            this.tBtenDB.TabIndex = 31;
            // 
            // tBmaDB
            // 
            this.tBmaDB.Location = new System.Drawing.Point(85, 7);
            this.tBmaDB.Margin = new System.Windows.Forms.Padding(2);
            this.tBmaDB.Name = "tBmaDB";
            this.tBmaDB.Size = new System.Drawing.Size(181, 20);
            this.tBmaDB.TabIndex = 27;
            // 
            // lbSanNha
            // 
            this.lbSanNha.AutoSize = true;
            this.lbSanNha.Location = new System.Drawing.Point(11, 73);
            this.lbSanNha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSanNha.Name = "lbSanNha";
            this.lbSanNha.Size = new System.Drawing.Size(53, 13);
            this.lbSanNha.TabIndex = 28;
            this.lbSanNha.Text = "Sân nhà: ";
            // 
            // lbTenDB
            // 
            this.lbTenDB.AutoSize = true;
            this.lbTenDB.Location = new System.Drawing.Point(11, 42);
            this.lbTenDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenDB.Name = "lbTenDB";
            this.lbTenDB.Size = new System.Drawing.Size(74, 13);
            this.lbTenDB.TabIndex = 29;
            this.lbTenDB.Text = "Tên đội bóng:";
            // 
            // lbMaDB
            // 
            this.lbMaDB.AutoSize = true;
            this.lbMaDB.Location = new System.Drawing.Point(11, 9);
            this.lbMaDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaDB.Name = "lbMaDB";
            this.lbMaDB.Size = new System.Drawing.Size(70, 13);
            this.lbMaDB.TabIndex = 26;
            this.lbMaDB.Text = "Mã đội bóng:";
            // 
            // QLDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 383);
            this.Controls.Add(this.dGVdoiBong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tBsanNha);
            this.Controls.Add(this.tBtenDB);
            this.Controls.Add(this.tBmaDB);
            this.Controls.Add(this.lbSanNha);
            this.Controls.Add(this.lbTenDB);
            this.Controls.Add(this.lbMaDB);
            this.Name = "QLDoiBong";
            this.Text = "QLDoiBong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLDoiBong_FormClosing);
            this.Load += new System.EventHandler(this.QLDoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdoiBong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVdoiBong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tBsanNha;
        private System.Windows.Forms.TextBox tBtenDB;
        private System.Windows.Forms.TextBox tBmaDB;
        private System.Windows.Forms.Label lbSanNha;
        private System.Windows.Forms.Label lbTenDB;
        private System.Windows.Forms.Label lbMaDB;
    }
}