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
    public partial class สินค้าขายดี : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        ReportDataSource report = new ReportDataSource();
        string daySet = "-7";
        public สินค้าขายดี()
        {
            InitializeComponent();
            dataGridView2.Hide();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID WHERE ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y' " +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Counts DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int num;
                Int32.TryParse(Value,out num);
                Total = Total + num;
            }
            chart1.Titles.Add("สินค้าขายดีตามประเภทสินค้า");

            sqlcon.Open();
            SqlCommand command2 = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "Select TypeName from TypeProduct";

            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

            adapter.Fill(data2);
            dataGridView2.DataSource = data2;

            for (int i = 0; i < dataGridView2.Rows.Count -1; i++)
            {
                string type = dataGridView2.Rows[i].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand commandType = new SqlCommand();
                commandType.Connection = conn;
                commandType.CommandText = "SELECT  SUM(ReceiptDetail.Amount) as Counts  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where TypeName = '"+type+ "' and ReceiptDetail.Active = 'Y' and ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE()";
                DataTable dataType = new DataTable();
                SqlDataAdapter adapterType = new SqlDataAdapter(commandType);
                adapterType.Fill(dataType);
                string numtxt = dataType.Rows[0][0].ToString();
                int number = 0;
                Int32.TryParse(numtxt, out number);

                int persen = 0;
                persen = (number * 100) / Total;
                if(number != 0)
                {
                    chart1.Series["s1"].Points.AddXY(type, persen);
                }
                
            }


 
            string qry = "SELECT * FROM TypeProduct";

            SqlDataReader reader = new SqlCommand(qry, sqlcon).ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(1).ToString());
            }
            sqlcon.Close();

            //chart1.Series["s1"].Points.AddXY("เครื่องดื่ม", "20");
            //chart1.Series["s1"].Points.AddXY("สุราและบุหรี่", "20");
            //chart1.Series["s1"].Points.AddXY("สินค้าอุปโภคและของใช้ภายในบ้าน", "20");
            //chart1.Series["s1"].Points.AddXY("อาหารสด", "10");
            //chart1.Series["s1"].Points.AddXY("เครื่องปรุง", "10");
            //chart1.Series["s1"].Points.AddXY("ขนมขบเคี้ยว", "10");
            //chart1.Series["s1"].Points.AddXY("เครื่องเขียน", "10");
        }
        public void ad(string Username)
        {
            label5.Text = Username.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Main ss = new Main();
            string Username = label5.Text.ToString();
            ss.ad(Username.ToString());
            this.Close();
            ss.Show();
        }

        private void PopularProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุน";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "สินค้าคงเหลือ";
            dataGridView1.Columns["Counts"].HeaderText = "สินค้าที่ขายแล้ว";

            dataGridView1.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Counts"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[6].Width = 110;

            dataGridView3.Columns["Column5"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[0].Width = 100;
            dataGridView3.Columns[1].Width = 120;
            dataGridView3.Columns[2].Width = 170;
            dataGridView3.Columns[3].Width = 100;
            dataGridView3.Columns[4].Width = 100;

        }

        private void Labutton_Click(object sender, EventArgs e)
        {
            this.daySet = "-7";
            chart1.Titles.Clear();
            chart1.Series["s1"].Points.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID  WHERE ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y' " +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Counts DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int num;
                Int32.TryParse(Value, out num);
                Total = Total + num;
            }
            chart1.Titles.Add("สินค้าขายดีตามประเภทสินค้า");

      
            SqlCommand command2 = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "Select TypeName from TypeProduct";

            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

            adapter.Fill(data2);
            dataGridView2.DataSource = data2;

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string type = dataGridView2.Rows[i].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand commandType = new SqlCommand();
                commandType.Connection = conn;
                commandType.CommandText = "SELECT  SUM(ReceiptDetail.Amount) as Counts  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where TypeName = '" + type + "' and ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y'";
                DataTable dataType = new DataTable();
                SqlDataAdapter adapterType = new SqlDataAdapter(commandType);
                adapterType.Fill(dataType);
                string numtxt = dataType.Rows[0][0].ToString();
                int number = 0;
                Int32.TryParse(numtxt, out number);

                int persen = 0;
                
                if (number != 0)
                {
                    try
                    {
                        persen = (number * 100) / Total;
                        chart1.Series["s1"].Points.AddXY(type, persen);
                    }
                    catch(Exception x)
                    {

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.daySet = "-30";
            chart1.Titles.Clear();
            chart1.Series["s1"].Points.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID  WHERE ReceiptDetail.Date between DateAdd(DD,-30,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y' " +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Counts DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int num;
                Int32.TryParse(Value, out num);
                Total = Total + num;
            }
            chart1.Titles.Add("สินค้าขายดีตามประเภทสินค้า");


            SqlCommand command2 = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "Select TypeName from TypeProduct";

            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

            adapter.Fill(data2);
            dataGridView2.DataSource = data2;

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string type = dataGridView2.Rows[i].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand commandType = new SqlCommand();
                commandType.Connection = conn;
                commandType.CommandText = "SELECT  SUM(ReceiptDetail.Amount) as Counts  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where TypeName = '" + type + "' and ReceiptDetail.Date between DateAdd(DD,-30,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y'";
                DataTable dataType = new DataTable();
                SqlDataAdapter adapterType = new SqlDataAdapter(commandType);
                adapterType.Fill(dataType);
                string numtxt = dataType.Rows[0][0].ToString();
                int number = 0;
                Int32.TryParse(numtxt, out number);

                int persen = 0;
                
                if (number != 0)
                {
                    persen = (number * 100) / Total;
                    chart1.Series["s1"].Points.AddXY(type, persen);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.daySet = "-90";
            chart1.Titles.Clear();
            chart1.Series["s1"].Points.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID  WHERE ReceiptDetail.Date between DateAdd(DD,-90,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y'" +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Counts DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                int num;
                Int32.TryParse(Value, out num);
                Total = Total + num;
            }
            chart1.Titles.Add("สินค้าขายดีตามประเภทสินค้า");


            SqlCommand command2 = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "Select TypeName from TypeProduct";

            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

            adapter.Fill(data2);
            dataGridView2.DataSource = data2;

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string type = dataGridView2.Rows[i].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand commandType = new SqlCommand();
                commandType.Connection = conn;
                commandType.CommandText = "SELECT  SUM(ReceiptDetail.Amount) as Counts  FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where TypeName = '" + type + "' and ReceiptDetail.Date between DateAdd(DD,-90,GETDATE() ) and GETDATE() and ReceiptDetail.Active = 'Y'";
                DataTable dataType = new DataTable();
                SqlDataAdapter adapterType = new SqlDataAdapter(commandType);
                adapterType.Fill(dataType);
                string numtxt = dataType.Rows[0][0].ToString();
                int number = 0;
                Int32.TryParse(numtxt, out number);

                int persen = 0;

                if (number != 0)
                {
                    persen = (number * 100) / Total;
                    chart1.Series["s1"].Points.AddXY(type, persen);
                }

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.productID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch( Exception s)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการเพิ่มในรายการ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = comboBox1.SelectedItem.ToString();
            int day = 0;
            Int32.TryParse(this.daySet, out day);

            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID  WHERE ReceiptDetail.Date between DateAdd(DD,"+day+",GETDATE() ) and GETDATE() and Products.TypeName = '"+values+ "' and ReceiptDetail.Active = 'Y'" +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 0 ORDER BY Counts DESC";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }


        string productID = null;
        string productName = null;
        string productType = null;
        string productFrom = null;
        string productAmount = null;
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "Select * from Products where ProductID = '" + this.productID + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            productName = data.Rows[0][1].ToString();
            productType = data.Rows[0][7].ToString();
            productFrom = data.Rows[0][6].ToString();
            productAmount = data.Rows[0][3].ToString();

            DataTable dataOrder = new DataTable();
            dataOrder.Columns.Add("ProductID");
            dataOrder.Columns.Add("ProductName");
            dataOrder.Columns.Add("ProductType");
            dataOrder.Columns.Add("ProductFrom");
            dataOrder.Columns.Add("ProductAmount");

            DataRow row = dataOrder.NewRow();
            int index = dataGridView3.Rows.Count;
            row["ProductID"] = productID;
            row["ProductName"] = productName;
            row["ProductType"] = productType;
            row["ProductFrom"] = productFrom;
            row["ProductAmount"] = productAmount;

            dataOrder.Rows.Add(row);

            foreach (DataRow Drow in dataOrder.Rows)
            {
                int num = dataGridView3.Rows.Add();
                int x = num;
                int y = num;
                string text = null;
                if (num > 0)
                {
                    x = num - 1;
                    text = dataGridView3.Rows[x].Cells[0].Value.ToString();
                    for (int i = 1; i <= num; i++)
                    {
                        x = num - i;
                        text = dataGridView3.Rows[x].Cells[0].Value.ToString();
                        if (productID == text)
                        {
                            dataGridView3.Rows.Remove(dataGridView3.Rows[num]);
                            break;

                        }
                    }

                }
                if (productID != text)
                {
                    dataGridView3.Rows[num].Cells[0].Value = Drow["ProductID"].ToString();
                    dataGridView3.Rows[num].Cells[1].Value = Drow["ProductName"].ToString();
                    dataGridView3.Rows[num].Cells[2].Value = Drow["ProductType"].ToString();
                    dataGridView3.Rows[num].Cells[3].Value = Drow["ProductFrom"].ToString();
                    dataGridView3.Rows[num].Cells[4].Value = Drow["ProductAmount"].ToString();
                }
               

            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DTO.ProductLow> low = new List<DTO.ProductLow>();
            for (int i = 0; i < dataGridView3.Rows.Count-1; i++)
            {
               
                low.Add(new DTO.ProductLow()
                {
                    ProductID = dataGridView3.Rows[i].Cells[0].Value.ToString(),
                    ProductName = dataGridView3.Rows[i].Cells[1].Value.ToString(),
                    ProductType = dataGridView3.Rows[i].Cells[2].Value.ToString(),
                    ProductFrom = dataGridView3.Rows[i].Cells[3].Value.ToString(),
                    ProductAmount = dataGridView3.Rows[i].Cells[4].Value.ToString(),

                }); 

            }
            report.Name = "DataSet1";
            report.Value = low;
            using (ModalPage.ProductLowModal modal = new ModalPage.ProductLowModal(report))
            {
                modal.ShowDialog();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                 dataGridView3.Rows.RemoveAt(this.dataGridView3.SelectedRows[0].Index);
    
            }
        }
    }
}
