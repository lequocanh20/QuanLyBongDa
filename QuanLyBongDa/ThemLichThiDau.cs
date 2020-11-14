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
    public partial class ThemLichThiDau : Form
    {
        public ThemLichThiDau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuanLyBongDaDataContext add = new QuanLyBongDaDataContext();
            string mathidau = "";
            LICHTHIDAU LTD = add.LICHTHIDAUs.Where(ltd => Convert.ToString(ltd.MaTD) == mathidau).SingleOrDefault();
            if (LTD == null)
            {
                LICHTHIDAU item = new LICHTHIDAU();
                //item.MaTD = Convert.ToString(tBmaTD.Text);
                //item.DoiChuNha = Select TOP 10 * from
                //item.SanNha = Convert.ToString(tBsanNha.Text);
                //qlbdadd.DOIBONGs.InsertOnSubmit(item);
                //qlbdadd.SubmitChanges();
                //MessageBox.Show("Đã nhập vào thành công", "Thông báo");
                //ql.xemdulieu();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số hóa đơn", "Lỗi");
            }
        }
    }
}
