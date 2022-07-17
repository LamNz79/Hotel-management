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
    public partial class QuanLyNhanVien : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
            ClearData();
        }
        public void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from NHANVIEN", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void ClearData()
        {
            txt_DiaChi.Text = "";
            txt_EmailN.Text = "";
            txt_MaNV.Text = "";
            txt_Nsdt.Text = "";
            txt_TenNV.Text = "";
        }


        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN([MaNhanVien],[TenNhanVien],[Email],[Nsdt],[DiaChi])" +
                    "VALUES(@MaNhanVien,@TenNhanVien,@Email,@Nsdt,@DiaChi)");
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_MaNV.Text);
                cmd.Parameters.AddWithValue("@TenNhanVien", txt_TenNV.Text);
                cmd.Parameters.AddWithValue("@Email", txt_EmailN.Text);
                cmd.Parameters.AddWithValue("@Nsdt", txt_Nsdt.Text);
                cmd.Parameters.AddWithValue("@DiaChi",txt_DiaChi.Text);
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
                cmd.CommandText = System.String.Concat("Delete from NHANVIEN where MaNhanVien = '" + strT + "'");
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trờLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_MaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TenNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_EmailN.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_Nsdt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Clear();
            txt_EmailN.Clear();
            txt_MaNV.Clear();
            txt_Nsdt.Clear();
            txt_TenNV.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update NHANVIEN set [TenNhanVien]=@TenNhanVien , [Email]=@Email , [Nsdt]=@Nsdt , [DiaChi]=@DiaChi where [MaNhanVien]=@MaNhanVien ");
                cmd.Parameters.AddWithValue("@MaNhanVien", txt_MaNV.Text);
                cmd.Parameters.AddWithValue("@TenNhanVien", txt_TenNV.Text);
                cmd.Parameters.AddWithValue("@Email", txt_EmailN.Text);
                cmd.Parameters.AddWithValue("@Nsdt", txt_Nsdt.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
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
            if (comboBox1.Text == "Mã Nhân Viên")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from NHANVIEN where MaNhanVien like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Tên Nhân Viên")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from NHANVIEN where TenNhanVien like '%" + txt_timkiem.Text + "%'", conn);
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
            daTableName = new SqlDataAdapter("select *from NHANVIEN", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
    }
}
