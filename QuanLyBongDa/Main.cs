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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDoiBong_Click(object sender, EventArgs e)
        {
            QLDoiBong db = new QLDoiBong();
            this.Hide();
            db.Show();
        }

        private void btnCauThu_Click(object sender, EventArgs e)
        {
            QLCauThu ct = new QLCauThu();
            this.Hide();
            ct.Show();
        }

        private void btnLichThiDau_Click(object sender, EventArgs e)
        {
            QLLichThiDau ltd = new QLLichThiDau();
            this.Hide();
            ltd.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
