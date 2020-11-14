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
    public partial class QLLichThiDau : Form
    {
        public QLLichThiDau()
        {
            InitializeComponent();
        }
        public void xemdulieu()
        {
            QuanLyBongDaDataContext qlbd = new QuanLyBongDaDataContext();
            dGVlichThiDau.DataSource = from u in qlbd.LICHTHIDAUs select new { MaTD = u.MaTD, MaDB1 = u.DOIBONG1.TenDB, MaDB2 = u.DOIBONG.TenDB, NgayGio = u.NgayThiDau, TenSan = u.DOIBONG.SanNha, TenVD = u.VONGDAU.TenVD };

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
