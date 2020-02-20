using Dapper;
using Microsoft.Reporting.WinForms;
using POSTiw.ModalPage;
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
    public partial class PreviousBill : Form
    {
        string OrderId = null;
        string Date = null;
        string Time = null;
        SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        ReportDataSource report = new ReportDataSource();
        public PreviousBill()
        {
            InitializeComponent();

            dateTimePicker2.Value = DateTime.Now.Date;
           // SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            conn.Open();
            string Text = "Select ReceiptID, ReceiptDate , ReceiptTime ,TotalPrice , ProductAmount from Receipt Where Active = 'Y' ORDER BY  ReceiptDate DESC , ReceiptTime DESC ";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Text, conn);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
        public void ad(string Username)
        {
            label4.Text = Username.ToString();
        }

        private void PreviousBill_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ReceiptID"].HeaderText = "รหัสใบเสร็จ";
            dataGridView1.Columns["ReceiptDate"].HeaderText = "วันที่ซื้อสินค้า";
            dataGridView1.Columns["ReceiptTime"].HeaderText = "เวลาที่ซื้อสินค้า";
            dataGridView1.Columns["TotalPrice"].HeaderText = "ราคารวม";
            dataGridView1.Columns["ProductAmount"].HeaderText = "จำนวนที่ซื้อ";

            dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            using (IDbConnection db = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd"))
            {
                db.Open();
                string qry = "Select ReceiptID, ReceiptDate , ReceiptTime ,TotalPrice , ProductAmount  from Receipt where ReceiptDate Between '" + date1 + "' and '" + date2 + "' and  Active = 'Y'  ORDER BY ReceiptDate DESC , ReceiptTime DESC";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                OrderId_lab.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                OrderId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Date = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Time = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                using (IDbConnection db = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd"))
                {
                    db.Open();
                    string qry = "SELECT Products.ProductID,Products.ProductName,Products.ProductPrice, ReceiptDetail.Amount FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where ReceiptID = '" + this.OrderId + "'";
                    List<OrderDetail> list = db.Query<OrderDetail>(qry, conn).ToList();
                    report.Name = "DataSet1";
                    report.Value = list;
                    using (CheckReport check = new CheckReport(this.OrderId, this.Date, this.Time, report))
                    {
                        check.ShowDialog();
                        string Text = "Select ReceiptID, ReceiptDate , ReceiptTime ,TotalPrice , ProductAmount from Receipt Where Active = 'Y' ORDER BY  ReceiptDate DESC , ReceiptTime DESC ";
                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(Text, conn);
                        adapter.Fill(data);
                        dataGridView1.DataSource = data;
                    }

                }
            }
           catch (Exception x)
            {

            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main ss = new Main();
            string Username = label4.Text.ToString();
            ss.ad(Username.ToString());
            this.Close();
            ss.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
