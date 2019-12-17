using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //DataTable dataOrder = new DataTable();
            //dataOrder.Columns.Add("ลำดับ");
            //dataOrder.Columns.Add("รหัสสินค้า");
            //dataOrder.Columns.Add("ชื่อสินค้า");
            //dataOrder.Columns.Add("จำนวนสินค้า");
            //dataOrder.Columns.Add("ราคาต่อหน่วย");
            //dataOrder.Columns.Add("ราคารวม");
            //dataGridView1.DataSource = dataOrder;


            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].Width = 150;
            //dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[3].Width = 110;
            //dataGridView1.Columns[4].Width = 110;
            //dataGridView1.Columns[5].Width = 110;
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int billID = 0;
            string RID =null;
            string amount=null;
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

            string check = "select COUNT(ReceiptID) from ReceiptDetail where Active = 'N'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(check, connn);
            adapter.Fill(data);
            if (data.Rows[0][0].ToString() == "0")
            {
                Random rand = new Random();
                billID = rand.Next(000000000, 999999999);
            }
            else if (data.Rows[0][0].ToString() == "1")
            {
                string getRID = "select ReceiptID ,Amount from ReceiptDetail where Active = 'N'";
                DataTable dataRID = new DataTable();
                SqlDataAdapter adapterRID = new SqlDataAdapter(getRID, connn);
                adapterRID.Fill(dataRID);
                RID = dataRID.Rows[0][0].ToString();
                amount = dataRID.Rows[0][1].ToString();
            }
            string ReceiptID = billID.ToString();
            string getProduct = "Select * from Products where ProductID = '" + textBox1.Text.ToString() + "'";
            SqlDataAdapter adapterGet = new SqlDataAdapter(getProduct, connn);
            DataTable Product = new DataTable();
            adapterGet.Fill(Product);
            string ProductID = Product.Rows[0][0].ToString();
            string ProductName = Product.Rows[0][1].ToString();
            string ProductPrice = Product.Rows[0][4].ToString();

            string Active = "N";
            int Price;
            Int32.TryParse(ProductPrice, out Price);
            if (ReceiptID != "0")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                conn.Open();
                string insert = "INSERT ReceiptDetail Values('" + ProductID + "','" + ReceiptID + "'," + Price + "," + 1 + ",'" + Active + "')";
                SqlDataReader reader = new SqlCommand(insert, conn).ExecuteReader();
            }
            else if (ReceiptID == "0")
            {
                int x;
                Int32.TryParse(amount, out x);
                x = x + 1;
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                conn.Open();
                string updateAmout = "UPDATE ReceiptDetail SET Amount = "+x+ " WHERE ProductID = '" + ProductID + "' and ReceiptID = '"+RID+"'";
                SqlDataReader reader = new SqlCommand(updateAmout, conn).ExecuteReader();
                ReceiptID = RID;
            }

            string order = "SELECT Products.ProductID, Products.ProductName,ReceiptDetail.ReceiptPrice , ReceiptDetail.Amount ,ReceiptDetail.Amount*ReceiptDetail.ReceiptPrice AS Total FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID Where ReceiptID = '" + ReceiptID + "'";
            DataTable dataOrder = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(order, connn);
            adapter2.Fill(dataOrder);
            dataGridView1.DataSource = dataOrder;
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["ReceiptPrice"].HeaderText = "ราคาต่อหน่วย";
            dataGridView1.Columns["Amount"].HeaderText = "จำนวน";
            dataGridView1.Columns["Total"].HeaderText = "รวมราคา";

          
            dataGridView1.Columns[0].Width = 190;
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;

            //DataTable dataOrder = new DataTable();
            //dataOrder.Columns.Add("ลำดับ");
            //dataOrder.Columns.Add("รหัสสินค้า");
            //dataOrder.Columns.Add("ชื่อสินค้า");
            //dataOrder.Columns.Add("จำนวนสินค้า");
            //dataOrder.Columns.Add("ราคาต่อหน่วย");
            //dataOrder.Columns.Add("ราคารวม");

            //dataOrder.Rows.Add(1, ProductID, ProductName, 0, ProductPrice,0*Price);
            //dataGridView1.DataSource = dataOrder;
            //string CheckID = dataOrder.Rows[0][1].ToString();
            //int  ;
            //if (CheckID == ProductID)
            //{
            //    i = i+1;
            //    dataOrder.Rows[0][3] = +i;

            //}




            ///8850987128400
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warehouse ss = new Warehouse();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT ProductID , ProductName , ProductQuantity , ProductPrice FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox2.Text.ToString() + "%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView2.DataSource = data;
            dataGridView2.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView2.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView2.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
            dataGridView2.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView2.Columns[2].Width = 105;
            dataGridView2.Columns[3].Width = 100;
        }

        private void Main_Load(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}
