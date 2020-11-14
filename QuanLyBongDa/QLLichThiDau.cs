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
        public void xemdulieu()
        {
            QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
            var dslichthidau = from u in qlbd.LICHTHIDAUs select new { MaTD = u.MaTD, DoiChuNha = u.DOIBONG1.TenDB, DoiKhach = u.DOIBONG.TenDB, NgayThiDau = u.NgayThiDau, SanThiDau = u.SanThiDau, VongDau = u.VONGDAU.TenVD };
            dGVlichThiDau.DataSource = dslichthidau.ToList();
        }

        private void QLLichThiDau_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

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
    }
}
