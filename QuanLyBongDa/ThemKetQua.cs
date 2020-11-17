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
    public partial class ThemKetQua : Form
    {
        public ThemKetQua()
        {
            InitializeComponent();
        }

        private QLGVDBDQGEntities qlbd = new QLGVDBDQGEntities();
        private KetQuaThiDau kqtd = new KetQuaThiDau();

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            string maketqua = "";
            KETQUATHIDAU KQ = qlbd.KETQUATHIDAUs.Where(kq => kq.MaKQ == maketqua).SingleOrDefault();
            if (KQ == null)
            {
                KETQUATHIDAU item = new KETQUATHIDAU();
                item.MaKQ = Convert.ToString(tBmaKetQua.Text);
                item.BTDoi1 = Convert.ToString(tBtiSoDoi1.Text);
                item.BTDoi2 = Convert.ToString(tBtiSoDoi2.Text);
                item.MaTD = ((LICHTHIDAU)cBmaTD.SelectedValue).MaTD;
                qlbd.KETQUATHIDAUs.Add(item);
                qlbd.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                tBmaKetQua.Text = "";
                tBtiSoDoi1.Text = "";
                tBtiSoDoi2.Text = "";
                kqtd.xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số hóa đơn", "Lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            kqtd.Show();
        }


        private void ThemKetQua_Load(object sender, EventArgs e)
        {
            cBmaTD.DataSource = qlbd.LICHTHIDAUs.ToList();
            cBmaTD.DisplayMember = "MaTD";
        }

        private void cBmaTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in qlbd.LICHTHIDAUs)
            {
                if (((LICHTHIDAU)cBmaTD.SelectedValue).MaTD == item.MaTD)
                {
                    tBdoi1.Text = item.DOIBONG1.TenDB;
                    tBdoi2.Text = item.DOIBONG.TenDB;
                }
            }
        }

        private void ThemKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            kqtd.Show();
        }
    }
}
