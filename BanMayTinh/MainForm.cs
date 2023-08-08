using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMayTinh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Boolean exit = true;

     

        private void QLKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            KH.MdiParent = this;
            KH.Show();
        }

        private void QLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien NV = new NhanVien();
            NV.MdiParent = this;
            NV.Show();
        }

        private void QLMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatHang MH = new MatHang();
            MH.MdiParent = this;
            MH.Show();
        }

        private void QLChiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietNhapHang CTNH = new ChiTietNhapHang();
            CTNH.MdiParent = this;
            CTNH.Show();
        }
         
        private void QLChiTiếtĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietDatHang CTDH = new ChiTietDatHang();
            CTDH.MdiParent = this;
            CTDH.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap();
            DN.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = false;
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
