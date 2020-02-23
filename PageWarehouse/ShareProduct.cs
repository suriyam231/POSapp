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
           

        }
        string ProductID;
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
               
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            Int32.TryParse(textBox2.Text.ToString(), out number);
            if (ProductPrice >= number)
            {
                using (addPack addPack = new addPack(Decription, textBox2.Text.ToString(), ProductID, ProductPrice))
                {
                    addPack.ShowDialog();
                    label10.Text = "";
                    label12.Text = "";
                    label16.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("จำนวนสินค้าไม่เพียงพอ");
            }
           
        }
        int ProductPrice;
        int Decription;
        
        private void Labutton_Click(object sender, EventArgs e)
        {
            string getProduct = "Select * from Products where ProductID = '" + textBox1.Text.ToString() + "'";
            SqlDataAdapter adapterGet = new SqlDataAdapter(getProduct, connn);
            DataTable Product = new DataTable();
            adapterGet.Fill(Product);
            ProductID = Product.Rows[0][0].ToString();
            string ProductName = Product.Rows[0][1].ToString();
            Int32.TryParse(Product.Rows[0][3].ToString(), out ProductPrice);
            Int32.TryParse(Product.Rows[0][2].ToString().Substring(5),out Decription);
            label10.Text = ProductName;
            label12.Text = ProductPrice.ToString();
            label16.Text = Decription.ToString();

        }
        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter && textBox1.Text.ToString() != "")
            {
                Labutton.PerformClick();
            }
        }
        public void OnkeyPack(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter && textBox1.Text.ToString() != "")
            {
                button1.PerformClick();
            }
        }
    }
}
