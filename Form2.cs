using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class Form2 : Form
    {
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;
        LocalReport rep = new LocalReport();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        string Store;
        string Address;
        public Form2(string OrderId,string Date, string Time, ReportDataSource report,string GetLeft, string Getmoney)
        {
            InitializeComponent();
            string Qry = "select * from Store";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Qry, sqlcon);
            adapter.Fill(data);
            Store = data.Rows[0][1].ToString();
            Address = data.Rows[0][2].ToString();
            Date = Date.Substring(0,10);
            Time = Time.Substring(0,5) + " น.";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.ReportAll.Report1.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Store",Store.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Address",Address.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("PID",OrderId.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Date",Date.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Time",Time.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("getMoney",Getmoney.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("getLeft",GetLeft.ToString()),
            };
            
            this.reportViewer1.LocalReport.SetParameters(p);
           
            var dt = report.Value;
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            rep.ReportPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\ReportAll\Report1.rdlc";
            rep.DataSources.Add(new ReportDataSource("DataSet1",dt));
            rep.SetParameters(p);


            this.ActiveControl = textBox1;

        }

        public void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        public void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void Click_ESC(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Escape)
            {
                button1.PerformClick();
            }
            else if (kea.KeyCode == Keys.Enter)
            {
                button3.PerformClick();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PrintToPrinter(rep);
            this.Close();

        }


        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }
        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>0in</PageWidth>
                    <PageHeight>0in</PageHeight>
                    <MarginTop>0in</MarginTop>
                    <MarginLeft>0in</MarginLeft>
                    <MarginRight>0in</MarginRight>
                    <MarginBottom>0in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
            
            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

 

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
