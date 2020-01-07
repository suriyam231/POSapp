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
            command.CommandText = "select ProductID , ProductName , TypeName, ProductQuantity , ProductFrom from Products where ProductQuantity < "+number+"";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
