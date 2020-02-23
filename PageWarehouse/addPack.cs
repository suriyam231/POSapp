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
    public partial class addPack : Form
    {
        SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

        int Packs;
        int Addnumber;
        string ProPackID;
        int Amounts;
        public addPack(int Pack , String Number , string PackID , int Amount)
        {
            InitializeComponent();
            Packs = Pack;
            Int32.TryParse(Number, out Addnumber);
            label2.Text = (Packs * Addnumber).ToString();
            ProPackID = PackID;
            Amounts = Amount;
        }

        private void addPack_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getProduct = "Select * from Products where ProductID = '" + textBox1.Text.ToString() + "'";
            SqlDataAdapter adapterGet = new SqlDataAdapter(getProduct, connn);
            DataTable Product = new DataTable();
            adapterGet.Fill(Product);
            string ProductID = Product.Rows[0][0].ToString();
            string ProductName = Product.Rows[0][1].ToString();
            int ProductPrice;
            Int32.TryParse(Product.Rows[0][3].ToString(), out ProductPrice);

            if (ProductID != ProPackID)
            {
                int Total = 0;
                Total = ProductPrice + (Packs * Addnumber);

                string update = "UPDATE Products SET ProductQuantity = '" + Total + "',Date = '" + DateTime.Now + "' WHERE ProductID = '" + ProductID + "'";
                connn.Open();

                SqlDataReader reader = new SqlCommand(update, connn).ExecuteReader();
                MessageBox.Show("เพิ่มจำนวนสินค้า : " + ProductName + "เป็นจำนวน : " + Total + " เรียบร้อยแล้ว");
                connn.Close();
                int Totals = Amounts - Addnumber ;

                string update2 = "UPDATE Products SET ProductQuantity = '" + Totals + "',Date = '" + DateTime.Now + "' WHERE ProductID = '" + ProPackID + "'";
                connn.Open();
                SqlDataReader reader2 = new SqlCommand(update2, connn).ExecuteReader();
                this.Close();
            }
           

        }

        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter && textBox1.Text.ToString() != "")
            {
                button1.PerformClick();

            }

        }
    }
}
