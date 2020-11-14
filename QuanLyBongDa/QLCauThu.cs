using System;
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
    public partial class QLCauThu : Form
    {
        public QLCauThu()
        {
            InitializeComponent();
        }


        //                              load dữ liệu, thiết kế cột, binding 

        private void QLCauThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
        
        public void xemdulieu()
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            var dscauthu = from u in qlbd.CAUTHUs select new { MaCT = u.MaCT, TenCT = u.TenCT, NgaySinh = u.NgaySinh, TenLoaiCT = u.LOAICAUTHU.TenLoaiCT, TenDB = u.DOIBONG.TenDB, GhiChu = u.GhiChu};
            dGVcauThu.DataSource = dscauthu.ToList();
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

        public void changegridview()
        {
            dGVcauThu.Columns[0].HeaderText = "Mã cầu thủ";
            dGVcauThu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcauThu.Columns[1].HeaderText = "Tên";
            dGVcauThu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcauThu.Columns[2].HeaderText = "Ngày sinh";
            dGVcauThu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcauThu.Columns[3].HeaderText = "Loại cầu thủ";
            dGVcauThu.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcauThu.Columns[4].HeaderText = "Đội bóng";
            dGVcauThu.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVcauThu.Columns[5].HeaderText = "Ghi chú";
            dGVcauThu.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        //                                          end



        //                                  thiết lập chức năng thêm, xóa, sửa



        private void QLCauThu_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCauThu tct = new ThemCauThu();
            this.Hide();
            tct.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbddel = new QLGVDBDQGEntities();
            string macauthu = tBmaCT.Text;
            CAUTHU CT = qlbddel.CAUTHUs.Where(ct => Convert.ToString(ct.MaCT) == macauthu).SingleOrDefault();
            if (CT != null)
            {
                qlbddel.CAUTHUs.Remove(CT);
                qlbddel.SaveChanges();
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
            QLGVDBDQGEntities qlbdedit = new QLGVDBDQGEntities();
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
                qlbdedit.SaveChanges();
                MessageBox.Show("Đã sửa", "Thông báo");
                xemdulieu();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra...", "Lỗi");
            }
        }

        //                                          end
    }
}
