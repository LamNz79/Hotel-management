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

namespace QuanLyKhachSan
{
    public partial class DangkyThongTin : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;
        public DangkyThongTin()
        {
            InitializeComponent();
            LoadData();
            ClearData();
        }
        private void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void ClearData()
        {
            txt_TenKH.Text = "";
            txt_CMND.Text = "";
            txt_tuoi.Text = "";
            txt_sdt.Text = "";
            txt_Email.Text = "";
        }
        private void DangkyThongTin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO KHACHHANG([TenKhachHang],[CMNDhoacVisa],[Age],[Sdt],[Email])" +
                    "VALUES(@TenKhachHang,@CMNDhoacVisa,@Age,@Sdt,@Email)");
                cmd.Parameters.AddWithValue("@TenKhachHang", txt_TenKH.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@Age", txt_tuoi.Text);
                cmd.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
                ClearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dataGridView1.CurrentCell.RowIndex;
                string strT = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from KHACHHANG where TenKhachHang = '" + strT + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_TenKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_CMND.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_tuoi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_CMND.Clear();
            txt_Email.Clear();
            txt_sdt.Clear();
            txt_TenKH.Clear();
            txt_tuoi.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update KHACHHANG set [TenKhachHang]=@TenKhachHang , [Age]=@Age , [Sdt]=@Sdt , [Email]=@Email where [CMNDhoacVisa]=@CMNDhoacVisa");
                cmd.Parameters.AddWithValue("@TenKhachHang", txt_TenKH.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@Age", txt_tuoi.Text);
                cmd.Parameters.AddWithValue("@Sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                LoadData();
                ClearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi !");
            }
            conn.Close();
        }
        public void timkiem()
        {
            if (comboBox1.Text == "Tên Khách Hàng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from KHACHHANG where TenKhachHang like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số CMND/Visa")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from KHACHHANG where CMNDhoacVisa like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
