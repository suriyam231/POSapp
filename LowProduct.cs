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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Main ss = new Main();
            ss.Show();
        }

        private void LowProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["ProductFrom"].HeaderText = "ซื้อสินค้ามาจาก";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";



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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        }
    }
}
