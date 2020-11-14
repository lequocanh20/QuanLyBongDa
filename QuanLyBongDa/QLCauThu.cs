using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBongDa
{
    public partial class QLCauThu : Form
    {
        public QLCauThu()
        {
            InitializeComponent();
        }

        private void QLCauThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
        
        public void xemdulieu()
        {
            QuanLyBongDaDataContext qlbd = new QuanLyBongDaDataContext();
            dGVcauThu.DataSource = from u in qlbd.CAUTHUs select new { MaCT = u.MaCT, TenCT = u.TenCT, NgaySinh = u.NgaySinh, TenLoaiCT = u.LOAICAUTHU.TenLoaiCT, TenDB = u.DOIBONG.TenDB, GhiChu = u.GhiChu};
            tBmaCT.DataBindings.Clear();
            tBmaCT.DataBindings.Add(new Binding("Text", dGVcauThu.DataSource, "MaCT"));
            tBtenCT.DataBindings.Clear();
            tBtenCT.DataBindings.Add(new Binding("Text", dGVcauThu.DataSource, "TenCT"));
            tBngaySinh.DataBindings.Clear();
            tBngaySinh.DataBindings.Add(new Binding("Text", dGVcauThu.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy"));
            cBloaiCT.DataSource = qlbd.LOAICAUTHUs.ToList();
            cBloaiCT.DisplayMember = "TenLoaiCT";
            cBloaiCT.DataBindings.Clear();
            cBloaiCT.DataBindings.Add(new Binding("Text", dGVcauThu.DataSource, "TenLoaiCT"));
            cBdoiBong.DataSource = qlbd.DOIBONGs.ToList();
            cBdoiBong.DisplayMember = "TenDB";
            cBdoiBong.DataBindings.Clear();
            cBdoiBong.DataBindings.Add(new Binding("Text", dGVcauThu.DataSource, "TenDB"));
        }

        private void QLCauThu_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCauThu tct = new ThemCauThu();
            this.Hide();
            tct.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyBongDaDataContext qlbddel = new QuanLyBongDaDataContext();
            string macauthu = tBmaCT.Text;
            CAUTHU CT = qlbddel.CAUTHUs.Where(ct => Convert.ToString(ct.MaCT) == macauthu).SingleOrDefault();
            if (CT != null)
            {
                qlbddel.CAUTHUs.DeleteOnSubmit(CT);
                qlbddel.SubmitChanges();
                MessageBox.Show("Đã xóa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyBongDaDataContext qlbdedit = new QuanLyBongDaDataContext();
            string macauthu = tBmaCT.Text;
            CAUTHU CT = qlbdedit.CAUTHUs.Where(ct => Convert.ToString(ct.MaCT) == macauthu).SingleOrDefault();
            if (CT != null)
            {
                CT.MaCT = Convert.ToString(tBmaCT.Text);
                CT.TenCT = Convert.ToString(tBtenCT.Text);
                CT.NgaySinh = Convert.ToDateTime(tBngaySinh.Text);
                CT.MaLoaiCT = ((LOAICAUTHU)cBloaiCT.SelectedValue).MaLoaiCT;
                CT.MaDB = ((DOIBONG)cBdoiBong.SelectedValue).MaDB;
                CT.GhiChu = Convert.ToString(tBghiChu.Text);
                qlbdedit.SubmitChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }
    }
}
