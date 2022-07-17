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
    public partial class TinhTIen : Form
    {
        Boolean clickTimID = false;
        Boolean clicktimten = false;
        string connectString;
        SqlConnection cnn;
        SqlCommand cmd, cmd2;
        SqlDataAdapter dataRender;
        DataTable dtTableName;
        string sql = "";

        private void LoadData()
        {
            connectString = @"Data Source=DESKTOP-0ST6KDN;Initial Catalog=nam3;Integrated Security=True";
            cnn = new SqlConnection(connectString);

            sql = "	SELECT KHACHHANG.TenKhachHang, KHACHHANG.CMNDhoacVisa, KHACHHANG.Email, DATEDIFF(DAY, DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong) AS [SO NGAY], PHONG.SoPhong FROM KHACHHANG JOIN DICHVU ON DICHVU.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN HOADON ON HOADON.MaDV = DICHVU.MaDV JOIN TRAPHONG ON TRAPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN DATPHONG ON DATPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN PHONG ON PHONG.SoPhong = DATPHONG.SoPhong group by KHACHHANG.TenKhachHang, KHACHHANG.CMNDhoacVisa, KHACHHANG.Email,DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong, PHONG.SoPhong";
            dataRender = new SqlDataAdapter(sql, cnn);
            dtTableName = new DataTable();
            dataRender.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;

            if (clickTimID == true)
            {
                dataRender = new SqlDataAdapter(sql, cnn);

                dtTableName = new DataTable();
                dataRender.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;

                clickTimID = false;
            }
            else if (clicktimten == true)
            {
                dataRender = new SqlDataAdapter(sql, cnn);

                dtTableName = new DataTable();
                dataRender.Fill(dtTableName);
                dataGridView1.DataSource = dtTableName;

                clicktimten = false;
            }
        }

        public TinhTIen()
        {
            InitializeComponent();
            LoadData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            cnn.Open();
            try
            {
                cmd = new SqlCommand();
                cmd2 = new SqlCommand();
                int r = dataGridView1.CurrentCell.RowIndex;
                string strDeleteHoaDon = dataGridView1.Rows[r].Cells[4].Value.ToString();
                string strDelete = dataGridView1.Rows[r].Cells[1].Value.ToString();

                string sql3 = ("	DELETE FROM HOADON WHERE HOADON.MaDV IN (SELECT DICHVU.MaDV FROM DICHVU WHERE DICHVU.CMNDhoacVisa = '"+ strDelete + "')");
                SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                cmd3.ExecuteNonQuery();

                string sql2 = ("DELETE FROM DATPHONG where DATPHONG.CMNDhoacVisa ='" + strDelete +"'");
                cmd2 = new SqlCommand(sql2, cnn);
                cmd2.ExecuteNonQuery();

                string sql = ("DELETE FROM TRAPHONG WHERE TRAPHONG.CMNDhoacVisa ='" + strDelete +"'");
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                string sql4 = ("DELETE FROM DICHVU WHERE DICHVU.CMNDhoacVisa = '" + strDelete + "'");
                SqlCommand cmd4 = new SqlCommand(sql4, cnn);
                cmd4.ExecuteNonQuery();

                string sql5 = ("DELETE FROM KHACHHANG WHERE KHACHHANG.CMNDhoacVisa = '" + strDelete + "'");
                SqlCommand cmd5 = new SqlCommand(sql5, cnn);
                cmd5.ExecuteNonQuery();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                
            }    
            cnn.Close();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            clicktimten = true;
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                tbIDPhong.Clear();
                tbTimTen.Clear();
                lbThongTinLoaiPhong.Text = "---";
                lbThongTinDichVu.Text = "---";
                lbThongTinNgay.Text = "---";
                lbThongTinTongGia.Text = "---";
                LoadData();

                clickTimID = false;
                clicktimten = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);                
            }
            
        }

        private void btnTimTheoIDPhong_Click(object sender, EventArgs e)
        {
            clickTimID = true;
/*            dataRender = new SqlDataAdapter("SELECT KHACHHANG.MaHD, KHACHHANG.TenKhachHang, THUE.SoPhong, THUE.Ngaytraphong, HOADON.TongGia, PHONG.LoaiP, DATEDIFF(DAY,THUE.Ngaynhanphong, THUE.Ngaytraphong) as [so ngay] FROM KHACHHANG LEFT JOIN THUE ON KHACHHANG.CMNDhoacVisa = THUE.CMNDhoacVisa LEFT JOIN HOADON ON KHACHHANG.MaHD = HOADON.MaHD LEFT JOIN PHONG ON THUE.SoPhong = PHONG.SoPhong WHERE THUE.SoPhong ='"+ render + "'", cnn);
            dataRender.Fill(dtTableName);
*/          LoadData();

        }

        private void lbdatagridinfo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cnn.Open();
            try
            {
                SqlCommand tinhtong1cmd, tinhtong2cmd, tinhtong3cmd, tinhtong4cmd;
                sql = "	SELECT DATEDIFF(DAY, DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong) AS [SO NGAY] FROM DATPHONG JOIN KHACHHANG ON DATPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN TRAPHONG on TRAPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa where KHACHHANG.CMNDhoacVisa='456'";
                cmd = new SqlCommand(sql, cnn);

                int r = dataGridView1.CurrentCell.RowIndex;
/*                string strDichVu = dataGridView1.Rows[r].Cells[4].Value.ToString();
*/                string strSoNgay = dataGridView1.Rows[r].Cells[3].Value.ToString();
                string strIDPhong = dataGridView1.Rows[r].Cells[4].Value.ToString();
                string strTenKhach = dataGridView1.Rows[r].Cells[0].Value.ToString();
                /*string strThongTinPhong = dataGridView1.Rows[r].Cells[5].Value.ToString();*/
                string strCMND = dataGridView1.Rows[r].Cells[1].Value.ToString();
/*
                string tinhtong1 = "SELECT DICHVU.GiaDV FROM DICHVU WHERE DICHVU.TenDichVu = '" + strDichVu + "'";
                string tinhtong2 = "SELECT DICHVU.DSoLuong FROM DICHVU WHERE DICHVU.TenDichVu = '" + strDichVu + "'";
                string tinhtong3 = "SELECT DATEDIFF(DAY, DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong) FROM DATPHONG JOIN KHACHHANG ON DATPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN TRAPHONG ON TRAPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa WHERE KHACHHANG.CMNDhoacVisa='" + strCMND + "'";
                string tinhtong4 = "SELECT PHONG.GiaPhong FROM PHONG WHERE PHONG.SoPhong = '" + strIDPhong + "'";

                tinhtong1cmd = new SqlCommand(tinhtong1, cnn);
                tinhtong2cmd = new SqlCommand(tinhtong2, cnn);
                tinhtong3cmd = new SqlCommand(tinhtong3, cnn);
                tinhtong4cmd = new SqlCommand(tinhtong4, cnn);

                int reader1 = Convert.ToInt32((decimal)(tinhtong1cmd.ExecuteScalar()));
                int reader2 = Int32.Parse((string)(tinhtong2cmd.ExecuteScalar()));
                int reader3 = ((int)(tinhtong3cmd.ExecuteScalar()));
                int reader4 = Convert.ToInt32((decimal)(tinhtong4cmd.ExecuteScalar()));

                int strTong = ((reader1 * reader2) + (reader3 * reader4));
*/
                string sql2 = "	SELECT DATPHONG.LoaiPhong FROM DATPHONG WHERE CMNDhoacVisa='" + strCMND + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                string sql3 = "SELECT PHONG.SoPhong FROM PHONG JOIN DATPHONG ON PHONG.SoPhong = DATPHONG.SoPhong WHERE DATPHONG.CMNDhoacVisa ='" + strCMND + "' ";
                SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                string sql4 = "	SELECT SUM(CAST(DICHVU.DSoLuong AS int)) AS [TONG DICH VU] FROM DICHVU WHERE DICHVU.CMNDhoacVisa ='" + strCMND + "'";
                SqlCommand cmd4 = new SqlCommand(sql4, cnn);
                string sql5 = "	SELECT CAST((SUM(DICHVU.DSoLuong * DICHVU.GiaDV) + (PHONG.GiaPhong * DATEDIFF(DAY, DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong)))AS INT) FROM DICHVU JOIN KHACHHANG ON DICHVU.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN DATPHONG ON DATPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN TRAPHONG ON TRAPHONG.CMNDhoacVisa = KHACHHANG.CMNDhoacVisa JOIN PHONG ON PHONG.SoPhong = DICHVU.SoPhong WHERE KHACHHANG.CMNDhoacVisa ='"+ strCMND +"' GROUP BY PHONG.GiaPhong, DATPHONG.Thoigiannhanphong, TRAPHONG.Thoigiantraphong";
                SqlCommand cmd5 = new SqlCommand(sql5, cnn);

                SqlDataReader idphong = cmd3.ExecuteReader();
                idphong.Read();
                string d = idphong.GetString(0);
                idphong.Close();

                SqlDataReader loai = cmd2.ExecuteReader();
                loai.Read();
                string s = loai.GetString(0);
                loai.Close();

                SqlDataReader dichvu = cmd4.ExecuteReader();
                dichvu.Read();
                int c = dichvu.GetInt32(0);
                dichvu.Close();

                SqlDataReader tong = cmd5.ExecuteReader();
                tong.Read();
                int f = tong.GetInt32(0);
                tong.Close();


                lbThongTinDichVu.Text = c.ToString();
                tbTimTen.Text = strCMND;
                tbIDPhong.Text = d;
                lbThongTinNgay.Text = strSoNgay;
                lbThongTinLoaiPhong.Text = s;
                lbThongTinTongGia.Text = f.ToString();
/*                lbThongTinTongGia.Text = strTong.ToString();
*/
                /*while (loai.Read())
               {*/

                /*}*/
                /*lbThongTinLoaiPhong.Text =loai.Read();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);

            }
            cnn.Close();
        }

    }
}
