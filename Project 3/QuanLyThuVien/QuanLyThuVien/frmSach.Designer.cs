namespace QuanLyThuVien
{
    partial class frmSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMDS = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtTenDS = new System.Windows.Forms.TextBox();
            this.butIns = new System.Windows.Forms.Button();
            this.butUpd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rMaDS = new System.Windows.Forms.RadioButton();
            this.rTenDS = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 225);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.butDel);
            this.panel2.Controls.Add(this.butUpd);
            this.panel2.Controls.Add(this.butIns);
            this.panel2.Controls.Add(this.txtTenDS);
            this.panel2.Controls.Add(this.txtGB);
            this.panel2.Controls.Add(this.txtMDS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 237);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(484, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaDS";
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenDS";
            this.Column2.HeaderText = "Tên Đầu Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GiaBan";
            this.Column3.HeaderText = "Giá Bán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đầu Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đầu Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Bán";
            // 
            // txtMDS
            // 
            this.txtMDS.Location = new System.Drawing.Point(216, 9);
            this.txtMDS.Name = "txtMDS";
            this.txtMDS.Size = new System.Drawing.Size(183, 20);
            this.txtMDS.TabIndex = 3;
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(216, 63);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(183, 20);
            this.txtGB.TabIndex = 4;
            // 
            // txtTenDS
            // 
            this.txtTenDS.Location = new System.Drawing.Point(216, 37);
            this.txtTenDS.Name = "txtTenDS";
            this.txtTenDS.Size = new System.Drawing.Size(183, 20);
            this.txtTenDS.TabIndex = 5;
            // 
            // butIns
            // 
            this.butIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIns.Location = new System.Drawing.Point(87, 99);
            this.butIns.Name = "butIns";
            this.butIns.Size = new System.Drawing.Size(100, 30);
            this.butIns.TabIndex = 6;
            this.butIns.Text = "Thêm mới";
            this.butIns.UseVisualStyleBackColor = true;
            // 
            // butUpd
            // 
            this.butUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpd.Location = new System.Drawing.Point(193, 99);
            this.butUpd.Name = "butUpd";
            this.butUpd.Size = new System.Drawing.Size(100, 30);
            this.butUpd.TabIndex = 7;
            this.butUpd.Text = "Chỉnh sửa";
            this.butUpd.UseVisualStyleBackColor = true;
            // 
            // butDel
            // 
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.Location = new System.Drawing.Point(299, 99);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 30);
            this.butDel.TabIndex = 8;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            // 
            // butFind
            // 
            this.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.Location = new System.Drawing.Point(87, 11);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(100, 25);
            this.butFind.TabIndex = 9;
            this.butFind.Text = "Tìm Kiếm";
            this.butFind.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rTenDS);
            this.panel3.Controls.Add(this.rMaDS);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.butFind);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 102);
            this.panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 11;
            // 
            // rMaDS
            // 
            this.rMaDS.AutoSize = true;
            this.rMaDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMaDS.Location = new System.Drawing.Point(87, 40);
            this.rMaDS.Name = "rMaDS";
            this.rMaDS.Size = new System.Drawing.Size(117, 20);
            this.rMaDS.TabIndex = 12;
            this.rMaDS.TabStop = true;
            this.rMaDS.Text = "Mã Đầu Sách";
            this.rMaDS.UseVisualStyleBackColor = true;
            // 
            // rTenDS
            // 
            this.rTenDS.AutoSize = true;
            this.rTenDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTenDS.Location = new System.Drawing.Point(276, 40);
            this.rTenDS.Name = "rTenDS";
            this.rTenDS.Size = new System.Drawing.Size(123, 20);
            this.rTenDS.TabIndex = 13;
            this.rTenDS.TabStop = true;
            this.rTenDS.Text = "Tên Đầu Sách";
            this.rTenDS.UseVisualStyleBackColor = true;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSach";
            this.ShowIcon = false;
            this.Text = "Sách";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rTenDS;
        private System.Windows.Forms.RadioButton rMaDS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butUpd;
        private System.Windows.Forms.Button butIns;
        private System.Windows.Forms.TextBox txtTenDS;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtMDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}