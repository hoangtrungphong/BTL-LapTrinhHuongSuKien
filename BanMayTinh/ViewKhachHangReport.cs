using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class ViewKhachHangReport : Form
    {
        private object reportName;

        public ViewKhachHangReport()
        {
            InitializeComponent();
        }

        private void ViewKhachHangReport_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\download\BTL_LTHSK_G21\BanMayTinh\KhachHangReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

            LoadComBoBox();
        }

        internal void ShowReport(string reportName, string recordFilter = "", string recordTitle = "" )
        {
            ReportDocument rpt = new ReportDocument();
            string path = string.Format(@"D:\download\BTL_LTHSK_G21\BanMayTinh\{0}", reportName);
            rpt.Load(path);

            TableLogOnInfo logonInfo = new TableLogOnInfo();
            logonInfo.ConnectionInfo.ServerName = @"ADMIN";
            logonInfo.ConnectionInfo.DatabaseName = "QuanLybanMayTinh";
            logonInfo.ConnectionInfo.UserID = "sa";
            logonInfo.ConnectionInfo.Password = "111";

            foreach (Table t in rpt.Database.Tables)
                t.ApplyLogOnInfo(logonInfo);
            if (!string.IsNullOrEmpty(recordFilter))
                rpt.RecordSelectionFormula = recordFilter;
            if (!string.IsNullOrEmpty(recordTitle))
                rpt.SummaryInfo.ReportTitle = recordTitle;

            crystalReportViewer1.ReportSource = rpt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadComBoBox()
        {
            string strCnn = @"Data Source=ADMIN;Initial Catalog=QuanLybanMayTinh ;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCnn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblKhachHang", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtMaKhachHang.DataSource = dt;
            txtMaKhachHang.DisplayMember = "sMaKH";
            txtMaKhachHang.ValueMember = "sMaKH";
        }
         private void button1_Click(object sender, EventArgs e)
         {
              string filter = string.Format("{0} <> ''", "{tblKhachHang.sMaKH}");
              if (!string.IsNullOrEmpty(txtMaKhachHang.Text.Trim()))
                  filter += string.Format(" AND {0} LIKE '*{1}*'", "{tblKhachHang.sMaKH}", txtMaKhachHang.Text);
              
              ViewKhachHangReport reportForm1 = Program.FindOpenedForm("ViewKhachHangReport") as ViewKhachHangReport;
              if (reportForm1 == null)
                  reportForm1 = new ViewKhachHangReport();
              
              reportForm1.Show();
              reportForm1.ShowReport("KhachHangReport.rpt", filter, "Danh sách Khách Hàng"); ;
             reportForm1.Activate();
         }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string filter = string.Format("{0} <> ''", "{tblKhachHang.sTenKH}");
        //    if (!string.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
        //        filter += string.Format(" AND {0} = {1}", "{tblKhachHang.sTenKH}", txtTenKhachHang.Text);

        //    ViewKhachHangReport reportForm1 = Program.FindOpenedForm("ViewKhachHangReport") as ViewKhachHangReport;
        //    if (reportForm1 == null)
        //        reportForm1 = new ViewKhachHangReport();

        //    reportForm1.Show();
        //    reportForm1.ShowReport("KhachHangReport.rpt", filter, "Danh sách Khách Hàng"); ;
        //    reportForm1.Activate();
        //}
    }
}
