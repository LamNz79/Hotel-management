using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void dangnhap()
        {
            if (txt_Username.Text.Length == 0 && txt_Password.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập thông tin");
            else
              if (this.txt_Username.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập Username");
            else
                if (this.txt_Password.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập Password");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txt_Username.Text;
                string mk = txt_Password.Text;
                string sql = "select *from Account where Username= '" + tk + "' and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                MenuTong frmMenuNhamVien = new MenuTong();
                if (this.txt_Username.Text == "user1" && this.txt_Password.Text == "123")
                {
                    frmMenuNhamVien.Show();
                    this.Hide();
                }
                MenuTong2 frmMenuQuanLy = new MenuTong2();
                if (this.txt_Username.Text == "admin" && this.txt_Password.Text == "12345")
                {
                    frmMenuQuanLy.Show();
                    this.Hide();
                }
                dangnhap();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
