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

namespace POSTiw.PageWarehouse
{
    public partial class ShareProduct : Form
    {
        SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

        public ShareProduct()
        {
            InitializeComponent();
        }

        private void ShareProduct_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT ProductID , ProductName , ProductQuantity , ProductPrice FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox1.Text.ToString() + "%' or ProductID LIKE '%" + textBox1.Text.ToString() + "%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView2.DataSource = data;
            dataGridView2.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView2.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView2.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
            dataGridView2.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView2.Columns[1].Width = 155;
            dataGridView2.Columns[2].Width = 50;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns["ProductQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        string ProductID;
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                ProductID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                label6.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                label4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                try
                {
                    string qry = "SELECT ProductQuantity , Description FROM Products WHERE ProductID = '" + ProductID + "'";



                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, connn);
                    int number = 0;
                    adapter.Fill(data);
                    number = data.Rows[0].Field<int>(0);
                    int addnumber;
                    Int32.TryParse(textBox2.Text.ToString(), out addnumber);
                    int Packnumber;
                    Int32.TryParse(data.Rows[0][1].ToString().Substring(5), out Packnumber);
                    int index = label6.Text.Length - 6;
                    string ProductName = label6.Text.Substring(0, index).ToString();

                    string qry1 = "SELECT *  FROM Products WHERE ProductName = '" + ProductName + "'";

                    DataTable data1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter(qry1, connn);
                    int numbe1r = 0;
                    adapter1.Fill(data1);

                    string ProductID2 = data1.Rows[0][0].ToString();
                    int ProductAmount;
                    Int32.TryParse(data1.Rows[0][3].ToString(), out ProductAmount);
                    connn.Open();
                    int Totals = ProductAmount + (Packnumber * addnumber);
                    string ChangPack = "UPDATE Products SET ProductQuantity = '" + Totals + "', Date = '" + DateTime.Now + "' WHERE ProductID = '" + ProductID2 + "'";
                    SqlDataReader PackUdate = new SqlCommand(ChangPack, connn).ExecuteReader();
                    connn.Close();
                    connn.Open();
                    int piece = data.Rows[0].Field<int>(0);
                    int Total = piece - addnumber;
                    string upPack = "UPDATE Products SET ProductQuantity = '" + Total + "', Date = '" + DateTime.Now + "' WHERE ProductID = '" + ProductID + "'";
                    SqlDataReader Update = new SqlCommand(upPack, connn).ExecuteReader();
                    MessageBox.Show("เพิ่มจำนวนสินค้า : " + ProductName + "เป็นจำนวน : " + Totals + " เรียบร้อยแล้ว");
                    connn.Close();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connn;
                    command.CommandText = "SELECT ProductID , ProductName , ProductQuantity , ProductPrice FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox1.Text.ToString() + "%' or ProductID LIKE '%" + textBox1.Text.ToString() + "%'";
                    DataTable data2 = new DataTable();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    adapter2.Fill(data2);
                    dataGridView2.DataSource = data2;
                    dataGridView2.Columns["ProductID"].HeaderText = "รหัสสินค้า";
                    dataGridView2.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
                    dataGridView2.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
                    dataGridView2.Columns["ProductPrice"].HeaderText = "ราคาขาย";
                    dataGridView2.Columns[1].Width = 155;
                    dataGridView2.Columns[2].Width = 50;
                    dataGridView2.Columns[3].Width = 100;
                    dataGridView2.Columns["ProductQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView2.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    label6.Text = "";
                    label4.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                }catch(Exception ex)
                {
                    MessageBox.Show("กรุณาเลือกสินค้าที่เป็นแพ็ค");
                }
            }
        }
    }
}
