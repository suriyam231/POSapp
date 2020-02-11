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
    public partial class ReportSale : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

        public ReportSale()
        {
            InitializeComponent();
            dayReport1.Show();
            monthReport1.Hide();
            yearReport1.Hide();
            threeMonthsResport1.Hide();

            string years = DateTime.Now.Year.ToString();
            int oldYear;
            Int32.TryParse(years, out oldYear);


            string qry = "Delete Receipt where ReceiptDate  between '" + (oldYear-4).ToString() + "-01-01' and '" + (oldYear - 4).ToString() + "-12-31' ";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(qry, sqlcon);

            string qry2 = "Delete ReceiptDetail where Date  between '" + (oldYear - 4).ToString() + "-01-01' and '" + (oldYear - 4).ToString() + "-12-31' ";
            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(qry2, sqlcon);


        }
        public void ad(string Username)
        {
            label1.Text = Username.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Main ss = new Main();
            string Username = label1.Text.ToString();
            ss.ad(Username.ToString());
            this.Close();
            ss.Show();
        }

        private void ReportSale_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dayReport1.BringToFront();
            dayReport1.Show();
            monthReport1.Hide();
            yearReport1.Hide();
            threeMonthsResport1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthReport1.BringToFront();
            dayReport1.Hide();
            monthReport1.Show();
            yearReport1.Hide();
            threeMonthsResport1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yearReport1.BringToFront();
            dayReport1.Hide();
            monthReport1.Hide();
            yearReport1.Show();
            threeMonthsResport1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            threeMonthsResport1.BringToFront();
            dayReport1.Hide();
            monthReport1.Hide();
            yearReport1.Hide();
            threeMonthsResport1.Show();
        }
    }
}
