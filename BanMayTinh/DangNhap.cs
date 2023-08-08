using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMayTinh
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
 
          
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(constr);
            using (SqlConnection cnn = sqlConnection)
            {
                cnn.Open();
                String tendangnhap = txtTK.Text;
                String matkhau = txtMK.Text;
                SqlCommand cmd = new SqlCommand("select * from tblTaiKhoan where sTaiKhoan = '" + tendangnhap + "' and sMatKhau = '" + matkhau + "'", cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MainForm f = new MainForm();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

       
    }

   
}
