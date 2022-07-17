
namespace QuanLyKhachSan
{
    partial class DATPHONG
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
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_LoaiPhong = new System.Windows.Forms.TextBox();
            this.txt_SoP = new System.Windows.Forms.TextBox();
            this.txt_MaDP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trờVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SVN-Effra", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(416, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 40);
            this.label15.TabIndex = 30;
            this.label15.Text = " ĐẶT PHÒNG";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 585);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 123);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DTP1);
            this.groupBox1.Controls.Add(this.bt_timkiem);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_DangKy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.txt_LoaiPhong);
            this.groupBox1.Controls.Add(this.txt_SoP);
            this.groupBox1.Controls.Add(this.txt_MaDP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 281);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Ký Phòng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(806, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DTP1
            // 
            this.DTP1.CustomFormat = "dd/MM/yyyy";
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1.Location = new System.Drawing.Point(174, 87);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(215, 27);
            this.DTP1.TabIndex = 21;
            this.DTP1.Value = new System.DateTime(2021, 5, 13, 0, 0, 0, 0);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.White;
            this.bt_timkiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.Black;
            this.bt_timkiem.Location = new System.Drawing.Point(657, 215);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(129, 36);
            this.bt_timkiem.TabIndex = 53;
            this.bt_timkiem.Text = "Tìm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(468, 215);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 36);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(657, 134);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(204, 30);
            this.txt_timkiem.TabIndex = 52;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(468, 137);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 36);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "Số CMND/Visa",
            "Số Phòng",
            "Loại Phòng",
            "Trạng Thái"});
            this.comboBox1.Location = new System.Drawing.Point(657, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 30);
            this.comboBox1.TabIndex = 51;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.White;
            this.btn_DangKy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
            this.btn_DangKy.Location = new System.Drawing.Point(468, 59);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(126, 36);
            this.btn_DangKy.TabIndex = 18;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(652, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tìm Kiếm";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(174, 188);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(215, 27);
            this.txt_CMND.TabIndex = 17;
            // 
            // txt_LoaiPhong
            // 
            this.txt_LoaiPhong.Location = new System.Drawing.Point(174, 137);
            this.txt_LoaiPhong.Name = "txt_LoaiPhong";
            this.txt_LoaiPhong.Size = new System.Drawing.Size(215, 27);
            this.txt_LoaiPhong.TabIndex = 16;
            // 
            // txt_SoP
            // 
            this.txt_SoP.Location = new System.Drawing.Point(174, 237);
            this.txt_SoP.Name = "txt_SoP";
            this.txt_SoP.Size = new System.Drawing.Size(215, 27);
            this.txt_SoP.TabIndex = 15;
            // 
            // txt_MaDP
            // 
            this.txt_MaDP.Location = new System.Drawing.Point(174, 36);
            this.txt_MaDP.Name = "txt_MaDP";
            this.txt_MaDP.Size = new System.Drawing.Size(215, 27);
            this.txt_MaDP.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "CMND / Visa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời Gian Nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Đặt Phòng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(102, 734);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDữLiệuToolStripMenuItem,
            this.trờVềToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.filesToolStripMenuItem.Text = "Chức Năng";
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa Dữ Liệu";
            this.xóaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuToolStripMenuItem_Click);
            // 
            // trờVềToolStripMenuItem
            // 
            this.trờVềToolStripMenuItem.Name = "trờVềToolStripMenuItem";
            this.trờVềToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.trờVềToolStripMenuItem.Text = "Trờ về";
            this.trờVềToolStripMenuItem.Click += new System.EventHandler(this.trờVềToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(603, 385);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(462, 323);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(598, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Thông Tin Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Thông tin đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thông Tin Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 385);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(578, 144);
            this.dataGridView3.TabIndex = 38;
            // 
            // DATPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1077, 734);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DATPHONG";
            this.Text = "DATPHONG";
            this.Load += new System.EventHandler(this.DATPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_LoaiPhong;
        private System.Windows.Forms.TextBox txt_SoP;
        private System.Windows.Forms.TextBox txt_MaDP;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trờVềToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}