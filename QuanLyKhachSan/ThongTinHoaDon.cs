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

namespace QUANLYKHACHSAN_TRAPHONG
{

    public partial class ThongTinHoaDon : Form
    {
        string connectString;
        SqlConnection cnn;
        SqlCommand  cmd, cmd2;
        SqlDataAdapter dataRender1, dataRender2, dataRender3;
        DataTable dtTableTHONGTINKHACHANG, dttableHOADON, dtThongTinHoaDon;
        string sql = "";
        string sql2 = "";
        string sql3 = "";

        private void LoadData()
        {
            connectString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
            cnn = new SqlConnection(connectString);
            sql = "	SELECT KHACHHANG.TenKhachHang, KHACHHANG.CMNDhoacVisa, SUM(CAST(DICHVU.DSoLuong AS INT)) AS [SO DICH VU], PHONG.SoPhong FROM DICHVU JOIN KHACHHANG ON DICHVU.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN PHONG ON PHONG.SoPhong = DICHVU.SoPhong GROUP BY KHACHHANG.TenKhachHang, KHACHHANG.CMNDhoacVisa, PHONG.SoPhong";            
            sql2 = "SELECT KHACHHANG.TenKhachHang, KHACHHANG.CMNDhoacVisa, DICHVU.TenDichVu FROM KHACHHANG JOIN DICHVU ON KHACHHANG.CMNDhoacVisa = DICHVU.CMNDhoacVisa";
            sql3 = "SELECT HOADON.MaHD, HOADON.MaDV, DICHVU.TenDichVu, DICHVU.CMNDhoacVisa FROM HOADON JOIN DICHVU ON HOADON.MaHD = DICHVU.MaDV";

            dataRender1 = new SqlDataAdapter(sql2, cnn);
            dataRender2 = new SqlDataAdapter(sql, cnn);
            dataRender3 = new SqlDataAdapter(sql3, cnn);

            dtThongTinHoaDon = new DataTable();
            dataRender3.Fill(dtThongTinHoaDon);

            dtTableTHONGTINKHACHANG = new DataTable();
            dataRender1.Fill(dtTableTHONGTINKHACHANG);

            dttableHOADON = new DataTable();
            dataRender2.Fill(dttableHOADON);

            dataGridView_HOADON.DataSource = dttableHOADON;
            dataGridView_THONGTINKHACHHANG.DataSource = dtTableTHONGTINKHACHANG;
            datagrid_HOADON.DataSource = dtThongTinHoaDon;



        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
                /*cnn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    int r = dtThongTinHoaDon.CurrentCell.RowIndex;
                    string strT = dtThongTinHoaDon.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = System.String.Concat("Delete from TraPhong where MaTra = '" + strT + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được, Lỗi rồi !");
                }
                cnn.Close();*/
            
        }

        private void dataGridView_THONGTINKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cnn.Open();
            int r = dataGridView_THONGTINKHACHHANG.CurrentCell.RowIndex;
            string strCMND = dataGridView_THONGTINKHACHHANG.Rows[r].Cells[1].Value.ToString();
            sql = "	SELECT DATPHONG.SoPhong FROM DATPHONG WHERE DATPHONG.CMNDhoacVisa='" + strCMND + "'";
            cmd = new SqlCommand(sql, cnn);

            SqlDataReader SoPhong = cmd.ExecuteReader();
            SoPhong.Read();
            string d = SoPhong.GetString(0);
            SoPhong.Close();
            /*            string strMaDV = dataGridView_THONGTINKHACHHANG.Rows[r].Cells[2].Value.ToString();
            *//*            string strSoPhongTra = dataGridView_THONGTINKHACHHANG.Rows[r].Cells[5].Value.ToString();
                        string strSoPhong = dataGridView_THONGTINKHACHHANG.Rows[r].Cells[4].Value.ToString();
            */
            TB_SoPhong.Text = d;
            TB_CMND.Text = strCMND;
            /*TB_MaDV.Text = strMaDV;*/
            /*            TB_SOPHONGTRA.Text = strSoPhongTra;
            /*            TB_SoPhong.Text = strSoPhong;

            */
            cnn.Close();
        
        }

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                
                sql2 = "INSERT INTO HOADON([MaHD], [MaDV])" + "VALUES (@MaHD, @MaDV)";
                cmd2 = new SqlCommand(sql2, cnn);
                cmd2.Parameters.AddWithValue("@MaHD", TB_MAHD.Text);
                cmd2.Parameters.AddWithValue("@MaDV", TB_MaDV.Text);
                cmd2.ExecuteNonQuery();
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
            TB_MAHD.Text = "";
            TB_MaDV.Text = "";
        }

       


        public ThongTinHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void ThongTinHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
