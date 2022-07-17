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
    public partial class TraPhong : Form
    {
        string connectString;
        SqlConnection cnn;
        SqlCommand cmd,cmd2;
        SqlDataAdapter dataRender1, dataRender2;
        DataTable dtTableName1, dtTableName2;

        

        string sql = "";

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                sql = "INSERT INTO TRAPHONG([MaTra], [SoPhong], [CMNDhoacVisa], [Thoigiantraphong])" + "VALUES (@MaTra, @SoPhong, @CMNDhoacVisa, @Thoigiantraphong)";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaTra", TB_MATRAPHONG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", TB_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@CMNDhoacVisa", TB_CMND.Text);
                cmd.Parameters.AddWithValue("@Thoigiantraphong", DTP_THOIGIANTRAPHONG.Value);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }
            cnn.Close();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            TB_CMND.Text = "";
            TB_SOPHONG.Text = "";
            TB_MATRAPHONG.Text = "";
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            cnn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                int r = DATAGRID_TRAPHONG.CurrentCell.RowIndex;
                string strT = DATAGRID_TRAPHONG.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Delete from TraPhong where MaTra = '" + strT + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
            cnn.Close();
        }

        private void LoadData()
        {
            connectString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
            cnn = new SqlConnection(connectString);

            dataRender1 = new SqlDataAdapter("SELECT TRAPHONG.MaTra, TRAPHONG.CMNDhoacVisa, TRAPHONG.SoPhong, TRAPHONG.Thoigiantraphong FROM TRAPHONG", cnn);
            dataRender2 = new SqlDataAdapter("SELECT * FROM DATPHONG", cnn);
            
            dtTableName1 = new DataTable();
            dtTableName2 = new DataTable();
        
            dataRender1.Fill(dtTableName1);
            dataRender2.Fill(dtTableName2);
            DATAGRID_TRAPHONG.DataSource = dtTableName1;
            DATAGRID_THONGTINKHACHHANG.DataSource = dtTableName2;
        }
        private void DATAGRID_THONGTINKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DATAGRID_THONGTINKHACHHANG.CurrentCell.RowIndex;
            string strMaDatP = DATAGRID_THONGTINKHACHHANG.Rows[r].Cells[0].Value.ToString();
            string strCMND = DATAGRID_THONGTINKHACHHANG.Rows[r].Cells[3].Value.ToString();
            string strSoPhong = DATAGRID_THONGTINKHACHHANG.Rows[r].Cells[4].Value.ToString();

            TB_CMND.Text = strCMND;
            TB_SOPHONG.Text = strSoPhong;


            /*DTP_THOIGIANTRAPHONG.Format = DateTimePickerFormat.Custom;
            DTP_THOIGIANTRAPHONG.CustomFormat = "YYYYMMDD";*/


        }

        public TraPhong()
        {
            InitializeComponent();
            LoadData();
        }
    }
}
