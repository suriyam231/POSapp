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

namespace POSTiw.Page
{
    public partial class EditProduct : UserControl
    {
        public EditProduct()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM [dbo].[Products]";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            conn.Open();
            string qry = "SELECT * FROM TypeProduct";

            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();

            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            connn.Open();
            string count = "select COUNT(ProductID) from Products";
            string sum = "select SUM(ProductQuantity) from Products";
            DataTable data2 = new DataTable();
            DataTable data3 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(count, connn);
            SqlDataAdapter adapter3 = new SqlDataAdapter(sum, connn);
            int number = 0;
            int Total = 0;
            adapter2.Fill(data2);
            adapter3.Fill(data3);
            number = data2.Rows[0].Field<int>(0);
            Total = data3.Rows[0].Field<int>(0);


            Total_lab.Text = number.ToString();
            TotalProduct_lab.Text = Total.ToString();

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["Description"].HeaderText = "รายละเอียด";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุน";
            dataGridView1.Columns["ProductFrom"].HeaderText = "ซื้อสินค้ามาจาก";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["Date"].HeaderText = "วันที่เพิ่มสินค้าล่าสุด";

        }

        public void search(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                string values = textBox2.Text.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[Products] WHERE ProductID = '" + values + "'";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                dataGridView1.DataSource = data;


            }
        }
        public void deleteText(object sender, KeyEventArgs kea)
        {

            if (textBox2.Text == "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[Products]";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT * FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox1.Text.ToString() + "%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID_lab.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                PNAME_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PDes_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Pamuont_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Pprice_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Pcost_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Presfer_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Amount = 0;
                float Price = 0;
                float CostPrice = 0;
                Int32.TryParse(Pamuont_txt.Text, out Amount);
                float.TryParse(Pprice_txt.Text, out Price);
                float.TryParse(Pcost_txt.Text, out CostPrice);

                string ID = ID_lab.Text.ToString();
                string Name = PNAME_txt.Text.ToString();
                string Des = PDes_txt.Text.ToString();
                string From = Presfer_txt.Text.ToString();

                if (Amount != 0 && Price != 0 && CostPrice != 0  && Name != null && From != null)
                {
                    string type = comboBox1.SelectedItem.ToString();
                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                    conn.Open();
                    //string qry = "INSERT INTO Products Values('" + ID + "','" + Name + "','" + Des + "'," + Amount + "," + Price + "," + CostPrice + ",'" + From + "','" + type + "','" + DateTime.Now + "')";
                   
                    string update = "UPDATE Products SET ProductName = '"+Name+"',Description = '"+Des+"',ProductQuantity ='"+Amount+"',ProductPrice = '"+Price+"',CostPrice = '"+CostPrice+"',ProductFrom = '"+From+"',TypeName ='"+type+"',Date = '" + DateTime.Now + "' WHERE ProductID = '" + ID + "'";
                    /*(ProductID,ProductName,Description,ProductQuantity,ProductPrice,CostPrice,ProductFrom,TypeID,UpDate)*/
                    SqlDataReader reader = new SqlCommand(update, conn).ExecuteReader();
                    MessageBox.Show("แก้ไขรายละเอียดสินค้า : " + Name + " เรียบร้อยแล้ว");

                    SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                    SqlCommand command = new SqlCommand();
                    command.Connection = connn;
                    command.CommandText = "SELECT * FROM [dbo].[Products]";
                    DataTable data2 = new DataTable();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    adapter2.Fill(data2);
                    dataGridView1.DataSource = data2;
                    ID_lab.Text = null;
                    PNAME_txt.Text = null;
                    PDes_txt.Text = null;
                    Presfer_txt.Text = null;
                    Pamuont_txt.Text = null;
                    Pprice_txt.Text = null;
                    Pcost_txt.Text = null;
                    comboBox1.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มสินค้า");
                }


            }
            catch (SqlException error)
            {
                string ID = ID_lab.Text.ToString();
                MessageBox.Show("มีรหัสสืนค้า : " + ID + " อยู่ในระบบแล้ว ไม่สามารถเพิ่มข้อมูลซ้ำได้");
            }
            catch (NullReferenceException nul)
            {
                MessageBox.Show("กรุณาเลือกประเภทสินค้า");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
