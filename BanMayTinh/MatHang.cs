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
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }
        private void hienMH(string dieukien = "")
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblMatHang ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("sThanhTien");
            DataView dvMatHang = new DataView(dt);
            grvMatHang.DataSource = dvMatHang;

            if (!string.IsNullOrEmpty(dieukien))
                dvMatHang.RowFilter = dieukien;
            //Thành Tiền
            if (grvMatHang.RowCount > 1)
            {
                for (int i = 0; i <= grvMatHang.RowCount - 2; i++)
                {
                    if (grvMatHang.Rows[i].Cells[0].Value != null)
                    {
                        float tongtien = (int)grvMatHang.Rows[i].Cells[4].Value * (int)grvMatHang.Rows[i].Cells[6].Value;
                        grvMatHang.Rows[i].Cells["sThanhTien"].Value = tongtien.ToString();
                    }
                }
            }
            btnXoaMH.Enabled = btnXoaMH.Enabled = (grvMatHang.Rows.Count > 0);
        }
        private void MatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLybanMayTinhDataSet.tblMatHang' table. You can move, or remove it, as needed.
            this.tblMatHangTableAdapter.Fill(this.quanLybanMayTinhDataSet.tblMatHang);

            btnThemMH.Tag = string.Empty;
            hienMH();
        }
        private void btnBoQuaMH_Click(object sender, EventArgs e)
        {
          
             txtTenHang.ResetText();
             txtNCC.ResetText();
             txtMaLoaiHang.ResetText();
             txtSoLuong.ResetText();
             txtDonViTinh.ResetText();
             txtGiaBan.ResetText();
             txtTGBaoHanh.ResetText();
             txtDonViBaoHanh.ResetText();
                
            txtMaHang.ResetText();

            btnSuaMH.Enabled = btnXoaMH.Enabled = true;
            hienMH();
        }
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            string procedureName = string.IsNullOrEmpty(btnThemMH.Tag.ToString()) ? "SP_insertMH" : "spMatHang_Update";
            String sMaHang = Convert.ToString(btnThemMH.Tag);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@sMaHang", SqlDbType.VarChar);
                    if (sMaHang == string.Empty)//them MH moi
                        cmd.Parameters["@sMaHang"].Value = txtMaHang.Text;
                    else
                        cmd.Parameters["@sMaHang"].Value = sMaHang;  
                    cmd.Parameters.Add("@sTenHang", txtTenHang.Text);
                    cmd.Parameters.Add("@iMaNCC",Convert.ToInt64(txtNCC.Text));
                    cmd.Parameters.Add("@sMaLoaiHang", txtMaLoaiHang.Text);
                    cmd.Parameters.Add("@iSoLuong",Convert.ToInt64(txtSoLuong.Text));
                    cmd.Parameters.Add("@sDonViTinh", txtDonViTinh.Text);
                    cmd.Parameters.Add("@fGiaBan",Convert.ToInt64( txtGiaBan.Text)); 
                    cmd.Parameters.Add("@fTGBaoHanh",Convert.ToInt64(txtTGBaoHanh.Text));
                    cmd.Parameters.Add("@sDVBaoHanh", txtDonViBaoHanh.Text);

                    bool KTKH = false;

                    using (SqlCommand check = new SqlCommand("Select * from tblMatHang", cnn))
                    {
                        cnn.Open();
                        using (SqlDataReader reader = check.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToString(txtMaHang.Text) == Convert.ToString(reader.GetValue(0)))
                                {
                                    MessageBox.Show("Mã hàng này đã tồn tại. Mời nhập mã khác");
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

                        btnBoQuaMH_Click(sender, e);
                        hienMH();
                    }
                }
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xoá Mặt Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No) return;

            try
            {
                DataView dvMH = (DataView)grvMatHang.DataSource;
                DataRowView drvMH = dvMH[grvMatHang.CurrentRow.Index];

                string constr = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DELETEMH", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaHang", drvMH["sMaHang"]);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        hienMH();
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
                    MessageBox.Show("Mặt Hàng đang có dữ liệu liên quan, không xóa được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            btnThemMH.Enabled = (txtMaHang.Text.Trim().Length > 0);
        }
        private void chuyenTrangThaiSua(DataRowView drvMatHang)
        {
            txtMaHang.Text = drvMatHang["sMaHang"].ToString();
            txtTenHang.Text = drvMatHang["sTenHang"].ToString(); 
            txtNCC.Text = drvMatHang["iMaNCC"].ToString();
            txtMaLoaiHang.Text = drvMatHang["sMaLoaiHang"].ToString();
            txtSoLuong.Text = drvMatHang["iSoLuong"].ToString();
            txtDonViTinh.Text = drvMatHang["sDonViTinh"].ToString();
            txtGiaBan.Text = drvMatHang["fGiaBan"].ToString();
            txtTGBaoHanh.Text = drvMatHang["fTGBaoHanh"].ToString();
            txtDonViBaoHanh.Text = drvMatHang["sDVBaoHanh"].ToString(); 

            btnThemMH.Text = "Cập nhật";
            btnThemMH.Enabled = true;
            btnThemMH.Tag = drvMatHang["sMaHang"].ToString();

            btnSuaMH.Enabled = btnXoaMH.Enabled = false;
        }
         
        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            DataView dvMatHang = (DataView)grvMatHang.DataSource;
            DataRowView drvMatHang = dvMatHang[grvMatHang.CurrentRow.Index];

            chuyenTrangThaiSua(drvMatHang);
        }

        private void btnTimKiemMh_Click(object sender, EventArgs e)
        {
            string filter = "sMaHang <> ''";
             if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND sMaHang LIKE '%{0}%'", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtTenHang.Text.Trim()))
                filter += string.Format(" AND sTenHang LIKE '%{0}%'", txtTenHang.Text);
            if (!string.IsNullOrEmpty(txtNCC.Text))
                //filter += string.Format(" AND iMaNCC LIKE '%{0}%'", txtNCC.Text);
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "iMaNCC", txtNCC.Text.Trim());
            if (!string.IsNullOrEmpty(txtMaLoaiHang.Text.Trim()))
                filter += string.Format(" AND sMaLoaiHang = {0}", txtMaLoaiHang.Text);
            if (!string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
                filter += string.Format(" AND iSoLuong = {0}", txtSoLuong.Text);
            if (!string.IsNullOrEmpty(txtDonViTinh.Text.Trim()))
                filter += string.Format(" AND sDonViTinh = {0}", txtDonViTinh.Text); 
            if (!string.IsNullOrEmpty(txtGiaBan.Text.Trim()))
                filter += string.Format(" AND fGiaBan = {0}", txtGiaBan.Text); 
            if (!string.IsNullOrEmpty(txtTGBaoHanh.Text.Trim()))
                filter += string.Format(" AND fTGBaoHanh = {0}", txtTGBaoHanh.Text);
            if (!string.IsNullOrEmpty(txtDonViBaoHanh.Text.Trim()))
                filter += string.Format(" AND sDVBaoHanh LIKE '%{0}%'", txtDonViBaoHanh.Text);
              
            /*if (!string.IsNullOrEmpty(txtMaHang.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "sMaHang", txtMaHang.Text.Trim());
            if (!string.IsNullOrEmpty(txtTenHang.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "sTenHang", txtTenHang.Text.Trim());
             
            if (!string.IsNullOrEmpty(txtNCC.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "iMaNCC", txtNCC.Text.Trim());
             
            if (!string.IsNullOrEmpty(txtMaLoaiHang.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "sMaLoaiHang", txtMaLoaiHang.Text.Trim());
             
            if (!string.IsNullOrEmpty(txtSoLuong.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "iSoLuong", txtSoLuong.Text.Trim());
             
            if (!string.IsNullOrEmpty(txtDonViTinh.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "sDonViTinh", txtDonViTinh.Text.Trim());
            if (!string.IsNullOrEmpty(txtGiaBan.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "fGiaBan", txtGiaBan.Text.Trim());
            if (!string.IsNullOrEmpty(txtTGBaoHanh.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "fTGBaoHanh", txtTGBaoHanh.Text.Trim());
            if (!string.IsNullOrEmpty(txtDonViBaoHanh.Text))
                filter += string.Format("AND  CONVERT({0}, System.String) like '%{1}%' ", "dNgayGiao", txtDonViBaoHanh.Text.Trim());*/


            hienMH(filter);
        }

        private void btnBaoCaoMH_Click(object sender, EventArgs e)
        {
            String sMaHang = Convert.ToString(btnBaoCaoMH.Tag);

            string filter = "{tblMatHang.sMaHang} <> ''";
            if (!string.IsNullOrEmpty(txtMaHang.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblMatHang.sMaHang}", txtMaHang.Text);
            if (!string.IsNullOrEmpty(txtTenHang.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.sTenHang}", txtTenHang.Text);
            if (!string.IsNullOrEmpty(txtNCC.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.iMaNCC}", txtNCC.Text); 
            if (!string.IsNullOrEmpty(txtMaLoaiHang.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblMatHang.sMaLoaiHang}", txtMaLoaiHang.Text);
            if (!string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.iSoLuong}", Convert.ToInt64(txtSoLuong.Text));
            if (!string.IsNullOrEmpty(txtDonViTinh.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.sDonViTinh}", txtDonViTinh.Text);
            if (!string.IsNullOrEmpty(txtGiaBan.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.fGiaBan}", txtGiaBan.Text);
            if (!string.IsNullOrEmpty(txtTGBaoHanh.Text.Trim()))
                filter += string.Format(" AND {0} = {1}", "{tblMatHang.fTGBaoHanh}", txtTGBaoHanh.Text);
            if (!string.IsNullOrEmpty(txtDonViBaoHanh.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblMatHang.sDVBaoHanh}",txtDonViBaoHanh.Text);


            ViewMatHangReport reportForm3 = Program.FindOpenedForm("ViewMatHangReport") as ViewMatHangReport;
            if (reportForm3 == null)
                reportForm3 = new ViewMatHangReport();

            reportForm3.Show();
            reportForm3.ShowReport("MatHangReport.rpt", filter, "Danh sách Mặt Hàng"); ;
            reportForm3.Activate();
        }

        private void grvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            //txtTinh.Text = "0";
            //for(int i = 0; i < grvMatHang.Rows.Count; i++)
            //{  
            //    txtTinh.Text = Convert.ToString(Double.Parse(txtTinh.Text) + Double.Parse(grvMatHang.Rows[i].Cells[4].Value.ToString()));
            //}
        }
    }
}
