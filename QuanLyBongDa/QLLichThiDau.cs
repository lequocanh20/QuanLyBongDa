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
    public partial class QLLichThiDau : Form
    {
        public QLLichThiDau()
        {
            InitializeComponent();
        }


        //                              load dữ liệu, thiết kế cột, binding 

        public void xemdulieu()
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            var dslichthidau = from u in qlbd.LICHTHIDAUs select new { MaTD = u.MaTD, DoiChuNha = u.DOIBONG1.TenDB, DoiKhach = u.DOIBONG.TenDB, NgayThiDau = u.NgayThiDau, SanThiDau = u.SanThiDau, VongDau = u.VONGDAU.TenVD };
            dGVlichThiDau.DataSource = dslichthidau.ToList();
            tBmaTD.DataBindings.Clear();
            tBmaTD.DataBindings.Add("Text", dGVlichThiDau.DataSource, "MaTD");
            cBdoi1.DataSource = qlbd.DOIBONGs.ToList();
            cBdoi1.DisplayMember = "TenDB";
            cBdoi1.DataBindings.Clear();
            cBdoi1.DataBindings.Add("Text", dGVlichThiDau.DataSource, "DoiChuNha");
            cBdoi2.DataSource = qlbd.DOIBONGs.ToList();
            cBdoi2.DisplayMember = "TenDB";
            cBdoi2.DataBindings.Clear();
            cBdoi2.DataBindings.Add("Text", dGVlichThiDau.DataSource, "DoiKhach");
            tBngayGio.DataBindings.Clear();
            tBngayGio.DataBindings.Add("Text", dGVlichThiDau.DataSource, "NgayThiDau");
            tBsanThiDau.DataBindings.Clear();
            tBsanThiDau.DataBindings.Add("Text", dGVlichThiDau.DataSource, "SanThiDau");
            cBvongDau.DataBindings.Clear();
            cBvongDau.DataBindings.Add("Text", dGVlichThiDau.DataSource, "VongDau");
        }

        public void changegridview()
        {
            dGVlichThiDau.Columns[0].HeaderText = "Mã trận đấu";
            dGVlichThiDau.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVlichThiDau.Columns[1].HeaderText = "Đội chủ nhà";
            dGVlichThiDau.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[2].HeaderText = "Đội khách";
            dGVlichThiDau.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[3].HeaderText = "Ngày thi đấu";
            dGVlichThiDau.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVlichThiDau.Columns[4].HeaderText = "Sân thi đấu";
            dGVlichThiDau.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVlichThiDau.Columns[5].HeaderText = "Vòng đấu";
            dGVlichThiDau.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void QLLichThiDau_Load(object sender, EventArgs e)
        {
            xemdulieu();
            changegridview();
        }


        //                                          end


        //                                  thiết lập chức năng thêm, xóa, sửa


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLichThiDau tltd = new ThemLichThiDau();
            this.Hide();
            tltd.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void QLLichThiDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        //                                          end
    }
}
