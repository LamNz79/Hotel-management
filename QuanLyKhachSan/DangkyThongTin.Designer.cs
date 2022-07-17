
namespace QuanLyKhachSan
{
    partial class DangkyThongTin
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
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 480);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SVN-Effra", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(283, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(524, 40);
            this.label15.TabIndex = 29;
            this.label15.Text = "ĐĂNG KÝ THÔNG TIN KHÁCH HÀNG\r\n";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_DangKy);
            this.groupBox1.Controls.Add(this.txt_tuoi);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 316);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("SVN-Effra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(576, 234);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 47);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("SVN-Effra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(576, 147);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 52);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.White;
            this.btn_DangKy.Font = new System.Drawing.Font("SVN-Effra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
            this.btn_DangKy.Location = new System.Drawing.Point(576, 70);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(126, 54);
            this.btn_DangKy.TabIndex = 15;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(305, 170);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(213, 29);
            this.txt_Email.TabIndex = 14;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(305, 74);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(213, 29);
            this.txt_sdt.TabIndex = 13;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(33, 252);
            this.txt_tuoi.Multiline = true;
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(208, 29);
            this.txt_tuoi.TabIndex = 12;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(33, 170);
            this.txt_CMND.Multiline = true;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(208, 29);
            this.txt_CMND.TabIndex = 11;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(33, 74);
            this.txt_TenKH.Multiline = true;
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(208, 29);
            this.txt_TenKH.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tuổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(300, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(300, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Điện Thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số CMND / VISA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(102, 733);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDữLiệuToolStripMenuItem,
            this.trởVềToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.thoátToolStripMenuItem.Text = "Chức Năng";
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa Dữ Liệu";
            this.xóaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuToolStripMenuItem_Click);
            // 
            // trởVềToolStripMenuItem
            // 
            this.trởVềToolStripMenuItem.Name = "trởVềToolStripMenuItem";
            this.trởVềToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.trởVềToolStripMenuItem.Text = "Trở về";
            this.trởVềToolStripMenuItem.Click += new System.EventHandler(this.trởVềToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SVN-Effra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(806, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tìm Kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "Số CMND/Visa"});
            this.comboBox1.Location = new System.Drawing.Point(811, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 24);
            this.comboBox1.TabIndex = 41;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(811, 179);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(204, 30);
            this.txt_timkiem.TabIndex = 42;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.White;
            this.bt_timkiem.Font = new System.Drawing.Font("SVN-Effra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.Black;
            this.bt_timkiem.Location = new System.Drawing.Point(811, 229);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(129, 49);
            this.bt_timkiem.TabIndex = 43;
            this.bt_timkiem.Text = "Tìm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("SVN-Effra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(811, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 47);
            this.button1.TabIndex = 44;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SVN-Effra", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 36);
            this.label7.TabIndex = 45;
            this.label7.Text = "Thông tin khách hàng";
            // 
            // DangkyThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 733);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DangkyThongTin";
            this.Text = "DangkyThongTin";
            this.Load += new System.EventHandler(this.DangkyThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trởVềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}