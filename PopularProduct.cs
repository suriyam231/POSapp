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

        public สินค้าขายดี()
        {
            InitializeComponent();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlcon;
            command.CommandText = "SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity,SUM(ReceiptDetail.Amount) as Counts FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID " +
                "GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity HAVING SUM(ReceiptDetail.Amount) > 10 ORDER BY Counts DESC";
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

        private void PopularProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุนสินค้า";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขายสินค้า";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "สินค้าคงเหลือ";
            dataGridView1.Columns["Counts"].HeaderText = "จำนวนสินค้าที่ขายแล้ว";




            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[6].Width = 150;

        }
    }
}
