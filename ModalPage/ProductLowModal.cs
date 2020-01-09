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
    public partial class ProductLowModal : Form
    {
        public ProductLowModal(ReportDataSource report)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.ReportAll.LowReport.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("Time",DateTime.Now.ToString())

           };
            this.reportViewer1.LocalReport.SetParameters(p);
        }

        private void ProductLowModal_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
