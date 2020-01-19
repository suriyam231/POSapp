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

namespace POSTiw.ModalPage
{
    public partial class ProfitReport : Form
    {
        public ProfitReport(ReportDataSource report,string datefront,string dateback)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.ReportAll.ReportAll.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("FrontDate",datefront),
                new Microsoft.Reporting.WinForms.ReportParameter("BackDate", dateback)

        };
            this.reportViewer1.LocalReport.SetParameters(p);
        }

        private void ProfitReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
