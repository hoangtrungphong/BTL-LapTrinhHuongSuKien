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
    public partial class ChiTietNhapHang : Form
    {
        public ChiTietNhapHang()
        {
            InitializeComponent();
        }
        public void LoadCOmbobox()
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblChiTietNhapHang ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            checkedListBox1.DataSource = dt;
            checkedListBox1.DisplayMember = "sMaHang";
            checkedListBox1.ValueMember = "sMaHang";

        }
        private void hienCTNH(string dieukien = "")
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblChiTietNhapHang ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvCTNhapHang = new DataView(dt);
            grvCTNhapHang.DataSource = dvCTNhapHang;

            if (!string.IsNullOrEmpty(dieukien))
                dvCTNhapHang.RowFilter = dieukien;

            btnXoaCT.Enabled = btnXoaCT.Enabled = (grvCTNhapHang.Rows.Count > 0);
        }
        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLybanMayTinhDataSet4.tblChiTietNhapHang' table. You can move, or remove it, as needed.
            this.tblChiTietNhapHangTableAdapter.Fill(this.quanLybanMayTinhDataSet4.tblChiTietNhapHang);
            btnNhapCT.Tag = string.Empty;
            hienCTNH();
            LoadCOmbobox();
        }

        private void btnBoQuaCT_Click(object sender, EventArgs e)
        {

            txtMaHD.ResetText();
            txtMaHang.ResetText();
            txtGiaNhap.ResetText();
            txtSLNhap.ResetText(); 
            txtMaHang.ResetText();

            btnSuaCT.Enabled = btnXoaCT.Enabled = true;
            hienCTNH();
        }

        private void btnNhapCT_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            string procedureName = string.IsNullOrEmpty(btnNhapCT.Tag.ToString()) ? "SP_CtNhapHang" : "spCTNhapHang_Update";
            long iMaHD = Convert.ToInt64("0" + btnNhapCT.Tag);
                 
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@iMaHD", SqlDbType.Int); 
                    if (iMaHD == 0)//them kh moi
                        cmd.Parameters["@iMaHD"].Value = txtMaHD.Text;
                    else
                        cmd.Parameters["@iMaHD"].Value = iMaHD;

                    cmd.Parameters.Add("@sMaHang",checkedListBox1.Text);   
                    cmd.Parameters.Add("@fGiaNhap", Convert.ToInt64(txtGiaNhap.Text));  
                    cmd.Parameters.Add("@iSoLuongNhap", Convert.ToInt64(txtSLNhap.Text));


                    bool KTKH = false;

                    using (SqlCommand check = new SqlCommand("Select * from tblChiTietNhapHang ", cnn))
                    {
                        cnn.Open();
                        using (SqlDataReader reader = check.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToString(txtMaHD.Text) == Convert.ToString(reader.GetValue(0)))
                                {
                                    MessageBox.Show("Mã Hoá Đơn này đã tồn tại. Mời nhập mã khác");
                                    KTKH = true;
                                }

                            }
                            reader.Close();
                        }
                    }
                    if (KTKH == false)
                    {
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        btnBoQuaCT_Click(sender, e);
                        hienCTNH();
                    }
                }
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;
            try
            {

                DataView dvNH = (DataView)grvCTNhapHang.DataSource;
                DataRowView drvNH = dvNH[grvCTNhapHang.CurrentRow.Index];

                string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DELETECTNH", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iMaHD", drvNH["iMaHD"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienCTNH();
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

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        { 
            btnNhapCT.Enabled = (txtMaHD.Text.Trim().Length > 0);
        }
        private void chuyenTrangThaiSua(DataRowView drvCTNhapHang)
        {
            txtMaHD.Text = drvCTNhapHang["iMaHD"].ToString();
            txtMaHang.Text = drvCTNhapHang["sMaHang"].ToString();
            txtGiaNhap.Text = drvCTNhapHang["fGiaNhap"].ToString();
            txtSLNhap.Text = drvCTNhapHang["iSoLuongNhap"].ToString(); 

             

            btnNhapCT.Text = "Cập nhật";
            btnNhapCT.Enabled = true;
            btnNhapCT.Tag = drvCTNhapHang["iMaHD"].ToString();

            btnSuaCT.Enabled = btnXoaCT.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            DataView dvCTNhapHang = (DataView)grvCTNhapHang.DataSource;
            DataRowView drvCTNhapHang = dvCTNhapHang[grvCTNhapHang.CurrentRow.Index];

            chuyenTrangThaiSua(drvCTNhapHang);
        }

        private void btnTimKiemCT_Click(object sender, EventArgs e)
        {
            string filter = "iMaHD > 0";
            if (!string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                filter += string.Format(" AND iMaHD = {0}", txtMaHD.Text);
            if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND sMaHang LIKE '%{0}%'", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtGiaNhap.Text.Trim()))
                filter += string.Format(" AND fGiaNhap = {0}", txtGiaNhap.Text);
            if (!string.IsNullOrEmpty(txtSLNhap.Text.Trim()))
                filter += string.Format(" AND iSoLuongNhap = {0}", txtSLNhap.Text);
             
            hienCTNH(filter);
        }

        

        private void btnBaoCaoCT_Click_1(object sender, EventArgs e)
        { 
            string filter = "{tblChiTietNhapHang.iMaHD}  > 0";
            if (!string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietNhapHang.iMaHD}", txtMaHD.Text);
            if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '%{1}%'", "{tblChiTietNhapHang.sMaHang}", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtGiaNhap.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietNhapHang.fGiaNhap}", txtGiaNhap.Text);
            if (!string.IsNullOrEmpty(txtSLNhap.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietNhapHang.iSoLuongNhap}", txtSLNhap.Text);

            ViewChiTietNhapHangReport reportForm4 = Program.FindOpenedForm("ViewChiTietNhapHangReport") as ViewChiTietNhapHangReport;
            if (reportForm4 == null)
                reportForm4 = new ViewChiTietNhapHangReport();

            reportForm4.Show();
            reportForm4.ShowReport("ChiTietNhapHangReport.rpt", filter, "Danh sách chi tiết hàng"); ;
            reportForm4.Activate();
        }
    }
}
