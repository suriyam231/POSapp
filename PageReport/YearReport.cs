﻿using System;
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
        public YearReport()
        {
            InitializeComponent();
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String yy = datevalue.Year.ToString();
            label4.Text = "ประจำปี : " + yy;
            label5.Text = "ประจำปี : " + yy;

            datefront = "01-01-" + yy;
            dateback = "31-12-" + yy;

            string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products " +
                "LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) +0, 0) and DATEADD(MONTH, DATEDIFF(MONTH, 01, GETDATE())+12, 0) " +
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


            int totalRevenue = 0;
            int totalCost = 0;
            int totalProfit = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string text = dataGridView1.Rows[i].Cells[7].Value.ToString();
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
    }
}