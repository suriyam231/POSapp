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
    public partial class Form2 : Form
    {


        public Form2(string OrderId,string Date, string Time, ReportDataSource report,string GetLeft, string Getmoney)
        {
            InitializeComponent();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.Report1.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("PID",OrderId.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",Date.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Time",Time.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("getMoney",Getmoney.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("getLeft",GetLeft.ToString()),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
        }

        public void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
