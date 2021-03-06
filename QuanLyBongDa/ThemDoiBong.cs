﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBongDa.DAL;

namespace QuanLyBongDa
{
    public partial class ThemDoiBong : Form
    {
        public ThemDoiBong()
        {
            InitializeComponent();
        }
        QLDoiBong ql = new QLDoiBong();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbdadd = new QLGVDBDQGEntities();
            string madoibong = "";
            DOIBONG DB = qlbdadd.DOIBONGs.Where(db => db.MaDB == madoibong).SingleOrDefault();
            if (DB == null)
            {
                DOIBONG item = new DOIBONG();
                item.MaDB = Convert.ToString(tBmaDB.Text);
                item.TenDB = Convert.ToString(tBtenDB.Text);
                item.SanNha = Convert.ToString(tBsanNha.Text);
                qlbdadd.DOIBONGs.Add(item);
                qlbdadd.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                tBmaDB.Text = "";
                tBtenDB.Text = "";
                tBsanNha.Text = "";
                ql.xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại....", "Lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ql.Show();
        }

        private void ThemDoiBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ql.Show();
        }
    }
}
