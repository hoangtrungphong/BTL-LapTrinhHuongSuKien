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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void hienNV( string dieukienchon = "")
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblNhanVien ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvNhanVien = new DataView(dt);
            grvNhanVien.DataSource = dvNhanVien;

            if (!string.IsNullOrEmpty(dieukienchon))
                dvNhanVien.RowFilter = dieukienchon;

            btnXoaNV.Enabled = btnXoaNV.Enabled = (grvNhanVien.Rows.Count > 0);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLybanMayTinhDataSet1.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLybanMayTinhDataSet1.tblNhanVien);
            btnThemNV.Tag = string.Empty;
            hienNV();
        }

        private void btnBoQuaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text
           = txtTenNV.Text 
           = txtDiaChi.Text
           = txtDienThoai.Text
           =txtNgayVaoLam.Text
           =txtLuongCoBan.Text
           = string.Empty;
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtNgaySinh.ResetText();
            txtMaNV.Focus();

            btnSuaNV.Enabled = btnXoaNV.Enabled = true;
            hienNV();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            string procedureName = string.IsNullOrEmpty(btnThemNV.Tag.ToString()) ? "SP_insertNV" : "spNhanVien_Update";
            string sMaNV = Convert.ToString(btnThemNV.Tag);

            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@sMaNV", SqlDbType.VarChar);
                    if (sMaNV == string.Empty)//them NV moi
                        cmd.Parameters["@sMaNV"].Value = txtMaNV.Text;
                    else
                        cmd.Parameters["@sMaNV"].Value = sMaNV;
                    cmd.Parameters.Add("@sTenNV", txtTenNV.Text);
                    if (rbNam.Checked == true)
                    {
                        cmd.Parameters.Add("@sGioiTinh", "Nam");
                    }
                    else
                        cmd.Parameters.Add("@sGioiTinh", "Nữ");
                    cmd.Parameters.Add("@dNgaySinh", Convert.ToDateTime(txtNgaySinh.Text));
                    cmd.Parameters.Add("@dNgayVaoLam", Convert.ToDateTime(txtNgayVaoLam.Text));
                    cmd.Parameters.Add("@sDiaChi", txtDiaChi.Text);
                    cmd.Parameters.Add("@sSDT", txtDienThoai.Text);
                    cmd.Parameters.Add("@fLuongCB", Convert.ToInt64(txtLuongCoBan.Text));


                    bool KTNV = false;

                    if (sMaNV == string.Empty)
                    {
                        using (SqlCommand check = new SqlCommand("Select * from tblNhanVien", cnn))
                        {
                            cnn.Open();
                            using (SqlDataReader reader = check.ExecuteReader())
                            {
                                 while (reader.Read())
                                 {
                                     //if (Convert.ToString(txtMaNV.Text) == Convert.ToString(reader.GetValue(0)))
                                     //{
                                     //    MessageBox.Show("Mã Nhân viên này đã tồn tại. Mời nhập mã khác");
                                     //    KTNV= true;
                                     //}
                                 
                                 }
                                reader.Close();
                            }
                        }
                    }
                    if (DateTime.Now.Year - DateTime.Parse(txtNgaySinh.Text).Year >= 18)
                    {
                        
                        NhanVien_Load(sender, e);
                        //MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                     else
                     {
                         MessageBox.Show("tuổi hanh viên phải trên  > 18 mời sửa lại");
                     }
                    if (KTNV == false)
                    {
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        btnBoQuaNV_Click(sender, e);
                        hienNV();
                    }
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xoá Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvNV = (DataView)grvNhanVien.DataSource;
                DataRowView drvNV = dvNV[grvNhanVien.CurrentRow.Index];

                string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DELETENV", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNV", drvNV["sMaNV"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienNV();
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
                    MessageBox.Show("Nhân Viên đang có dữ liệu liên quan, không xóa được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaysinh;
            btnThemNV.Enabled = (txtMaNV.Text.Trim().Length > 0);

        }
        private void chuyenTrangThaiSua(DataRowView drvNhanVien)
        {
            txtMaNV.Text = drvNhanVien["sMaNV"].ToString();
            txtTenNV.Text = drvNhanVien["sTenNV"].ToString();
            txtNgaySinh.Text = Convert.ToString(drvNhanVien["dNgaySinh"]);
            txtNgayVaoLam.Text = drvNhanVien["dNgayVaoLam"].ToString();
            txtDiaChi.Text = drvNhanVien["sDiaChi"].ToString();
            txtDienThoai.Text = drvNhanVien["sSDT"].ToString();
            txtLuongCoBan.Text = drvNhanVien["fLuongCB"].ToString();

            if (drvNhanVien["sGioiTinh"].ToString() == "Nam")
                rbNam.Checked = Convert.ToBoolean(true);
            else
                rbNam.Checked = Convert.ToBoolean(false);

            rbNu.Checked = !rbNam.Checked;


            btnThemNV.Text = "Cập nhật";
            btnThemNV.Enabled = true;
            btnThemNV.Tag = drvNhanVien["sMaNV"].ToString();

            btnSuaNV.Enabled = btnXoaNV.Enabled = false;
           
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            
            DataView dvNhanVien = (DataView)grvNhanVien.DataSource;
            DataRowView drvNhanVien = dvNhanVien[grvNhanVien.CurrentRow.Index];

            chuyenTrangThaiSua(drvNhanVien);
              
               
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            DateTime Ngaysinh = new DateTime();
            //DateTime Ngayvaolam = new DateTime();
            string filter = "sMaNV <> ''";
            if (!string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                filter += string.Format(" AND sMaNV LIKE '%{0}%'", txtMaNV.Text);
            if (!string.IsNullOrEmpty(txtTenNV.Text.Trim()))
                filter += string.Format(" AND sTenNV LIKE '%{0}%'", txtTenNV.Text);
            if (!string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                filter += string.Format(" AND sDiaChi LIKE '%{0}%'", txtDiaChi.Text);
            if (!string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                filter += string.Format(" AND sSDT LIKE '%{0}%'", txtDienThoai.Text);
            if (!string.IsNullOrEmpty(txtLuongCoBan.Text.Trim()))
                filter += string.Format(" AND fLuongCB = {0}", txtLuongCoBan.Text);
            if(txtNgaySinh.Text.Trim() !="/  /")
            {
                Ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                filter += string.Format("AND dNgaySinh = '{0}'", Ngaysinh.ToString("yyyy-MM-dd"));
            }
            if (txtNgayVaoLam.Text.Trim() != "/  /")
            {
                Ngaysinh = Convert.ToDateTime(txtNgayVaoLam.Text);
                filter += string.Format("AND dNgayVaoLam = '{0}'", Ngaysinh.ToString("yyyy-MM-dd"));
            }
            //if (txtNgayVaoLam.Text.Trim() != "/  /")
            //    Ngayvaolam = Convert.ToDateTime(txtNgayVaoLam.Text);
            //    filter += string.Format("AND dNgayVaoLam = '{0}'", Ngayvaolam.ToString("yyyy-MM-dd"));
            if (rbNam.Checked == true)
                filter += string.Format(" AND sGioiTinh LIKE N'%Nam%'", rbNam.Checked);

            if (rbNu.Checked == true)
                filter += string.Format(" AND sGioiTinh LIKE N'%Nữ%'", rbNu.Checked);
  
            hienNV(filter);
        }

        private void btnBaoCaoNV_Click(object sender, EventArgs e)
        {
             DateTime Ngaysinh = new DateTime();
             string filter = "{tblNhanVien.sMaNV} <> ''";
             if (!string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblNhanVien.sMaNV}", txtMaNV.Text);
             if (!string.IsNullOrEmpty(txtTenNV.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblNhanVien.sTenNV}", txtTenNV.Text);
             if (!string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblNhanVien.sDiaChi}", txtDiaChi.Text);
             if (!string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
                 filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblNhanVien.sSDT}", txtDienThoai.Text);
             if (!string.IsNullOrEmpty(txtLuongCoBan.Text.Trim()))
                 filter += string.Format(" AND {0} = {1}", "{tblNhanVien.fLuongCB}", txtLuongCoBan.Text);
             if (txtNgaySinh.Text.Trim() != "/  /")
             {
                 Ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                 filter += string.Format("AND {0} = CDate ('{1}')", "{tblNhanVien.dNgaySinh}", Ngaysinh.ToString("yyyy-MM-dd"));
             }
             if (txtNgayVaoLam.Text.Trim() != "/  /")
             {
                 Ngaysinh = Convert.ToDateTime(txtNgayVaoLam.Text);
                 filter += string.Format("AND {0} = CDate ('{1}')", "{tblNhanVien.dNgayVaoLam}", Ngaysinh.ToString("yyyy-MM-dd"));
             }
             if (rbNam.Checked == true)
                 filter += string.Format(" AND {0} LIKE '*Nam*'", "{tblNhanVien.sGioiTinh}");
             
             if (rbNu.Checked == true)
                 filter += string.Format(" AND {0} LIKE '*Nữ*'", "{tblNhanVien.sGioiTinh}");
            //DataView dvNhanVien = (DataView)grvNhanVien.DataSource;
            //DataRowView drvNhanVien = dvNhanVien[grvNhanVien.CurrentRow.Index];
            //string MaNV;
            //MaNV = drvNhanVien["sMaNV"].ToString();
            //string filter = "{tblNhanVien.sMaNV} <> ''";
            //if (!string.IsNullOrEmpty(MaNV.Trim()))
            //    filter += string.Format(" AND {0} = '{1}'",
            //        "{tblNhanVien.sMaNV}", MaNV);


            ViewNhanVienReport reportForm2 = Program.FindOpenedForm("ViewNhanVienReport") as ViewNhanVienReport;
            if (reportForm2 == null)
                reportForm2 = new ViewNhanVienReport();

            reportForm2.Show();
            reportForm2.ShowReport("NhanVienReport.rpt", filter, "Danh sách Nhân Viên"); ;
            reportForm2.Activate();
        }
    }
}
