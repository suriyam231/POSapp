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

namespace POSTiw.PageReport
{
    public partial class DayReport : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

        public DayReport()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Now.Date;
            
            string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue " +
                "FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date = '"+ DateTime.Now.Date + "'  GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity " +
                "HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY TotalRevenue DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            
            int totalRevenue = 0;
            int totalCost = 0;
            int totalProfit = 0;
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                string text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int number = 0;
                Int32.TryParse(text, out number);

                totalRevenue = totalRevenue + number;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string cost = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string count = dataGridView1.Rows[i].Cells[5].Value.ToString();
                int costs = 0;
                int counts = 0;
                Int32.TryParse(cost, out costs);
                Int32.TryParse(count, out counts);

                totalCost = totalCost + (costs*counts);
            }

            //totalProfit = totalRevenue - totalCost;

            //DataTable dataOrder = new DataTable();
            //dataOrder.Columns.Add("TotalRevenue");
            //dataOrder.Columns.Add("TotalCost");
            //dataOrder.Columns.Add("TotalProfit");

            //DataRow row = dataOrder.NewRow();
            //row["TotalRevenue"] = totalRevenue;
            //row["TotalCost"] = totalCost;
            //row["TotalProfit"] = totalProfit;
            //dataOrder.Rows.Add(row);
            //foreach (DataRow Drow in dataOrder.Rows)
            //{
            //    int num = dataGridView2.Rows.Add();
 
    
            //        dataGridView2.Rows[num].Cells[0].Value = Drow["TotalRevenue"].ToString();
            //        dataGridView2.Rows[num].Cells[1].Value = Drow["TotalCost"].ToString();
            //        dataGridView2.Rows[num].Cells[2].Value = Drow["TotalProfit"].ToString();
 
            //}
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DayReport_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 120;

            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุน(บาท)";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขาย(บาท)";
            dataGridView1.Columns["Counts"].HeaderText = "สินค้าที่ขายแล้ว(ชิ้น)";
            dataGridView1.Columns["TotalRevenue"].HeaderText = "ยอดขายสินค้า(บาท)";

            dataGridView1.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Counts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView2.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[0].Width = 120;
            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].Width = 120;



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker2.Value.Date.ToString();

            dataGridView2.Rows.Clear();
            string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue " +
                "FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date = '" + date + "'  GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity " +
                "HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY TotalRevenue DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            dataGridView1.DataSource = data;

            int totalRevenue = 0;
            int totalCost = 0;
            int totalProfit = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int number = 0;
                Int32.TryParse(text, out number);

                totalRevenue = totalRevenue + number;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string cost = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string count = dataGridView1.Rows[i].Cells[5].Value.ToString();
                int costs = 0;
                int counts = 0;
                Int32.TryParse(cost, out costs);
                Int32.TryParse(count, out counts);

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
        }
    }
}
