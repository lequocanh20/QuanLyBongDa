﻿namespace QuanLyBongDa
{
    partial class ThemDoiBong
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
            this.tBsanNha = new System.Windows.Forms.TextBox();
            this.tBtenDB = new System.Windows.Forms.TextBox();
            this.tBmaDB = new System.Windows.Forms.TextBox();
            this.lbSanNha = new System.Windows.Forms.Label();
            this.lbTenDB = new System.Windows.Forms.Label();
            this.lbMaDB = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBsanNha
            // 
            this.tBsanNha.Location = new System.Drawing.Point(94, 75);
            this.tBsanNha.Margin = new System.Windows.Forms.Padding(2);
            this.tBsanNha.Name = "tBsanNha";
            this.tBsanNha.Size = new System.Drawing.Size(181, 20);
            this.tBsanNha.TabIndex = 3;
            // 
            // tBtenDB
            // 
            this.tBtenDB.Location = new System.Drawing.Point(94, 44);
            this.tBtenDB.Margin = new System.Windows.Forms.Padding(2);
            this.tBtenDB.Name = "tBtenDB";
            this.tBtenDB.Size = new System.Drawing.Size(181, 20);
            this.tBtenDB.TabIndex = 2;
            // 
            // tBmaDB
            // 
            this.tBmaDB.Location = new System.Drawing.Point(94, 11);
            this.tBmaDB.Margin = new System.Windows.Forms.Padding(2);
            this.tBmaDB.Name = "tBmaDB";
            this.tBmaDB.Size = new System.Drawing.Size(181, 20);
            this.tBmaDB.TabIndex = 1;
            // 
            // lbSanNha
            // 
            this.lbSanNha.AutoSize = true;
            this.lbSanNha.Location = new System.Drawing.Point(20, 77);
            this.lbSanNha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSanNha.Name = "lbSanNha";
            this.lbSanNha.Size = new System.Drawing.Size(53, 13);
            this.lbSanNha.TabIndex = 34;
            this.lbSanNha.Text = "Sân nhà: ";
            // 
            // lbTenDB
            // 
            this.lbTenDB.AutoSize = true;
            this.lbTenDB.Location = new System.Drawing.Point(20, 46);
            this.lbTenDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenDB.Name = "lbTenDB";
            this.lbTenDB.Size = new System.Drawing.Size(74, 13);
            this.lbTenDB.TabIndex = 35;
            this.lbTenDB.Text = "Tên đội bóng:";
            // 
            // lbMaDB
            // 
            this.lbMaDB.AutoSize = true;
            this.lbMaDB.Location = new System.Drawing.Point(20, 13);
            this.lbMaDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaDB.Name = "lbMaDB";
            this.lbMaDB.Size = new System.Drawing.Size(70, 13);
            this.lbMaDB.TabIndex = 32;
            this.lbMaDB.Text = "Mã đội bóng:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(161, 115);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(76, 115);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(61, 33);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ThemDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 158);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tBsanNha);
            this.Controls.Add(this.tBtenDB);
            this.Controls.Add(this.tBmaDB);
            this.Controls.Add(this.lbSanNha);
            this.Controls.Add(this.lbTenDB);
            this.Controls.Add(this.lbMaDB);
            this.Name = "ThemDoiBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập đội bóng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemDoiBong_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBsanNha;
        private System.Windows.Forms.TextBox tBtenDB;
        private System.Windows.Forms.TextBox tBmaDB;
        private System.Windows.Forms.Label lbSanNha;
        private System.Windows.Forms.Label lbTenDB;
        private System.Windows.Forms.Label lbMaDB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXacNhan;
    }
}