using QUANLYKHACHSAN_TRAPHONG;
using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MenuTong2 : Form
    {
        public MenuTong2()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openform(Form Formcon)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Formcon;
            Formcon.TopLevel = false;
            Formcon.FormBorderStyle = FormBorderStyle.None;
            Formcon.Dock = DockStyle.Fill;
            panel1.Controls.Add(Formcon);
            panel1.Tag = Formcon;
            Formcon.BringToFront();
            Formcon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openform(new DATPHONG());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openform(new DangkyThongTin());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openform(new QuanLyPhong());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openform(new DichVu());
        }

      
        private void button7_Click(object sender, EventArgs e)
        {
            openform(new QuanLyNhanVien());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DangNhap frmDN = new DangNhap();
            this.Hide();
            frmDN.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openform(new TraPhong());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openform(new ThongTinHoaDon());

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openform(new TinhTIen());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
