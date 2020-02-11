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
    public partial class ThreeMonthsResport : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        string year;
        ReportDataSource report = new ReportDataSource();
        string datefront;
        string dateback;
        public ThreeMonthsResport()
        {
            InitializeComponent();
            string years = DateTime.Now.Year.ToString();
            int oldYear;
            Int32.TryParse(years, out oldYear);
            comboBox2.Items.Add(oldYear-3);
            comboBox2.Items.Add(oldYear-2);
            comboBox2.Items.Add(oldYear-1);
            comboBox2.Items.Add(oldYear);

            comboBox2.Text = oldYear.ToString();
            year = comboBox2.SelectedItem.ToString();
            
           

            comboBox1.Items.Add("ไตรมาส 1");
            comboBox1.Items.Add("ไตรมาส 2");
            comboBox1.Items.Add("ไตรมาส 3");
            comboBox1.Items.Add("ไตรมาส 4");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = comboBox1.SelectedItem.ToString();
            if (values == "ไตรมาส 1")
            {
                datefront = year + "-01-01";
                dateback = year + "-3-31";
                string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '"+year+ "-01-01' and '" + year + "-3-31' and ReceiptDetail.Active = 'Y' GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Products.TypeName DESC";
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

                float TotalSale = 0;
                float TotalCost = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string text = data.Rows[i][7].ToString();
                    float number = 0;
                    float.TryParse(text, out number);
                    TotalSale = TotalSale + number;

                    string text1 = data.Rows[i][6].ToString();
                    float number1 = 0;
                    float.TryParse(text1, out number1);
                    TotalCost = TotalCost + number1;
                }

                label8.Text = TotalSale.ToString();
                label9.Text = TotalCost.ToString();
                label10.Text = (TotalSale - TotalCost).ToString();
            }
            if (values == "ไตรมาส 2")
            {
                datefront = year + "-04-01";
                dateback = year + "-06-30";
                string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-04-01' and '" + year + "-6-30' and ReceiptDetail.Active = 'Y' GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Products.TypeName DESC";
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

                float TotalSale = 0;
                float TotalCost = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string text = data.Rows[i][7].ToString();
                    float number = 0;
                    float.TryParse(text, out number);
                    TotalSale = TotalSale + number;

                    string text1 = data.Rows[i][6].ToString();
                    float number1 = 0;
                    float.TryParse(text1, out number1);
                    TotalCost = TotalCost + number1;
                }

                label8.Text = TotalSale.ToString();
                label9.Text = TotalCost.ToString();
                label10.Text = (TotalSale - TotalCost).ToString();
            }
            if (values == "ไตรมาส 3")
            {
                datefront = year + "-07-01";
                dateback = year + "-09-30";
                string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-07-01' and '" + year + "-9-30' and ReceiptDetail.Active = 'Y' GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Products.TypeName DESC";
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

                float TotalSale = 0;
                float TotalCost = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string text = data.Rows[i][7].ToString();
                    float number = 0;
                    float.TryParse(text, out number);
                    TotalSale = TotalSale + number;

                    string text1 = data.Rows[i][6].ToString();
                    float number1 = 0;
                    float.TryParse(text1, out number1);
                    TotalCost = TotalCost + number1;
                }

                label8.Text = TotalSale.ToString();
                label9.Text = TotalCost.ToString();
                label10.Text = (TotalSale - TotalCost).ToString();
            }
            if (values == "ไตรมาส 4")
            {
                datefront = year + "-10-01";
                dateback = year + "-12-31";
                string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-10-01' and '" + year + "-12-31' and ReceiptDetail.Active = 'Y' GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Products.TypeName DESC";
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

                float TotalSale = 0;
                float TotalCost = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string text = data.Rows[i][7].ToString();
                    float number = 0;
                    float.TryParse(text, out number);
                    TotalSale = TotalSale + number;

                    string text1 = data.Rows[i][6].ToString();
                    float number1 = 0;
                    float.TryParse(text1, out number1);
                    TotalCost = TotalCost + number1;
                }

                label8.Text = TotalSale.ToString();
                label9.Text = TotalCost.ToString();
                label10.Text = (TotalSale - TotalCost).ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = comboBox2.SelectedItem.ToString();
            string years = DateTime.Now.Year.ToString();
    
                chart1.Series.Clear();
                chart1.Series.Add("ยอดขายรวม");
                chart1.Series.Add("ต้นทุนรวม");
                chart1.Series.Add("ส่วนต่าง/กำไร");

            
           
            string qry = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-01-01' and '" + year + "-03-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            float TotalSale = 0;
            float TotalCost = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string text = data.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalSale = TotalSale + number;

                string text1 = data.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost = TotalCost + number1;
            }
            chart1.Series["ยอดขายรวม"].Points.AddXY("ไตรมาส 1", TotalSale);
            chart1.Series["ต้นทุนรวม"].Points.AddXY("ไตรมาส 1", TotalCost);
            chart1.Series["ส่วนต่าง/กำไร"].Points.AddXY("ไตรมาส 1", TotalSale - TotalCost);

            string qry2 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-04-01' and '" + year + "-06-30' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(qry2, sqlcon);
            adapter2.Fill(data2);
            float TotalSale2 = 0;
            float TotalCost2 = 0;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                string text = data2.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalSale2 = TotalSale2 + number;

                string text1 = data2.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost2 = TotalCost2 + number1;
            }
            chart1.Series["ยอดขายรวม"].Points.AddXY("ไตรมาส 2", TotalSale2);
            chart1.Series["ต้นทุนรวม"].Points.AddXY("ไตรมาส 2", TotalCost2);
            chart1.Series["ส่วนต่าง/กำไร"].Points.AddXY("ไตรมาส 2", TotalSale2 - TotalCost2);


            string qry3 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-07-01' and '" + year + "-09-30' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(qry3, sqlcon);
            adapter3.Fill(data3);
            float TotalSale3 = 0;
            float TotalCost3 = 0;
            for (int i = 0; i < data3.Rows.Count; i++)
            {
                string text = data3.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalSale3 = TotalSale3 + number;

                string text1 = data3.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost3 = TotalCost3 + number1;
            }
            chart1.Series["ยอดขายรวม"].Points.AddXY("ไตรมาส 3", TotalSale3);
            chart1.Series["ต้นทุนรวม"].Points.AddXY("ไตรมาส 3", TotalCost3);
            chart1.Series["ส่วนต่าง/กำไร"].Points.AddXY("ไตรมาส 2", TotalSale3 - TotalCost3);

            string qry4 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-10-01' and '" + year + "-12-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(qry4, sqlcon);
            adapter4
                .Fill(data4);
            float TotalSale4 = 0;
            float TotalCost4 = 0;
            for (int i = 0; i < data4.Rows.Count; i++)
            {
                string text = data4.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalSale4 = TotalSale4 + number;

                string text1 = data4.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost4 = TotalCost4 + number1;
            }
            chart1.Series["ยอดขายรวม"].Points.AddXY("ไตรมาส 4", TotalSale4);
            chart1.Series["ต้นทุนรวม"].Points.AddXY("ไตรมาส 4", TotalCost4);
            chart1.Series["ส่วนต่าง/กำไร"].Points.AddXY("ไตรมาส 4", TotalSale4 - TotalCost4);
        }

        private void ThreeMonthsResport_Load(object sender, EventArgs e)
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
    }
}
