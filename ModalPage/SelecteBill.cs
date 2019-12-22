using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace POSTiw.ModalPage
{
    public partial class SelecteBill : Form
    {
        string textID;
        public string Getvalues
        {
            get
            {
                return textID;
            }

        }
        public SelecteBill()
        {
            InitializeComponent();
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "select ReceiptID, NamePause from  PauseBill";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Columns["ReceiptID"].HeaderText = "เลขที่ใบสั่งซื้อ";
            dataGridView1.Columns["NamePause"].HeaderText = "ชิ้อ";
        }

        private void SelecteBill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show("กรุณาคลิกที่ข้างหน้าช่อง");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            conn.Open();
            string qry = "Delete PauseBill where ReceiptID = '" + textID + "'";
            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            conn.Close();
            conn.Open();
            string qry1 = "Delete Receipt where ReceiptID = '" + textID + "'";
            SqlDataReader reader1 = new SqlCommand(qry1, conn).ExecuteReader();
            conn.Close();
            conn.Open();
            string qry3 = "Delete ReceiptDetail where ReceiptID = '" + textID + "'";
            SqlDataReader reader3 = new SqlCommand(qry3, conn).ExecuteReader();
            conn.Close();
        }
    }
}
