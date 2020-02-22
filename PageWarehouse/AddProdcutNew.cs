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
using System.Timers;
namespace POSTiw
{
    public partial class AddProdcutNew : UserControl
    {
        public AddProdcutNew()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

            conn.Open();
            string qry = "SELECT * FROM TypeProduct";

            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
            PID_txt.MaxLength = 30;
            PNAME_txt.MaxLength = 30;
            PDes_txt.MaxLength = 50;
            Presfer_txt.MaxLength = 50;
        }

        private void AddProdcutNew_Load(object sender, EventArgs e)
        {

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
                
                string ID = PID_txt.Text.ToString();
                string Name = PNAME_txt.Text.ToString();
                string Des = PDes_txt.Text.ToString();
                string From = Presfer_txt.Text.ToString();

                if (Amount != 0 && Price != 0 && CostPrice != 0 && ID != "" && Name != null && From != null)
                {
                    string type = comboBox1.SelectedItem.ToString();
                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                    conn.Open();
                    string qry = "INSERT INTO Products Values('" + ID + "','" + Name + "','" + Des + "'," + Amount + "," + Price + "," + CostPrice + ",'" + From + "','" + type + "','" + DateTime.Now + "')";

                    /*(ProductID,ProductName,Description,ProductQuantity,ProductPrice,CostPrice,ProductFrom,TypeID,UpDate)*/
                    SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                    MessageBox.Show("เพิ่มสินค้า : " + Name + "จำนวน : " + Amount + " เรียบร้อยแล้ว");

                    PID_txt.Text = null;
                    PNAME_txt.Text = null;
                    PDes_txt.Text = null;
                    Presfer_txt.Text = null;
                    Pamuont_txt.Text = null;
                    Pprice_txt.Text = null;
                    Pcost_txt.Text = null;
                    comboBox1.SelectedItem = null;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มสินค้า");
                }

               
            }
            catch(SqlException error)
            {
                string ID = PID_txt.Text.ToString();
                MessageBox.Show("มีรหัสสืนค้า : "+ID+" อยู่ในระบบแล้ว ไม่สามารถเพิ่มข้อมูลซ้ำได้");
            }
            catch(NullReferenceException nul)
            {
                MessageBox.Show("กรุณาเลือกประเภทสินค้า");
            }
           
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
