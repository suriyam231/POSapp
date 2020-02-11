using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace POSTiw.PageReport
{
    public partial class YearReport : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        ReportDataSource report = new ReportDataSource();
        string datefront;
        string dateback;
        string year;
        public YearReport()
        {
            InitializeComponent();

            string years = DateTime.Now.Year.ToString();
            int oldYear;
            Int32.TryParse(years, out oldYear);
            comboBox2.Items.Add(oldYear - 3);
            comboBox2.Items.Add(oldYear - 2);
            comboBox2.Items.Add(oldYear - 1);
            comboBox2.Items.Add(oldYear);

            comboBox2.Text = oldYear.ToString();
            year = comboBox2.SelectedItem.ToString();

           
        }

        private void YearReport_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DTO.ReportCost> low = new List<DTO.ReportCost>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                float CostPrice = 0;
                float ProductPrice = 0;
                float Counts = 0;
                float TotalCost = 0;
                float TotalRevenue = 0;
                float.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out CostPrice);
                float.TryParse(dataGridView1.Rows[i].Cells[4].Value.ToString(), out ProductPrice);
                float.TryParse(dataGridView1.Rows[i].Cells[5].Value.ToString(), out Counts);
                float.TryParse(dataGridView1.Rows[i].Cells[6].Value.ToString(), out TotalCost);
                float.TryParse(dataGridView1.Rows[i].Cells[7].Value.ToString(), out TotalRevenue);

                low.Add(new DTO.ReportCost()
                {
                    ProductID = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    ProductName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    ProductType = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    CostPrice = CostPrice,
                    ProductPrice = ProductPrice,
                    Counts = Counts,
                    TotalCost = TotalCost,
                    TotalRevenue = TotalRevenue

                });

            }
            report.Name = "DataSet1";
            report.Value = low;
            using (ModalPage.ProfitReport modal = new ModalPage.ProfitReport(report, datefront, dateback))
            {
                modal.ShowDialog();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            year = comboBox2.SelectedItem.ToString();
            datefront = year + "-01-01";
            dateback = year + "-12-31";

            string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products " +
                "LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + datefront.ToString() + "' and '" + dateback.ToString() + "'  and ReceiptDetail.Active = 'Y'" +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0" +
                "ORDER BY Products.TypeName DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุน(บาท)";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขาย(บาท)";
            dataGridView1.Columns["Counts"].HeaderText = "สินค้าที่ขายแล้ว(ชิ้น)";
            dataGridView1.Columns["TotalCost"].HeaderText = "ราคาต้นทุนรวม(บาท)";
            dataGridView1.Columns["TotalRevenue"].HeaderText = "ยอดขายสินค้า(บาท)";

            dataGridView1.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Counts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            float totalRevenue = 0;
            float totalCost = 0;
            float totalProfit = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                float number = 0;
                float.TryParse(text, out number);

                totalRevenue = totalRevenue + number;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string cost = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string count = dataGridView1.Rows[i].Cells[5].Value.ToString();
                float costs = 0;
                float counts = 0;
                float.TryParse(cost, out costs);
                float.TryParse(count, out counts);

                totalCost = totalCost + (costs * counts);
            }
            totalProfit = totalRevenue - totalCost;

            DataTable dataOrder = new DataTable();
            dataOrder.Columns.Add("TotalRevenue");
            dataOrder.Columns.Add("TotalCost");
            dataOrder.Columns.Add("TotalProfit");

            DataRow row = dataOrder.NewRow();
            row["TotalRevenue"] = totalRevenue;
            row["TotalCost"] = totalCost;
            row["TotalProfit"] = totalProfit;
            dataOrder.Rows.Add(row);
            foreach (DataRow Drow in dataOrder.Rows)
            {
                int num = dataGridView2.Rows.Add();
                dataGridView2.Rows[num].Cells[0].Value = Drow["TotalRevenue"].ToString();
                dataGridView2.Rows[num].Cells[1].Value = Drow["TotalCost"].ToString();
                dataGridView2.Rows[num].Cells[2].Value = Drow["TotalProfit"].ToString();
            }
            dataGridView2.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
    }
}
