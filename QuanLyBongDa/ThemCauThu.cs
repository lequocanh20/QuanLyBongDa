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
    public partial class ThemCauThu : Form
    {
        public ThemCauThu()
        {
            InitializeComponent();
        }
        QLCauThu ql = new QLCauThu();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbdadd = new QLGVDBDQGEntities();
            string macauthu = "";
            CAUTHU CT = qlbdadd.CAUTHUs.Where(ct => Convert.ToString(ct.MaCT) == macauthu).SingleOrDefault();
            if (CT == null)
            {
                CAUTHU item = new CAUTHU();
                item.MaCT = Convert.ToString(tBmaCT.Text);
                item.TenCT = Convert.ToString(tBtenCT.Text);
                item.NgaySinh = dTPngaySinh.Value.Date;
                item.MaLoaiCT = ((LOAICAUTHU)cBloaiCT.SelectedValue).MaLoaiCT;
                item.MaDB = ((DOIBONG)cBdoiBong.SelectedValue).MaDB;
                qlbdadd.CAUTHUs.Add(item);
                qlbdadd.SaveChanges();
                MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                ql.xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số hóa đơn", "Lỗi");
            }
        }

        private void ThemCauThu_Load(object sender, EventArgs e)
        {
            QLGVDBDQGEntities qlbdthemcauthu = new QLGVDBDQGEntities();
            cBloaiCT.DataSource = qlbdthemcauthu.LOAICAUTHUs.ToList();
            cBloaiCT.DisplayMember = "TenLoaiCT";
            cBdoiBong.DataSource = qlbdthemcauthu.DOIBONGs.ToList();
            cBdoiBong.DisplayMember = "TenDB";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ql.Show();
        }
    }
}
