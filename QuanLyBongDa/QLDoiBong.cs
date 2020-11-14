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
    public partial class QLDoiBong : Form
    {
        public QLDoiBong()
        {
            InitializeComponent();
        }
    
        private void QLDoiBong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
        
        public void xemdulieu()
        {
            QuanLyBongDaDataContext qlbd = new QuanLyBongDaDataContext();
            dGVdoiBong.DataSource = from u in qlbd.DOIBONGs select new { MaDB = u.MaDB, TenDB = u.TenDB, SanNha = u.SanNha };
            tBmaDB.DataBindings.Clear();
            tBmaDB.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "MaDB"));
            tBtenDB.DataBindings.Clear();
            tBtenDB.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "TenDB"));
            tBsanNha.DataBindings.Clear();
            tBsanNha.DataBindings.Add(new Binding("Text", dGVdoiBong.DataSource, "SanNha"));
        }

        private void QLDoiBong_Load(object sender, EventArgs e)
        {
            xemdulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDoiBong tdb = new ThemDoiBong();
            this.Hide();
            tdb.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyBongDaDataContext qlbddel = new QuanLyBongDaDataContext();
            string madoibong = tBmaDB.Text;
            DOIBONG DB = qlbddel.DOIBONGs.Where(db  => Convert.ToString(db.MaDB) == madoibong).SingleOrDefault();
            if (DB != null)
            {
                qlbddel.DOIBONGs.DeleteOnSubmit(DB);
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
            string madoibong = tBmaDB.Text;
            DOIBONG DB = qlbdedit.DOIBONGs.Where(db => Convert.ToString(db.MaDB) == madoibong).SingleOrDefault();
            if (DB != null)
            {
                DB.MaDB = Convert.ToString(tBmaDB.Text);
                DB.TenDB = Convert.ToString(tBtenDB.Text);
                DB.SanNha = Convert.ToString(tBsanNha.Text);
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
