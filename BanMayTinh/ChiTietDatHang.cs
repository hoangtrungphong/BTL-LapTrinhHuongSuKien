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
    public partial class ChiTietDatHang : Form
    {
        public ChiTietDatHang()
        {
            InitializeComponent();
        }

        private void ChiTietDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLybanMayTinhDataSet3.tblChiTietDatHang' table. You can move, or remove it, as needed.
            this.tblChiTietDatHangTableAdapter.Fill(this.quanLybanMayTinhDataSet3.tblChiTietDatHang);
            btnThemDH.Tag = string.Empty;
            hienCTDH();
        }
        private void hienCTDH(string dieukien = "")
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblChiTietDatHang ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dvDatHang = new DataView(dt);
            grvDatHang.DataSource = dvDatHang;

            if (!string.IsNullOrEmpty(dieukien))
                dvDatHang.RowFilter = dieukien;

            btnXoaDH.Enabled = btnXoaDH.Enabled = (grvDatHang.Rows.Count > 0);
        }

        private void btnBoQuaDH_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();
            txtMaHang.ResetText();
            txtGiaBan.ResetText();
            txtSLMua.ResetText();
            txtMucGiamGia.ResetText();
            txtTGBaoHanh.ResetText();

            hienCTDH();

            btnSuaDH.Enabled = btnXoaDH.Enabled = true;
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            string procedureName = string.IsNullOrEmpty(btnThemDH.Tag.ToString()) ? "SP_CTDatHang" : "SP_CTDatHang_Update";
            long iMaHD = Convert.ToInt64("0" + btnThemDH.Tag);

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


                    cmd.Parameters.Add("@sMaHang", txtMaHang.Text);
                    cmd.Parameters.Add("@fGiaBan", Convert.ToInt64(txtGiaBan.Text));
                    cmd.Parameters.Add("@iSoLuongMua", Convert.ToInt64(txtSLMua.Text));
                    cmd.Parameters.Add("@fMucGiamGia", Convert.ToDouble(txtMucGiamGia.Text));
                    cmd.Parameters.Add("@dThGHetBaoHanh", Convert.ToDateTime(txtTGBaoHanh.Text));


                    bool KTCTDH = false;

                    using (SqlCommand check = new SqlCommand("Select * from tblChiTietDatHang", cnn))
                    {
                        cnn.Open();
                        using (SqlDataReader reader = check.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToString(txtMaHD.Text) == Convert.ToString(reader.GetValue(0)))
                                {
                                    MessageBox.Show("Mã Hoá Đơn này đã tồn tại. Mời nhập mã khác");
                                    KTCTDH = true;
                                }

                            }
                            reader.Close();
                        }
                    }
                    if (KTCTDH == false)
                    {
                        if (DateTime.Parse(txtTGBaoHanh.Text) > DateTime.Now)
                        {
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            ChiTietDatHang_Load(sender, e);
                            btnBoQuaDH_Click(sender, e);
                            hienCTDH();
                        }
                        else
                        {
                            MessageBox.Show("ngày hêt hạn phải lớn hơn hoặc bằng nhày hiện tại, mời nhập lại");
                        }

                    }
                    //if (KTKH == false)
                    //{
                    //    cmd.ExecuteNonQuery();
                    //    cnn.Close();

                    //    btnBoQuaDH_Click(sender, e);
                    //    hienCTDH();
                    //}
                }
            }
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xoá Đơn Đặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;
            try
            {
                DataView dvDH = (DataView)grvDatHang.DataSource;
                DataRowView drvDH = dvDH[grvDatHang.CurrentRow.Index];

                string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DELETEDatHang", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iMaHD", drvDH["iMaHD"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienCTDH();
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
            btnThemDH.Enabled = (txtMaHD.Text.Trim().Length > 0);
        }
        private void chuyenTrangThaiSua(DataRowView drvDatHang)
        {
            txtMaHD.Text = drvDatHang["iMaHD"].ToString();
            txtMaHang.Text = drvDatHang["sMaHang"].ToString();
            txtGiaBan.Text = drvDatHang["fGiaBan"].ToString();
            txtSLMua.Text = drvDatHang["iSoLuongMua"].ToString();
            txtMucGiamGia.Text = drvDatHang["fMucGiamGia"].ToString();
            txtTGBaoHanh.Text = drvDatHang["dThGHetBaoHanh"].ToString(); 

            

            btnThemDH.Text = "Cập nhật";
            btnThemDH.Enabled = true;
            btnThemDH.Tag = drvDatHang["iMaHD"].ToString();

            btnThemDH.Enabled = btnXoaDH.Enabled = false;
        }

        private void btnSuaDH_Click(object sender, EventArgs e)
        {
            DataView dvDatHang = (DataView)grvDatHang.DataSource;
            DataRowView drvDatHang = dvDatHang[grvDatHang.CurrentRow.Index];

            chuyenTrangThaiSua(drvDatHang);
        }

        private void btnTimKiemDH_Click(object sender, EventArgs e)
        {
            DateTime TgbaoHanh = new DateTime();
            string filter = "iMaHD > 0";
            if (!string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                filter += string.Format(" AND iMaHD = {0}", txtMaHD.Text);
            if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND sMaHang LIKE '%{0}%'", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtGiaBan.Text.Trim()))
                filter += string.Format(" AND fGiaBan = {0}", txtGiaBan.Text);
            if (!string.IsNullOrEmpty(txtSLMua.Text.Trim()))
                filter += string.Format(" AND iSoLuongMua = {0}", txtSLMua.Text);
            if (!string.IsNullOrEmpty(txtMucGiamGia.Text.Trim()))
                filter += string.Format(" AND fMucGiamGia = {0}", txtMucGiamGia.Text);
            if(txtTGBaoHanh.Text.Trim() != "/  /")
            {
                TgbaoHanh = Convert.ToDateTime(txtTGBaoHanh.Text);
                filter += string.Format("AND dThGHetBaoHanh = '{0}'", TgbaoHanh.ToString("yyyy-MM-dd"));
            }    
            /*if (!string.IsNullOrEmpty(txtTGBaoHanh.Text.Trim()))*/
/*                filter += string.Format(" AND dThGHetBaoHanh like '{0}'", Convert.ToDateTime(txtTGBaoHanh.Text));
*/
            hienCTDH(filter);
        }

        private void btnBaoCaoDH_Click(object sender, EventArgs e)
        {
            DateTime NgaySinh = new DateTime();
            string filter = "{tblChiTietDatHang.iMaHD} > 0";
            if (!string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietDatHang.iMaHD}", txtMaHD.Text);
            if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '%{1}%'", "{tblChiTietDatHang.sMaHang}", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtGiaBan.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietDatHang.fGiaBan}", txtGiaBan.Text);
            if (!string.IsNullOrEmpty(txtSLMua.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietDatHang.iSoLuongMua}", txtSLMua.Text);
            if (!string.IsNullOrEmpty(txtMucGiamGia.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblChiTietDatHang.fMucGiamGia}", txtMucGiamGia.Text);
            
            if (txtTGBaoHanh.Text.Trim() != "/  /")
            {
                NgaySinh = Convert.ToDateTime(txtTGBaoHanh.Text);
                filter += string.Format(" AND {0} = CDate ('{1}')", "{tblChiTietDatHang.dThGHetBaoHanh}", NgaySinh.ToString("yyyy-MM-dd"));
            }
            
            ViewChiTietdatHangReport reportForm6 = Program.FindOpenedForm("ViewChiTietdatHangReport") as ViewChiTietdatHangReport;
            if (reportForm6 == null)
                reportForm6 = new ViewChiTietdatHangReport();

            reportForm6.Show();
            reportForm6.ShowReport("ChiTietDatHangReport.rpt", filter, "Danh sách chi tiết đặt hàng"); ;
            reportForm6.Activate();
        }
    }
}
