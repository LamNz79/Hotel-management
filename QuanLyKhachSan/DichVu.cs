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
    public partial class DichVu : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;

        public DichVu()
        {
            InitializeComponent();
            LoadData();
            ClearData();
            LoadData2();
            LoadData3();
        }
        public void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from DICHVU", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
        }
        public void LoadData2()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from DATPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void LoadData3()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
        }
        public void ClearData()
        {
            txt_MaDV.Text = "";
            txt_CMND.Text = "";
            txt_GiaDV.Text = "";
            txt_SoLuong.Text = "";
            txt_SoPhong.Text = "";
            txt_TenDV.Text = "";
        }

        private void DichVu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO DICHVU([MaDV],[TenDichVu],[GiaDV],[DSoLuong],[CMNDhoacVisa],[SoPhong])" +
                    "VALUES(@MaDV,@TenDichVu,@GiaDV,@DSoLuong,@CMNDhoacVisa,@SoPhong)");
                cmd.Parameters.AddWithValue("@MaDV", txt_MaDV.Text);
                cmd.Parameters.AddWithValue("@TenDichVu", txt_TenDV.Text);
                cmd.Parameters.AddWithValue("@GiaDV", txt_GiaDV.Text);
                cmd.Parameters.AddWithValue("@DSoLuong", txt_SoLuong.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoPhong.Text);
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
                int r = dataGridView2.CurrentCell.RowIndex;
                string strT = dataGridView2.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from DICHVU where MaDV = '" + strT + "'");
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

        private void trởLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_TenDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txt_MaDV.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt_TenDV.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt_GiaDV.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt_SoLuong.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txt_CMND.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt_SoPhong.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_MaDV.Clear();
            txt_CMND.Clear();
            txt_GiaDV.Clear();
            txt_SoLuong.Clear();
            txt_SoPhong.Clear();
            txt_TenDV.Clear();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update DICHVU set [GiaDV]=@GiaDV , [DSoLuong]=@DSoLuong , [CMNDhoacVisa]=@CMNDhoacVisa , [SoPhong]=@SoPhong , [TenDichVu]=@TenDichVu where [MaDV]=@MaDV ");
                cmd.Parameters.AddWithValue("@MaDV", txt_MaDV.Text);
                cmd.Parameters.AddWithValue("@TenDichVu", txt_TenDV.Text);
                decimal GiaDV = Decimal.Parse(txt_GiaDV.Text, System.Globalization.NumberStyles.Number);
                cmd.Parameters.AddWithValue("@GiaDV", txt_GiaDV.Text);
                cmd.Parameters.AddWithValue("@DSoLuong", txt_SoLuong.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoPhong.Text);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void timkiem()
        {
            if (comboBox1.Text == "Tên Khách Hàng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from KHACHHANG where TenKhachHang like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView3.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số CMND/Visa")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from KHACHHANG where CMNDhoacVisa like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView3.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số CMND/Visa")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from DATPHONG where CMNDhoacVisa like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số Phòng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from PHONG where SoPhong like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số Phòng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from DICHVU where SoPhong like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView2.DataSource = dtTableName;
            }

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from DICHVU", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from DATPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

