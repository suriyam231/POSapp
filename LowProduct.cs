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
    public partial class LowProduct : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        ReportDataSource report = new ReportDataSource();
        public LowProduct()
        {
            InitializeComponent();
            textBox1.Text = "10";
            int number = 0;
            Int32.TryParse(textBox1.Text.ToString(), out number);

            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "select ProductID , ProductName , TypeName, ProductQuantity , ProductFrom from Products where ProductQuantity <= "+number+ " ORDER BY ProductQuantity";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            sqlcon.Open();
            string qry = "SELECT * FROM TypeProduct";

            SqlDataReader reader = new SqlCommand(qry, sqlcon).ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(1).ToString());
            }
            sqlcon.Close();


        }
        public void ad(string Username)
        {
            label10.Text = Username.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main ss = new Main();
            string Username = label10.Text.ToString();
            ss.ad(Username.ToString());
            this.Close();
            ss.Show();
        }

        private void LowProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["ProductFrom"].HeaderText = "ซื้อสินค้ามาจาก";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";

            dataGridView1.Columns["ProductQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;


            LaId.Hide();
            LaName.Hide();
            LaQu.Hide();
            LaType.Hide();
            LaType2.Hide();
            LaUp.Hide();
            LaInput.Hide();
            Labutton.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                LaId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                LaName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                LaQu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null)
            {
                SqlCommand command = new SqlCommand();
                int number = 0;
                Int32.TryParse(textBox1.Text.ToString(), out number);
                command.Connection = sqlcon;
                command.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM Products WHERE ProductQuantity <= " + number + " ORDER BY ProductQuantity ";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.SelectedItem != null)
            {
                try
                {
                    SqlCommand command2 = new SqlCommand();
                    command2.Connection = sqlcon;
                    command2.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM [dbo].[Products] WHERE TypeName = '" + comboBox1.SelectedItem.ToString() + "' and ProductQuantity <= " + textBox1.Text.ToString() + "  ORDER BY ProductQuantity";

                    DataTable data2 = new DataTable();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

                    adapter2.Fill(data2);
                    dataGridView1.DataSource = data2;
                }
                catch(Exception er)
                {

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = comboBox1.SelectedItem.ToString();
            int number = 0;
            Int32.TryParse(textBox1.Text.ToString(), out number);
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM [dbo].[Products] WHERE TypeName = '" + values + "' and ProductQuantity <= "+number+ "  ORDER BY ProductQuantity";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
        public void Onkey(object sender, KeyEventArgs kea)
        {

            if (comboBox1.SelectedItem == null)
            {
                int number = 0;
                Int32.TryParse(textBox1.Text.ToString(), out number);
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcon;
                command.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM Products WHERE ProductQuantity <= " + number + " ORDER BY ProductQuantity ";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                dataGridView1.DataSource = data;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaId.Show();
            LaName.Show();
            LaQu.Show();
            LaType.Show();
            LaType2.Show();
            LaUp.Show();
            LaInput.Show();
            Labutton.Show();
            label7.Show();
            label8.Show();
            label9.Show();
        }

        private void Labutton_Click(object sender, EventArgs e)
        {
            string ID = LaId.Text.ToString();
            string Name = LaName.Text.ToString();
            int addAmuont;
            Int32.TryParse(LaInput.Text, out addAmuont);
            if (ID != null && addAmuont != 0)
            {

                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                conn.Open();
                int number;
                Int32.TryParse(LaQu.Text.ToString(), out number);
                int Total = 0;
                Total = number + addAmuont;



                string update = "UPDATE Products SET ProductQuantity = '" + Total + "',Date = '" + DateTime.Now + "' WHERE ProductID = '" + ID + "'";


                SqlDataReader reader = new SqlCommand(update, conn).ExecuteReader();
                MessageBox.Show("เพิ่มจำนวนสินค้า : " + Name + "เป็นจำนวน : " + Total + " เรียบร้อยแล้ว");

                SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                SqlCommand command = new SqlCommand();
                command.Connection = connn;
                if(comboBox1.SelectedItem == null)
                {
                    command.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM [dbo].[Products] WHERE  ProductQuantity <= " + textBox1.Text.ToString() + "  ORDER BY ProductQuantity";

                }
                else if(comboBox1.SelectedItem != null)
                {
                    command.CommandText = "SELECT ProductID , ProductName , TypeName, ProductQuantity , ProductFrom FROM [dbo].[Products] WHERE TypeName = '" + comboBox1.SelectedItem.ToString() + "' and ProductQuantity <= " + textBox1.Text.ToString() + "  ORDER BY ProductQuantity";

                }
                DataTable data2 = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                adapter2.Fill(data2);
                dataGridView1.DataSource = data2;
                LaId.Text = null;
                LaName.Text = null;
                LaQu.Text = null;
                LaInput.Text = null;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มสินค้า");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DTO.ProductLow> low = new List<DTO.ProductLow>();
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                low.Add(new DTO.ProductLow()
                {
                    ProductID = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    ProductName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    ProductType = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    ProductFrom = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    ProductAmount = dataGridView1.Rows[i].Cells[3].Value.ToString(),

                });

            }
            report.Name = "DataSet1";
            report.Value = low;
            using (ModalPage.ProductLowModal modal = new ModalPage.ProductLowModal(report))
            {
                modal.ShowDialog();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
