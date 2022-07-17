
namespace QuanLyKhachSan
{
    partial class QuanLyNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Nsdt = new System.Windows.Forms.TextBox();
            this.txt_EmailN = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trờLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(353, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(301, 66);
            this.label15.TabIndex = 31;
            this.label15.Text = "QUẢN LÝ NHÂN VIÊN\r\n\r\n";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.bt_timkiem);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Nsdt);
            this.groupBox1.Controls.Add(this.txt_EmailN);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(22, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 293);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhân Viên";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(491, 210);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 58);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(491, 122);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 57);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(491, 34);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 54);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(227, 242);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(215, 27);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // txt_Nsdt
            // 
            this.txt_Nsdt.Location = new System.Drawing.Point(227, 193);
            this.txt_Nsdt.Name = "txt_Nsdt";
            this.txt_Nsdt.Size = new System.Drawing.Size(215, 27);
            this.txt_Nsdt.TabIndex = 16;
            // 
            // txt_EmailN
            // 
            this.txt_EmailN.Location = new System.Drawing.Point(227, 142);
            this.txt_EmailN.Name = "txt_EmailN";
            this.txt_EmailN.Size = new System.Drawing.Size(215, 27);
            this.txt_EmailN.TabIndex = 14;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(227, 88);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(215, 27);
            this.txt_TenNV.TabIndex = 13;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(227, 34);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(215, 27);
            this.txt_MaNV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 291);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(102, 732);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDữLiệuToolStripMenuItem,
            this.trờLạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.fileToolStripMenuItem.Text = "Chức Năng";
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa Dữ Liệu";
            this.xóaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuToolStripMenuItem_Click);
            // 
            // trờLạiToolStripMenuItem
            // 
            this.trờLạiToolStripMenuItem.Name = "trờLạiToolStripMenuItem";
            this.trờLạiToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.trờLạiToolStripMenuItem.Text = "Trờ lại";
            this.trờLạiToolStripMenuItem.Click += new System.EventHandler(this.trờLạiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(831, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.White;
            this.bt_timkiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.Black;
            this.bt_timkiem.Location = new System.Drawing.Point(696, 221);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(129, 36);
            this.bt_timkiem.TabIndex = 48;
            this.bt_timkiem.Text = "Tìm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(696, 146);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(204, 30);
            this.txt_timkiem.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(696, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 30);
            this.comboBox1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(691, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tìm Kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Thông tin nhân viên";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 732);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Nsdt;
        private System.Windows.Forms.TextBox txt_EmailN;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trờLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}