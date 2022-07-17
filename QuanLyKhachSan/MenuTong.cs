using QUANLYKHACHSAN_TRAPHONG;
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
    public partial class MenuTong : Form
    {
        public MenuTong()
        {
            InitializeComponent();
        }

        private void MenuTong_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            openform(new DangkyThongTin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openform(new DATPHONG());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openform(new QuanLyPhong());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openform(new DichVu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DangNhap frmDN = new DangNhap();
            this.Hide();
            frmDN.Show();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
