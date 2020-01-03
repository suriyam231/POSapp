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
    public partial class FormPrint : Form
    {
        string OrderID;
        string Date;
        string Time;
        List<OrderDetail> lists;
        public FormPrint(string OrderId,string date,string time, List<OrderDetail> list)
        {
            InitializeComponent();
            OrderID = OrderId;
            Date = date;
            Time = time;
            lists = list;
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("PorderID",this.OrderID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Pdate",this.Date.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Ptime",this.Time.ToString()),

            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
