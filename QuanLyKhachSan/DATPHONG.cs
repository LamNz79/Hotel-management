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
    public partial class DATPHONG : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;

        private void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from DATPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void LoadData2()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from PHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
        }
        private void LoadData3()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
        }

        private void ClearData()
        {
            txt_CMND.Text = "";
            txt_LoaiPhong.Text = "";
            txt_MaDP.Text = "";
            txt_SoP.Text = "";
           
        }
        public DATPHONG()
        {
            InitializeComponent();
            LoadData();
            ClearData();
            LoadData2();
            LoadData3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DATPHONG_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO DATPHONG([MaDatP],[Thoigiannhanphong],[LoaiPhong],[CMNDhoacVisa],[SoPhong])" +
                    "VALUES(@MaDatP,@Thoigiannhanphong,@LoaiPhong,@CMNDhoacVisa,@SoPhong)");
                cmd.Parameters.AddWithValue("@MaDatP", txt_MaDP.Text);
                cmd.Parameters.AddWithValue("@Thoigiannhanphong",DTP1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", txt_LoaiPhong.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoP.Text);
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
                cmd.CommandText = System.String.Concat("Delete from DATPHONG where MaDatP = '" + strT + "'");
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

        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trờVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_MaDP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            DTP1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_LoaiPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_CMND.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_SoP.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update DATPHONG set [Thoigiannhanphong]=@Thoigiannhanphong , [LoaiPhong]=@LoaiPhong , [CMNDhoacVisa]=@CMNDhoacVisa , [SoPhong]=@SoPhong where [MaDatP]=@MaDatP");
                cmd.Parameters.AddWithValue("@MaDatP", txt_MaDP.Text);
                cmd.Parameters.AddWithValue("@Thoigiannhanphong", DTP1.Value);
                cmd.Parameters.AddWithValue("@LoaiPhong", txt_LoaiPhong.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", txt_CMND.Text);
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoP.Text);
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

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_CMND.Clear();
            txt_LoaiPhong.Clear();
            txt_MaDP.Clear();
            txt_SoP.Clear();
            
            
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
                dataGridView2.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Số Phòng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from DATPHONG where SoPhong like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Loại Phòng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from PHONG where LoaiPhong like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView2.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Trạng Thái")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from PHONG where TrangThai like '%" + txt_timkiem.Text + "%'", conn);
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
            daTableName = new SqlDataAdapter("select *from DATPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from KHACHHANG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from PHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
