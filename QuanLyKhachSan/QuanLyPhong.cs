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
    public partial class QuanLyPhong : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;
        public QuanLyPhong()
        {
            InitializeComponent();
            LoadData();
            ClearData();
        }
        public void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from PHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void ClearData()
        {
            txt_GiaPhong.Text = "";
            txt_LoaiP.Text = "";
            txt_SoPhong.Text = "";
            txt_TienCoc.Text = "";
            txt_TrangThai.Text = "";
        }
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Số Phòng";
        }
        
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PHONG([SoPhong],[LoaiPhong],[TienCoc],[GiaPhong],[TrangThai])" +
                    "VALUES(@SoPhong,@LoaiPhong,@TienCoc,@GiaPhong,@TrangThai)");
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoPhong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", txt_LoaiP.Text);
                cmd.Parameters.AddWithValue("@TienCoc", txt_TienCoc.Text);
                cmd.Parameters.AddWithValue("@GiaPhong", txt_GiaPhong.Text);
                cmd.Parameters.AddWithValue("@TrangThai", txt_TrangThai.Text);
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
                cmd.CommandText = System.String.Concat("Delete from PHONG where SoPhong = '" + strT + "'");
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update PHONG set [LoaiPhong]=@LoaiPhong , [TienCoc]=@TienCoc , [TrangThai]=@TrangThai , [GiaPhong]=@GiaPhong where [SoPhong]=@SoPhong ");
                cmd.Parameters.AddWithValue("@SoPhong", txt_SoPhong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", txt_LoaiP.Text);
                decimal Tiencoc = Decimal.Parse(txt_TienCoc.Text, System.Globalization.NumberStyles.Number);
                decimal GiaPhong = Decimal.Parse(txt_GiaPhong.Text, System.Globalization.NumberStyles.Number);
                cmd.Parameters.AddWithValue("@TienCoc", txt_TienCoc.Text);
                cmd.Parameters.AddWithValue("@GiaPhong", txt_GiaPhong.Text);
                cmd.Parameters.AddWithValue("@TrangThai", txt_TrangThai.Text);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_SoPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_LoaiP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_TienCoc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_GiaPhong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_TrangThai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_GiaPhong.Clear();
            txt_LoaiP.Clear();
            txt_SoPhong.Clear();
            txt_TienCoc.Clear();
            txt_TrangThai.Clear();
        }
        public void timkiem()
        {
            if(comboBox1.Text == "Số Phòng")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from PHONG where SoPhong like '%"+txt_timkiem.Text+"%'", conn);
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
                dataGridView1.DataSource = dtTableName;
            }
            if (comboBox1.Text == "Trạng Thái")
            {
                conn = new SqlConnection(strConnectionString);
                daTableName = new SqlDataAdapter("select *from PHONG where TrangThai like '%" + txt_timkiem.Text + "%'", conn);
                dtTableName = new DataTable();
                daTableName.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from PHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
    }
}
