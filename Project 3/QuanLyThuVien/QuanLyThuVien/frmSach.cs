using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblDauSach";
        private void frmSach_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
            
        }
    }
}
