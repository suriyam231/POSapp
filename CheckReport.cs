using Microsoft.Reporting.WinForms;
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

namespace POSTiw
{
    public partial class CheckReport : Form
    {
        string ReceipID;
        public CheckReport(string OrderId, string Date, string Time, ReportDataSource report)
        {
            InitializeComponent();
            ReceipID = OrderId;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSTiw.ReportAll.CheckReport.rdlc";
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

            string qry = "Select * from ReceiptDetail where  ReceiptID = '"+ReceipID+"'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
            adapter.Fill(data);

            for(int i = 0; i < data.Rows.Count; i++)
            {
                string ProductID = data.Rows[i][0].ToString();
                string number = data.Rows[i][3].ToString();
                int Amount;
                Int32.TryParse(number, out Amount);
                string qryPro = "select ProductQuantity, Description from Products where ProductID = '" + ProductID + "'";
                DataTable dataPro = new DataTable();
                SqlDataAdapter adaptePro = new SqlDataAdapter(qryPro, conn);
                adaptePro.Fill(dataPro);
                int Quantity;
                Int32.TryParse(dataPro.Rows[0][0].ToString(), out Quantity);
                int Total = Quantity + Amount;

                //string Descrip = dataPro.Rows[0][1].ToString();
                //string Strsup;
                //try
                //{
                //    Strsup = Descrip.Substring(0, 4).ToString();
                //}
                //catch (Exception ex)
                //{
                //    Strsup = "NOTS";
                //}

                //if (Strsup == "Pack")
                //{
                //    conn.Open();
                //    string str = ProductID.Substring(1);
                //    string Pack = "select ProductQuantity from Products where ProductID= '" + str + "'";
                //    DataTable PackData = new DataTable();
                //    SqlDataAdapter AdapterPack = new SqlDataAdapter(Pack, conn);
                //    int piece;
                //    int Packnumber;
                //    Int32.TryParse(Descrip.Substring(5), out Packnumber);
                //    AdapterPack.Fill(PackData);
                //    piece = PackData.Rows[0].Field<int>(0);
                //    int Totals = piece + Packnumber;

                //    string ChangPack = "UPDATE Products SET ProductQuantity = " + Totals + " Where ProductID = '" + str + "'";
                //    SqlDataReader PackUdate = new SqlCommand(ChangPack, conn).ExecuteReader();
                //    conn.Close();
                //}
                //else if (Strsup != "Pack")
                //{
                //    conn.Open();
                //    string str = "1" + ProductID;
                //    string Pack = "select ProductQuantity ,Description from Products where ProductID= '" + str + "'";
                //    DataTable PackData = new DataTable();
                //    SqlDataAdapter AdapterPack = new SqlDataAdapter(Pack, conn);
                //    int piece;
                //    int PackNumber;
                //    AdapterPack.Fill(PackData);
                //    if (PackData.Rows.Count != 0)
                //    {
                //        Int32.TryParse(PackData.Rows[0][1].ToString().Substring(5), out PackNumber);
                //        piece = PackData.Rows[0].Field<int>(0);

                //        int TotalPack = piece * PackNumber;

                        
                //            piece = Total/PackNumber;
                //            string ChangPack = "UPDATE Products SET ProductQuantity = " + piece + " Where ProductID = '" + str + "'";
                //            SqlDataReader PackUdate = new SqlCommand(ChangPack, conn).ExecuteReader();
                        

                //    }
                //    conn.Close();
                //}
                string insert = "UPDATE Products SET ProductQuantity = '" + Total + "' WHERE ProductID = '" + ProductID + "'";
                conn.Open();
                SqlDataReader reader = new SqlCommand(insert, conn).ExecuteReader();
                conn.Close();
            }
            string Delete = "Delete Receipt where ReceiptID = '"+ReceipID+"'";
            conn.Open();
            SqlDataReader Delete1 = new SqlCommand(Delete, conn).ExecuteReader();
            conn.Close();
            string Deletes = "Delete ReceiptDetail where ReceiptID = '"+ReceipID+"'";
            conn.Open();
            SqlDataReader Delete2 = new SqlCommand(Deletes, conn).ExecuteReader();
            conn.Close();

            this.Close();
        }
    }
}
