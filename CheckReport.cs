using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class CheckReport : Form
    {
        public CheckReport(string OrderId, string Date, string Time, ReportDataSource report)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.CheckReport.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("Pid",OrderId.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Pdate",Date.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Ptime",Time.ToString()),
           };
            this.reportViewer1.LocalReport.SetParameters(p);
        }

        private void CheckReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
