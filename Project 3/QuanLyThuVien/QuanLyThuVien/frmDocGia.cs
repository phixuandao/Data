using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblDocGia";

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }
    }
}
