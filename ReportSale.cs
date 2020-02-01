using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class ReportSale : Form
    {
        public ReportSale()
        {
            InitializeComponent();
            dayReport1.Show();
            monthReport1.Hide();
            yearReport1.Hide();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthReport1.BringToFront();
            dayReport1.Hide();
            monthReport1.Show();
            yearReport1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yearReport1.BringToFront();
            dayReport1.Hide();
            monthReport1.Hide();
            yearReport1.Show();
        }
    }
}
