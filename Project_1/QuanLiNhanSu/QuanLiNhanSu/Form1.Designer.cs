namespace QuanLiNhanSu
{
    partial class frmMain
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.TabNhanVien = new System.Windows.Forms.TabPage();
            this.TabPhongBan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbThem = new System.Windows.Forms.RadioButton();
            this.rbSua = new System.Windows.Forms.RadioButton();
            this.rbXoa = new System.Windows.Forms.RadioButton();
            this.bntSave = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabMenu.SuspendLayout();
            this.TabNhanVien.SuspendLayout();
            this.TabPhongBan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.TabNhanVien);
            this.tabMenu.Controls.Add(this.TabPhongBan);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(902, 525);
            this.tabMenu.TabIndex = 0;
            // 
            // TabNhanVien
            // 
            this.TabNhanVien.Controls.Add(this.cbGT);
            this.TabNhanVien.Controls.Add(this.cbMaNV);
            this.TabNhanVien.Controls.Add(this.textBox4);
            this.TabNhanVien.Controls.Add(this.lblLuong);
            this.TabNhanVien.Controls.Add(this.textBox3);
            this.TabNhanVien.Controls.Add(this.lblQueQuan);
            this.TabNhanVien.Controls.Add(this.lblGioiTinh);
            this.TabNhanVien.Controls.Add(this.dateTimePicker1);
            this.TabNhanVien.Controls.Add(this.lblNgaySinh);
            this.TabNhanVien.Controls.Add(this.textBox1);
            this.TabNhanVien.Controls.Add(this.lblTenNV);
            this.TabNhanVien.Controls.Add(this.lblMaNV);
            this.TabNhanVien.Controls.Add(this.dtgNhanVien);
            this.TabNhanVien.Controls.Add(this.groupBox1);
            this.TabNhanVien.Location = new System.Drawing.Point(4, 28);
            this.TabNhanVien.Name = "TabNhanVien";
            this.TabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.TabNhanVien.Size = new System.Drawing.Size(894, 493);
            this.TabNhanVien.TabIndex = 0;
            this.TabNhanVien.Text = "Nhân viên";
            this.TabNhanVien.UseVisualStyleBackColor = true;
            // 
            // TabPhongBan
            // 
            this.TabPhongBan.Controls.Add(this.groupBox2);
            this.TabPhongBan.Controls.Add(this.dataGridView1);
            this.TabPhongBan.Location = new System.Drawing.Point(4, 28);
            this.TabPhongBan.Name = "TabPhongBan";
            this.TabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.TabPhongBan.Size = new System.Drawing.Size(894, 493);
            this.TabPhongBan.TabIndex = 1;
            this.TabPhongBan.Text = "Phòng ban";
            this.TabPhongBan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntSave);
            this.groupBox1.Controls.Add(this.rbXoa);
            this.groupBox1.Controls.Add(this.rbSua);
            this.groupBox1.Controls.Add(this.rbThem);
            this.groupBox1.Location = new System.Drawing.Point(686, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbThem
            // 
            this.rbThem.AutoSize = true;
            this.rbThem.Location = new System.Drawing.Point(6, 16);
            this.rbThem.Name = "rbThem";
            this.rbThem.Size = new System.Drawing.Size(61, 23);
            this.rbThem.TabIndex = 0;
            this.rbThem.TabStop = true;
            this.rbThem.Text = "Thêm";
            this.rbThem.UseVisualStyleBackColor = true;
            // 
            // rbSua
            // 
            this.rbSua.AutoSize = true;
            this.rbSua.Location = new System.Drawing.Point(6, 45);
            this.rbSua.Name = "rbSua";
            this.rbSua.Size = new System.Drawing.Size(52, 23);
            this.rbSua.TabIndex = 1;
            this.rbSua.TabStop = true;
            this.rbSua.Text = "Sửa";
            this.rbSua.UseVisualStyleBackColor = true;
            // 
            // rbXoa
            // 
            this.rbXoa.AutoSize = true;
            this.rbXoa.Location = new System.Drawing.Point(6, 74);
            this.rbXoa.Name = "rbXoa";
            this.rbXoa.Size = new System.Drawing.Size(53, 23);
            this.rbXoa.TabIndex = 2;
            this.rbXoa.TabStop = true;
            this.rbXoa.Text = "Xóa";
            this.rbXoa.UseVisualStyleBackColor = true;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(102, 16);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 37);
            this.bntSave.TabIndex = 3;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgNhanVien.Location = new System.Drawing.Point(3, 186);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.Size = new System.Drawing.Size(888, 304);
            this.dtgNhanVien.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(8, 19);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(90, 19);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 5;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(8, 52);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(92, 19);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(8, 84);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(72, 19);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(8, 116);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(59, 19);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(432, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 26);
            this.textBox3.TabIndex = 11;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(358, 19);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(68, 19);
            this.lblQueQuan.TabIndex = 10;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(432, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 26);
            this.textBox4.TabIndex = 13;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(358, 50);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(49, 19);
            this.lblLuong.TabIndex = 12;
            this.lblLuong.Text = "Lương";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(104, 16);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(121, 27);
            this.cbMaNV.TabIndex = 14;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Location = new System.Drawing.Point(104, 113);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(121, 27);
            this.cbGT.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 304);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(688, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Xóa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sửa";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 23);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Thêm";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 525);
            this.Controls.Add(this.tabMenu);
            this.Name = "frmMain";
            this.Text = "Quản lí nhân sự";
            this.tabMenu.ResumeLayout(false);
            this.TabNhanVien.ResumeLayout(false);
            this.TabNhanVien.PerformLayout();
            this.TabPhongBan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage TabNhanVien;
        private System.Windows.Forms.TabPage TabPhongBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbThem;
        private System.Windows.Forms.RadioButton rbSua;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.RadioButton rbXoa;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

