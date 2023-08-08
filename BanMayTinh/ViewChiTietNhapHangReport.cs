using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class ViewChiTietNhapHangReport : Form
    {
        public ViewChiTietNhapHangReport()
        {
            InitializeComponent();
        }

        internal void ShowReport(string v1, string filter, string v2)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\download\BTL_LTHSK_G21\BanMayTinh\ChiTietNhapHangReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
         
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewChiTietNhapHangReport_Load(string reportName, string recordFilter = "", string recordTitle = "")
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

        private void ViewChiTietNhapHangReport_Load(object sender, EventArgs e)
        {

        }
    }
}
