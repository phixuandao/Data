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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void butfrmMuonTra_Click(object sender, EventArgs e)
        {
            frmMuonTra frmmt = new frmMuonTra();
            frmmt.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmhd = new frmHuongDan();
            frmhd.ShowDialog();
        }

        private void butfrmDG_Click(object sender, EventArgs e)
        {
            frmDocGia frmdg = new frmDocGia();
            frmdg.ShowDialog();
        }

        private void butfrmSach_Click(object sender, EventArgs e)
        {
            frmSach frms = new frmSach();
            frms.ShowDialog();
        }
    }
}
