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

namespace POSTiw
{
    public partial class TypeProduct : UserControl
    {
        public TypeProduct()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TypeName FROM [dbo].[TypeProduct]";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            button2.Hide();
            button3.Hide();
            label5.Hide();
        }

        private void TypeProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
             dataGridView1.Columns[0].Width = 230;

            dataGridView1.Font = new Font("TH SarabunPSK,style=Bold", 16F,GraphicsUnit.Pixel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = textBox1.Text.ToString();
            if (TypeName != "")
            {
                SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                connn.Open();
                string count = "select COUNT(TypeID) from TypeProduct";
                DataTable data2 = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter(count, connn);
                int number;
                adapter2.Fill(data2);
                number = 1 + data2.Rows[0].Field<int>(0);
                string indext;

                indext =  number.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                string qry = "INSERT INTO TypeProduct Values('" + indext + "','" + TypeName + "')";
                SqlDataReader reader = new SqlCommand(qry, connn).ExecuteReader();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT TypeName FROM [dbo].[TypeProduct]";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                MessageBox.Show("เพิ่มประเภทสินค้า : " + TypeName + " เรียบร้อยแล้ว");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("กรุณากรอกชื่อประเภทสินค้าที่ต้องการเพิ่ม");
            }
        }

        public void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                connn.Open();
                string count = "select TypeID from TypeProduct Where TypeName = '"+textBox1.Text.ToString()+"'";
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(count, connn);
                string index;
                adapter.Fill(data);
                index = data.Rows[0].Field<string>(0);
                label5.Text = index;
                button1.Hide();
                button2.Show();
                button3.Show();

                
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าประเภทสินค้าที่ต้องการแก้ไข");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            connn.Open();
            string count = "select TypeID from TypeProduct Where TypeName = '" + textBox1.Text.ToString() + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(count, connn);
             string index;
            adapter.Fill(data);
            index = data.Rows[0].Field<string>(0);

            string delete = "delete TypeProduct where TypeID = '" + index + "'";
          
            SqlDataReader reader = new SqlCommand(delete, connn).ExecuteReader();
            MessageBox.Show("ลบประเภทสินค้า : " + textBox1.Text.ToString() + " เรียบร้อยแล้ว") ;
            SqlCommand command = new SqlCommand();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            command.Connection = conn;
            command.CommandText = "SELECT TypeName FROM [dbo].[TypeProduct]";
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter2.Fill(data2);
            dataGridView1.DataSource = data2;
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            button1.Show();
            button2.Hide();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            connn.Open();
            string index = label5.Text.ToString();
            string TypeName = textBox1.Text.ToString();

            string delete = "Update TypeProduct Set TypeName = '"+TypeName+"' Where TypeID = '"+index+"'";

            SqlDataReader reader = new SqlCommand(delete, connn).ExecuteReader();
            MessageBox.Show("แก้ไขประเภทสินค้า : " + textBox1.Text.ToString() + " เรียบร้อยแล้ว");
            SqlCommand command = new SqlCommand();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            command.Connection = conn;
            command.CommandText = "SELECT TypeName FROM [dbo].[TypeProduct]";
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter2.Fill(data2);
            dataGridView1.DataSource = data2;
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
