
namespace QUANLYKHACHSAN_TRAPHONG
{
    partial class TinhTIen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbdatagridinfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbThongTinTongGia = new System.Windows.Forms.Label();
            this.lbThongTinDichVu = new System.Windows.Forms.Label();
            this.lbThongTinNgay = new System.Windows.Forms.Label();
            this.lbThongTinLoaiPhong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDPhong = new System.Windows.Forms.TextBox();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btnTimTheoIDPhong = new System.Windows.Forms.Button();
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbdatagridinfo
            // 
            this.lbdatagridinfo.AutoSize = true;
            this.lbdatagridinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatagridinfo.Location = new System.Drawing.Point(57, 429);
            this.lbdatagridinfo.Name = "lbdatagridinfo";
            this.lbdatagridinfo.Size = new System.Drawing.Size(242, 29);
            this.lbdatagridinfo.TabIndex = 8;
            this.lbdatagridinfo.Text = "Thông tin khách hàng";
            this.lbdatagridinfo.Click += new System.EventHandler(this.lbdatagridinfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTinhTien);
            this.groupBox2.Controls.Add(this.lbThongTinTongGia);
            this.groupBox2.Controls.Add(this.lbThongTinDichVu);
            this.groupBox2.Controls.Add(this.lbThongTinNgay);
            this.groupBox2.Controls.Add(this.lbThongTinLoaiPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(194, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 171);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(540, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 29);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(540, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 32);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(540, 44);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(124, 32);
            this.btnTinhTien.TabIndex = 9;
            this.btnTinhTien.Text = "tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lbThongTinTongGia
            // 
            this.lbThongTinTongGia.AutoSize = true;
            this.lbThongTinTongGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinTongGia.Location = new System.Drawing.Point(350, 138);
            this.lbThongTinTongGia.Name = "lbThongTinTongGia";
            this.lbThongTinTongGia.Size = new System.Drawing.Size(37, 29);
            this.lbThongTinTongGia.TabIndex = 13;
            this.lbThongTinTongGia.Text = "---";
            // 
            // lbThongTinDichVu
            // 
            this.lbThongTinDichVu.AutoSize = true;
            this.lbThongTinDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinDichVu.Location = new System.Drawing.Point(167, 138);
            this.lbThongTinDichVu.Name = "lbThongTinDichVu";
            this.lbThongTinDichVu.Size = new System.Drawing.Size(37, 29);
            this.lbThongTinDichVu.TabIndex = 12;
            this.lbThongTinDichVu.Text = "---";
            // 
            // lbThongTinNgay
            // 
            this.lbThongTinNgay.AutoSize = true;
            this.lbThongTinNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNgay.Location = new System.Drawing.Point(167, 99);
            this.lbThongTinNgay.Name = "lbThongTinNgay";
            this.lbThongTinNgay.Size = new System.Drawing.Size(37, 29);
            this.lbThongTinNgay.TabIndex = 11;
            this.lbThongTinNgay.Text = "---";
            // 
            // lbThongTinLoaiPhong
            // 
            this.lbThongTinLoaiPhong.AutoSize = true;
            this.lbThongTinLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinLoaiPhong.Location = new System.Drawing.Point(167, 53);
            this.lbThongTinLoaiPhong.Name = "lbThongTinLoaiPhong";
            this.lbThongTinLoaiPhong.Size = new System.Drawing.Size(37, 29);
            this.lbThongTinLoaiPhong.TabIndex = 10;
            this.lbThongTinLoaiPhong.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dịch vụ:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tbIDPhong);
            this.groupBox1.Controls.Add(this.btnTimTheoTen);
            this.groupBox1.Controls.Add(this.btnTimTheoIDPhong);
            this.groupBox1.Controls.Add(this.tbTimTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(194, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tbIDPhong
            // 
            this.tbIDPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPhong.Location = new System.Drawing.Point(153, 49);
            this.tbIDPhong.Name = "tbIDPhong";
            this.tbIDPhong.Size = new System.Drawing.Size(191, 28);
            this.tbIDPhong.TabIndex = 14;
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoTen.Location = new System.Drawing.Point(473, 83);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(191, 38);
            this.btnTimTheoTen.TabIndex = 13;
            this.btnTimTheoTen.Text = "tìm theo CMND";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btnTimTheoIDPhong
            // 
            this.btnTimTheoIDPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoIDPhong.Location = new System.Drawing.Point(473, 41);
            this.btnTimTheoIDPhong.Name = "btnTimTheoIDPhong";
            this.btnTimTheoIDPhong.Size = new System.Drawing.Size(191, 35);
            this.btnTimTheoIDPhong.TabIndex = 12;
            this.btnTimTheoIDPhong.Text = "tìm theo ID phòng";
            this.btnTimTheoIDPhong.UseVisualStyleBackColor = true;
            this.btnTimTheoIDPhong.Click += new System.EventHandler(this.btnTimTheoIDPhong_Click);
            // 
            // tbTimTen
            // 
            this.tbTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimTen.Location = new System.Drawing.Point(153, 88);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(191, 28);
            this.tbTimTen.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "TÍNH TIỀN";
            // 
            // TinhTIen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1063, 734);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbdatagridinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TinhTIen";
            this.Text = "TraPhong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbdatagridinfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbThongTinTongGia;
        private System.Windows.Forms.Label lbThongTinDichVu;
        private System.Windows.Forms.Label lbThongTinNgay;
        private System.Windows.Forms.Label lbThongTinLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIDPhong;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btnTimTheoIDPhong;
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

