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
    public partial class KhachHang : Form
    {
        private object filter;

        public KhachHang()
        {
            InitializeComponent();
        }
        private void hienKH(string condition = "")
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblKhachHang ", cnn);
            DataTable dt = new DataTable();
            dt.Columns.Add("Stuoi");
            da.Fill(dt);
            DataView dvKhachHang = new DataView(dt);
            grvKhachHang.DataSource = dvKhachHang;

            if (!string.IsNullOrEmpty(condition))
                dvKhachHang.RowFilter = condition;
            ///Tao Tuổi
            if(grvKhachHang.RowCount > 1)
            {
                for(int i = 0; i<= grvKhachHang.RowCount -2; i++)
                {
                    DateTime ngay = Convert.ToDateTime(grvKhachHang.Rows[i].Cells[3].Value);
                    int tuoi = (DateTime.Now.Year - ngay.Year);

                    grvKhachHang.Rows[i].Cells["Stuoi"].Value = Convert.ToString(tuoi);
                }
            }


            btnXoaKH.Enabled = btnXoaKH.Enabled = (grvKhachHang.Rows.Count > 0);
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLybanMayTinhDataSet2.tblKhachHang' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter.Fill(this.quanLybanMayTinhDataSet2.tblKhachHang);

            btnThemKH.Tag = string.Empty;
            hienKH();
        }

        private void btnBoQuaKH_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text
            = txtTenKhachHang.Text 
            = txtDiaChiKH.Text
            =txtDienThoaiKH.Text 
            = string.Empty;
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtNgaySinhKH.ResetText();
            txtMaKhachHang.Focus();
            btnSuaKH.Enabled = btnXoaKH.Enabled = true;

            hienKH();
        }
         

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            string procedureName = string.IsNullOrEmpty(btnThemKH.Tag.ToString()) ? "SP_insertKH" : "spKhachHang_Update";
            string sMaKH = Convert.ToString(btnThemKH.Tag);

            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@sMaKH", SqlDbType.VarChar);
                    if (sMaKH == string.Empty)//them kh moi
                        cmd.Parameters["@sMaKH"].Value = txtMaKhachHang.Text;
                    else
                        cmd.Parameters["@sMaKH"].Value = sMaKH;
                    cmd.Parameters.Add("@sTenKH", txtTenKhachHang.Text);
                    if(rbNam.Checked == true)
                    { 
                        cmd.Parameters.Add("@sGioiTinh","Nam");
                    } 
                    else
                        cmd.Parameters.Add("@sGioiTinh", "Nữ");
                    cmd.Parameters.Add("@dNgaysinh", Convert.ToDateTime(txtNgaySinhKH.Text));
                    cmd.Parameters.Add("@sDiachi", txtDiaChiKH.Text);
                    cmd.Parameters.Add("@sSDT", txtDienThoaiKH.Text);
                    
                    bool KTKH = false;

                       using (SqlCommand check = new SqlCommand("select * from tblkhachhang", cnn))
                       {
                           cnn.Open();
                           using (SqlDataReader reader = check.ExecuteReader())
                           {
                               while (reader.Read())
                               {
                                   if (Convert.ToString(txtMaKhachHang.Text) == Convert.ToString(reader.GetValue(0)))
                                   {
                                    MessageBox.Show("mã khách hàng này đã tồn tại. mời nhập mã khác");
                                        KTKH = true;
                                   }
                   
                               }
                               reader.Close();
                           } 
                       } 
                    //using (SqlCommand check = new SqlCommand("select * from dbo.tblKhachHang where (DATEDIFF(DAY,dNgaySinh,GETDATE())/365 >=18)", cnn))
                    //{
                    //    cnn.Open();
                    //    using (SqlDataReader reader = check.ExecuteReader())
                    //    {
                    //        while (reader.Read())
                    //        {
                    //            if (Convert.ToString(txtNgaySinhKH.Text) == Convert.ToString(reader.GetValue(0)))
                    //            {
                    //                MessageBox.Show("tuổi phải lớn hơn 18 nghe cu");
                    //                KTKH = true;
                    //            }

                    //        }
                    //        reader.Close();
                    //    }
                    //}
                    if (KTKH == false) {
                        
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQuaKH_Click(sender, e);
                        hienKH();
                    }
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;
            try
            {
                DataView dvKH = (DataView)grvKhachHang.DataSource;
                DataRowView drvKH = dvKH[grvKhachHang.CurrentRow.Index];

                string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DELETEKH", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKH", drvKH["sMaKH"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienKH();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy liên hệ với đội ngũ kỹ thuật"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khách hàng đang có dữ liệu liên quan, không xóa được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            btnThemKH.Enabled = (txtMaKhachHang.Text.Trim().Length > 0);
        }
        private void chuyenTrangThaiSua(DataRowView drvKhachHang)
        {
            txtMaKhachHang.Text = drvKhachHang["sMaKH"].ToString();
            txtTenKhachHang.Text = drvKhachHang["sTenKH"].ToString();
            txtNgaySinhKH.Text = Convert.ToString(drvKhachHang["dNgaySinh"]);
            txtDiaChiKH.Text = drvKhachHang["sDiachi"].ToString();
            txtDienThoaiKH.Text = drvKhachHang["sSDT"].ToString(); 

            if (drvKhachHang["sGioiTinh"].ToString() == "Nam")
                rbNam.Checked = Convert.ToBoolean(true );
            else
                rbNam.Checked = Convert.ToBoolean(false);

            rbNu.Checked = !rbNam.Checked;

            btnThemKH.Text = "Cập nhật";
            btnThemKH.Enabled = true;
            btnThemKH.Tag = drvKhachHang["sMaKH"].ToString();

            btnSuaKH.Enabled = btnXoaKH.Enabled = false;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            DataView dvKhachHang = (DataView)grvKhachHang.DataSource;
            DataRowView drvKhachHang = dvKhachHang[grvKhachHang.CurrentRow.Index];

            chuyenTrangThaiSua(drvKhachHang);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        { 
            DateTime NgaySinh = new DateTime();
            string filter = "sMaKH <> ''";
            if (!string.IsNullOrEmpty(txtMaKhachHang.Text.Trim()))
                filter += string.Format(" AND sMaKH LIKE '%{0}%'", txtMaKhachHang.Text);
            if (!string.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
                filter += string.Format(" AND sTenKH LIKE '%{0}%'", txtTenKhachHang.Text);
            if (!string.IsNullOrEmpty(txtDiaChiKH.Text.Trim()))
                filter += string.Format(" AND sDiaChi LIKE '%{0}%'", txtDiaChiKH.Text);
            if (!string.IsNullOrEmpty(txtDienThoaiKH.Text.Trim()))
                filter += string.Format(" AND sSDT LIKE '%{0}%'", txtDienThoaiKH.Text);
            if(txtNgaySinhKH.Text.Trim() != "/  /")
            {
                NgaySinh = Convert.ToDateTime(txtNgaySinhKH.Text);
                filter += string.Format(" AND dNgaysinh = '{0}'", NgaySinh.ToString("yyyy-MM-dd"));
            }
            if (!string.IsNullOrEmpty(txtTuoi1.Text.Trim()) && !string.IsNullOrEmpty(txtTuoi2.Text.Trim()))
            {
                filter += string.Format(" AND DATEDIFF(YEAR,dNgaysinh,GETDATE()) >= {0} AND DATEDIFF(YEAR,dNgaysinh,GETDATE()) <= {1}", txtTuoi1.Text, txtTuoi2.Text);
            }
            if (rbNam.Checked == true)
                filter += string.Format(" AND sGioiTinh LIKE 'N%Nam%'");

            if (rbNu.Checked == true)
                filter += string.Format(" AND sGioiTinh LIKE N'%Nữ%'");

            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter(string.Format("Select * from tblKhachHang WHERE {0}", filter), cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvKhachHang = new DataView(dt);

            grvKhachHang.DataSource = dvKhachHang;
        }

        private void btnBaoCaoKH_Click(object sender, EventArgs e)
        {
             DateTime ngaySinh = new DateTime(); 
             string filter = " {tblKhachHang.sMaKH} <> ''";
             if (!string.IsNullOrEmpty(txtMaKhachHang.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblKhachHang.sMaKH}", txtMaKhachHang.Text);
             if (!string.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
                 filter += string.Format(" AND {0} = {1}", "{tblKhachHang.sTenKH}", txtTenKhachHang.Text);
             if (!string.IsNullOrEmpty(txtDiaChiKH.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblKhachHang.sDiaChi}", txtDiaChiKH.Text);
             if (!string.IsNullOrEmpty(txtDienThoaiKH.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblKhachHang.sSDT}", txtDienThoaiKH.Text);
             
             if (txtNgaySinhKH.Text.Trim() != "/  /")
             {
                 ngaySinh = Convert.ToDateTime(txtNgaySinhKH.Text);
                 filter += string.Format(" AND {0} = CDate ('{1}')", "{tblKhachHang.dNgaySinh}", ngaySinh.ToString("yyyy-MM-dd"));
             }
             if (rbNam.Checked == true)
                 filter += string.Format(" AND {0} LIKE '*Nam*'", "{tblKhachHang.sGioiTinh}");
             
             if (rbNu.Checked == true)
               filter += string.Format(" AND {0} LIKE '*Nữ*'", "{tblKhachHang.sGioiTinh}");
            //DataView dvKhachhang = (DataView)grvKhachHang.DataSource;
            //DataRowView drvKhachhan = dvKhachhang[grvKhachHang.CurrentRow.Index];
            //string SMaKH;
            //SMaKH = drvKhachhan["SMaKH"].ToString();
            //string filter = "{tblKhachHang.SMaKH} <> ''";
            //if (!string.IsNullOrEmpty(SMaKH.Trim()))
            //    filter += string.Format(" AND {0} = '{1}'",
            //        "{tblKhachHang.SMaKH}", SMaKH);
            ViewKhachHangReport reportForm1 = Program.FindOpenedForm("ViewKhachHangReport") as ViewKhachHangReport;
            if (reportForm1 == null)
                reportForm1 = new ViewKhachHangReport();

            reportForm1.Show();
            reportForm1.ShowReport("KhachHangReport.rpt", filter,  "Danh sách Khách Hàng"); ;
            reportForm1.Activate();
        }

        private void grvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }
    }
}
