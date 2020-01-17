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

namespace POSTiw.ModalPage
{
    public partial class EditStore : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        string StoreID;
        public EditStore()
        {
            InitializeComponent();
             string Text = "Select * from Store";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Text, conn);
            adapter.Fill(data);
            this.StoreID = data.Rows[0][0].ToString();
            textBox1.Text = data.Rows[0][1].ToString();
            textBox2.Text = data.Rows[0][2].ToString();
            textBox3.Text = data.Rows[0][3].ToString();

        }

        private void EditStore_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            conn.Open();
            string qry = "UPDATE Store SET StoreName = '"+textBox1.Text.ToString()+"' ,Location = '"+textBox2.Text.ToString()+"', Owner ='"+textBox3.Text.ToString()+"' where StoreID = '"+this.StoreID+"'";
            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            MessageBox.Show("บันทึกข้อมูลร้าน" + textBox1.Text.ToString() + "เรียบร้อยแล้ว");
            conn.Close();

            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
