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
    public partial class MonthReport : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        ReportDataSource report = new ReportDataSource();
        public MonthReport()
        {
            InitializeComponent();

            string[] menu = new string[3];
            menu[0] = "ยอดขายรวม (บาท)";
            menu[1] = "ต้นทุนรวม (บาท)";
            menu[2] = "รายได้รวม (บาท)";

            string[] January = new string[3];

            string[] Month = new string[12];

            string year = DateTime.Now.Year.ToString();

            string qry = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-01-01' and '" + year + "-01-31' and ReceiptDetail.Active = 'Y'  Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            float TotalRevenue = 0;
            float TotalCost = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
               string text = data.Rows[i][0].ToString();
               float number = 0;
               float.TryParse(text, out number);
               TotalRevenue = TotalRevenue + number;

                string text1 = data.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost = TotalCost + number1;
            }
            January[0] = TotalRevenue.ToString();
            January[1] = TotalCost.ToString();
            January[2] = (TotalRevenue - TotalCost).ToString();


            string[] February = new string[3];
            string qry2 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '"+year+ "-02-01' and '" + year + "-02-29' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(qry2, sqlcon);
            adapter2.Fill(data2);
            float TotalRevenue2 = 0;
            float TotalCost2 = 0;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                string text = data2.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue2 = TotalRevenue2 + number;

                string text1 = data2.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost2 = TotalCost2 + number1;
            }
            February[0] = TotalRevenue2.ToString();
            February[1] = TotalCost2.ToString();
            February[2] = (TotalRevenue2 - TotalCost2).ToString();

            string[] March = new string[3];
            string qry3 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-03-01' and '" + year + "-03-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(qry3, sqlcon);
            adapter3.Fill(data3);
            float TotalRevenue3 = 0;
            float TotalCost3 = 0;
            for (int i = 0; i < data3.Rows.Count; i++)
             {
                 string text = data3.Rows[i][0].ToString();
                 float number = 0;
                 float.TryParse(text, out number);
                 TotalRevenue3 = TotalRevenue3 + number;

                 string text1 = data3.Rows[i][1].ToString();
                 float number1 = 0;
                 float.TryParse(text1, out number1);
                 TotalCost3 = TotalCost3 + number1;
             }
             March[0] = TotalRevenue3.ToString();
             March[1] = TotalCost3.ToString();
             March[2] = (TotalRevenue3 - TotalCost3).ToString();

            string[] April = new string[3];
            string qry4 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-04-01' and '" + year + "-04-30' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(qry4, sqlcon);
            adapter4.Fill(data4);
            float TotalRevenue4 = 0;
            float TotalCost4 = 0;
            for (int i = 0; i < data4.Rows.Count; i++)
            {
                string text = data4.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue4 = TotalRevenue4 + number;

                string text1 = data4.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost4 = TotalCost4 + number1;
            }
            April[0] = TotalRevenue4.ToString();
            April[1] = TotalCost4.ToString();
            April[2] = (TotalRevenue4 - TotalCost4).ToString();



            string[] May = new string[3];
            string qry5 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-05-01' and '" + year + "-05-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data5 = new DataTable();
            SqlDataAdapter adapter5 = new SqlDataAdapter(qry5, sqlcon);
            adapter5.Fill(data5);
            float TotalRevenue5 = 0;
            float TotalCost5 = 0;
            for (int i = 0; i < data5.Rows.Count; i++)
            {
                string text = data5.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue5 = TotalRevenue5 + number;

                string text1 = data5.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost5 = TotalCost5 + number1;
            }
            May[0] = TotalRevenue5.ToString();
            May[1] = TotalCost5.ToString();
            May[2] = (TotalRevenue5 - TotalCost5).ToString();


            string[] June = new string[3];
            string qry6 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-06-01' and '" + year + "-06-30' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data6 = new DataTable();
            SqlDataAdapter adapter6 = new SqlDataAdapter(qry6, sqlcon);
            adapter6.Fill(data6);
            float TotalRevenue6 = 0;
            float TotalCost6 = 0;
            for (int i = 0; i < data6.Rows.Count; i++)
            {
                string text = data6.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue6 = TotalRevenue6 + number;

                string text1 = data6.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost6 = TotalCost6 + number1;
            }
            June[0] = TotalRevenue6.ToString();
            June[1] = TotalCost6.ToString();
            June[2] = (TotalRevenue6 - TotalCost6).ToString();


            string[] July = new string[3];
            string qry7 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-07-01' and '" + year + "-07-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data7 = new DataTable();
            SqlDataAdapter adapter7 = new SqlDataAdapter(qry7, sqlcon);
            adapter7.Fill(data7);
            float TotalRevenue7 = 0;
            float TotalCost7 = 0;
            for (int i = 0; i < data7.Rows.Count; i++)
            {
                string text = data7.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue7 = TotalRevenue7 + number;

                string text1 = data7.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost7 = TotalCost7 + number1;
            }
            July[0] = TotalRevenue7.ToString();
            July[1] = TotalCost7.ToString();
            July[2] = (TotalRevenue7 - TotalCost7).ToString();


            string[] August = new string[3];
            string qry8 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-08-01' and '" + year + "-08-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data8 = new DataTable();
            SqlDataAdapter adapter8 = new SqlDataAdapter(qry8, sqlcon);
            adapter8.Fill(data8);
            float TotalRevenue8 = 0;
            float TotalCost8 = 0;
            for (int i = 0; i < data8.Rows.Count; i++)
            {
                string text = data8.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue8 = TotalRevenue8 + number;

                string text1 = data8.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost8 = TotalCost8 + number1;
            }
            August[0] = TotalRevenue8.ToString();
            August[1] = TotalCost8.ToString();
            August[2] = (TotalRevenue8 - TotalCost8).ToString();


            string[] September = new string[3];
            string qry9 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-09-01' and '" + year + "-09-30'and ReceiptDetail.Active = 'Y'  Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data9 = new DataTable();
            SqlDataAdapter adapter9 = new SqlDataAdapter(qry9, sqlcon);
            adapter9.Fill(data9);
            float TotalRevenue9 = 0;
            float TotalCost9 = 0;
            for (int i = 0; i < data9.Rows.Count; i++)
            {
                string text = data9.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue9 = TotalRevenue9 + number;

                string text1 = data9.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost9 = TotalCost9 + number1;
            }
            September[0] = TotalRevenue9.ToString();
            September[1] = TotalCost9.ToString();
            September[2] = (TotalRevenue9 - TotalCost9).ToString();


            string[] October = new string[3];
            string qry10 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-10-01' and '" + year + "-10-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data10 = new DataTable();
            SqlDataAdapter adapter10 = new SqlDataAdapter(qry10, sqlcon);
            adapter10.Fill(data10);
            float TotalRevenue10 = 0;
            float TotalCost10 = 0;
            for (int i = 0; i < data10.Rows.Count; i++)
            {
                string text = data10.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue10 = TotalRevenue10 + number;

                string text1 = data10.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost10 = TotalCost10 + number1;
            }
            October[0] = TotalRevenue10.ToString();
            October[1] = TotalCost10.ToString();
            October[2] = (TotalRevenue10 - TotalCost10).ToString();


            string[] November = new string[3];
            string qry11 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-11-01' and '" + year + "-11-30' and ReceiptDetail.Active = 'Y'  Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data11 = new DataTable();
            SqlDataAdapter adapter11 = new SqlDataAdapter(qry11, sqlcon);
            adapter11.Fill(data11);
            float TotalRevenue11 = 0;
            float TotalCost11 = 0;
            for (int i = 0; i < data11.Rows.Count; i++)
            {
                string text = data11.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue11 = TotalRevenue11 + number;

                string text1 = data11.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost11 = TotalCost11 + number1;
            }
            November[0] = TotalRevenue11.ToString();
            November[1] = TotalCost11.ToString();
            November[2] = (TotalRevenue11 - TotalCost11).ToString();


            string[] December = new string[3];
            string qry12 = "SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '" + year + "-12-01' and '" + year + "-12-31' and ReceiptDetail.Active = 'Y' Group by Products.ProductPrice,  Products.ProductName,Products.ProductID";
            DataTable data12 = new DataTable();
            SqlDataAdapter adapter12 = new SqlDataAdapter(qry12, sqlcon);
            adapter12.Fill(data12);
            float TotalRevenue12 = 0;
            float TotalCost12 = 0;
            for (int i = 0; i < data12.Rows.Count; i++)
            {
                string text = data12.Rows[i][0].ToString();
                float number = 0;
                float.TryParse(text, out number);
                TotalRevenue12 = TotalRevenue12 + number;

                string text1 = data12.Rows[i][1].ToString();
                float number1 = 0;
                float.TryParse(text1, out number1);
                TotalCost12 = TotalCost12 + number1;
            }
            December[0] = TotalRevenue12.ToString();
            December[1] = TotalCost12.ToString();
            December[2] = (TotalRevenue12 - TotalCost12).ToString();


            for (int i = 0; i < 3; i++)
            {
                DataTable dataOrder = new DataTable();
                dataOrder.Columns.Add("Menu");
                dataOrder.Columns.Add("January");
                dataOrder.Columns.Add("February");
                dataOrder.Columns.Add("March");
                dataOrder.Columns.Add("April");
                dataOrder.Columns.Add("May");
                dataOrder.Columns.Add("June");
                dataOrder.Columns.Add("July");
                dataOrder.Columns.Add("August");
                dataOrder.Columns.Add("September");
                dataOrder.Columns.Add("October");
                dataOrder.Columns.Add("November");
                dataOrder.Columns.Add("December");


                DataRow row = dataOrder.NewRow();
                row["Menu"] = menu[i];
                row["January"] = January[i];
                row["February"] = February[i];
                row["March"] = March[i];
                row["April"] = April[i];
                row["May"] = May[i];
                row["June"] = June[i];
                row["July"] = July[i];
                row["August"] = August[i];
                row["September"] = September[i];
                row["October"] = October[i];
                row["November"] = November[i];
                row["December"] = December[i];

                dataOrder.Rows.Add(row);
                foreach (DataRow Drow in dataOrder.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["Menu"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["January"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["February"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = Drow["March"].ToString();
                    dataGridView1.Rows[num].Cells[4].Value = Drow["April"].ToString();
                    dataGridView1.Rows[num].Cells[5].Value = Drow["May"].ToString();
                    dataGridView1.Rows[num].Cells[6].Value = Drow["June"].ToString();
                    dataGridView1.Rows[num].Cells[7].Value = Drow["July"].ToString();
                    dataGridView1.Rows[num].Cells[8].Value = Drow["August"].ToString();
                    dataGridView1.Rows[num].Cells[9].Value = Drow["September"].ToString();
                    dataGridView1.Rows[num].Cells[10].Value = Drow["October"].ToString();
                    dataGridView1.Rows[num].Cells[11].Value = Drow["November"].ToString();
                    dataGridView1.Rows[num].Cells[12].Value = Drow["December"].ToString();
                }
            }
            comboBox1.Items.Add("มกราคม");
            comboBox1.Items.Add("กุมภาพันธ์");
            comboBox1.Items.Add("มีนาคม");
            comboBox1.Items.Add("เมษายน");
            comboBox1.Items.Add("พฤษภาคม");
            comboBox1.Items.Add("มิถุนายน");
            comboBox1.Items.Add("กรกฎาคม");
            comboBox1.Items.Add("สิงหาคม");
            comboBox1.Items.Add("กันยายน");
            comboBox1.Items.Add("ตุลาคม");
            comboBox1.Items.Add("พฤศจิกายน");
            comboBox1.Items.Add("ธันวาคม");
        }

        private void MonthReport_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["January"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["February"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["March"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["April"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["May"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["June"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["July"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["August"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["September"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["October"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["November"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["December"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 60;
            dataGridView1.Columns[10].Width = 60;
            dataGridView1.Columns[11].Width = 60;
            dataGridView1.Columns[12].Width = 60;



            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string datefront;
        string dateback;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = comboBox1.SelectedItem.ToString();
            int fornt = 0;
            int back = 0;
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            
              
            String yy = datevalue.Year.ToString();

            if (values == "มกราคม")
            {
                fornt = 0;
                back = 1;
                datefront = yy+"-01-01";
                dateback = yy +"-01-31" ;
            }
            else if (values == "กุมภาพันธ์")
            {
                fornt = 1;
                back = 2;
                datefront = yy + "-02-01";
                dateback = yy + "-02-29";
            }
            else if (values == "มีนาคม")
            {
                fornt = 2;
                back = 3;
                datefront = yy + "-03-01";
                dateback = yy + "-03-31";
            }
            else if (values == "เมษายน")
            {
                fornt = 3;
                back = 4;
                datefront = yy + "-04-01";
                dateback = yy + "-04-30";
            }
            else if (values == "พฤษภาคม")
            {
                fornt = 4;
                back = 5;
                datefront = yy + "-05-01";
                dateback = yy + "-05-31";
            }
            else if (values == "มิถุนายน")
            {
                fornt = 5;
                back = 6;
                datefront = yy + "-06-01";
                dateback = yy + "-06-30";
            }
            else if (values == "กรกฎาคม")
            {
                fornt = 6;
                back = 7;
                datefront = yy + "-07-01";
                dateback = yy + "-07-31";
            }
            else if (values == "สิงหาคม")
            {
                fornt = 7;
                back = 8;
                datefront = yy + "-08-01";
                dateback = yy + "-08-31";
            }
            else if (values == "กันยายน")
            {
                fornt = 8;
                back = 9;
                datefront = yy + "-09-01";
                dateback = yy + "-09-30";
            }
            else if (values == "ตุลาคม")
            {
                fornt = 9;
                back = 10;
                datefront = yy + "-10-01";
                dateback = yy + "-10-31";
            }
            else if (values == "พฤศจิกายน")
            {
                fornt = 10;
                back = 11;
                datefront = yy + "-11-01";
                dateback = yy + "-11-30";
            }
            else if (values == "ธันวาคม")
            {
                fornt = 11;
                back = 12;
                datefront = yy + "-12-01";
                dateback = yy + "-12-30";
            }


            string qry = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue FROM Products " +
                "LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID where ReceiptDetail.Date between '"+datefront.ToString()+"' and '"+dateback.ToString()+"'  and ReceiptDetail.Active = 'Y'" +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 " +
                "ORDER BY Products.TypeName DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);
            adapter.Fill(data);
            dataGridView2.DataSource = data;

            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].Width = 170;
            dataGridView2.Columns[3].Width = 120;
            dataGridView2.Columns[4].Width = 120;
            dataGridView2.Columns[5].Width = 140;
            dataGridView2.Columns[6].Width = 100;
            dataGridView2.Columns[7].Width = 100;

            dataGridView2.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView2.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView2.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView2.Columns["CostPrice"].HeaderText = "ราคาต้นทุน(บาท)";
            dataGridView2.Columns["ProductPrice"].HeaderText = "ราคาขาย(บาท)";
            dataGridView2.Columns["Counts"].HeaderText = "สินค้าที่ขายแล้ว(ชิ้น)";
            dataGridView2.Columns["TotalCost"].HeaderText = "ราคาต้นทุนรวม(บาท)";
            dataGridView2.Columns["TotalRevenue"].HeaderText = "ยอดขายสินค้ารวม(บาท)";

            dataGridView2.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["Counts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DTO.ReportCost> low = new List<DTO.ReportCost>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                float CostPrice = 0;
                float ProductPrice = 0;
                float Counts = 0;
                float TotalCost = 0;
                float TotalRevenue = 0;
                float.TryParse(dataGridView2.Rows[i].Cells[3].Value.ToString(), out CostPrice);
                float.TryParse(dataGridView2.Rows[i].Cells[4].Value.ToString(), out ProductPrice);
                float.TryParse(dataGridView2.Rows[i].Cells[5].Value.ToString(), out Counts);
                float.TryParse(dataGridView2.Rows[i].Cells[6].Value.ToString(), out TotalCost);
                float.TryParse(dataGridView2.Rows[i].Cells[7].Value.ToString(), out TotalRevenue);

                low.Add(new DTO.ReportCost()
                {
                    ProductID = dataGridView2.Rows[i].Cells[0].Value.ToString(),
                    ProductName = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                    ProductType = dataGridView2.Rows[i].Cells[2].Value.ToString(),
                    CostPrice = CostPrice,
                    ProductPrice = ProductPrice,
                    Counts= Counts,
                    TotalCost = TotalCost,
                    TotalRevenue = TotalRevenue

                }); 

            }
            report.Name = "DataSet1";
            report.Value = low;
            using (ModalPage.ProfitReport modal = new ModalPage.ProfitReport(report,datefront,dateback))
            {
                modal.ShowDialog();

            }
        }
    }
}
