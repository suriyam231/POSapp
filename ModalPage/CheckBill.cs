using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTiw.ModalPage
{
    public partial class CheckBill : Form
    {
        string textID;
        public string Getvalues
        {
            get
            {
                return "succes";
            }

        }
        public string Getmoney
        {
            get
            {
                return textBox1.Text.ToString();
            }

        }
        public string getLeft
        {
            get
            {
                return change_lab.Text.ToString();
            }

        }
        public CheckBill()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ad(string a)
        {
            string b = a.ToString();
            Total_lab.Text = b.ToString();
        }
        public void keydown(object sender, KeyEventArgs kea)
        {
            string textTotal = Total_lab.Text.ToString();
            string textMoney = textBox1.Text.ToString();

            int Total = 0;
            int Money = 0;
            Int32.TryParse(textTotal, out Total);
            Int32.TryParse(textMoney, out Money);

            int change = 0;
            change = Money - Total;
     
            if (change > 0)
            {
                change_lab.Text = change.ToString();
            }
            else if (change == 0)
            {
                change_lab.Text = change.ToString();
            }
            else if (change < 0)
            {
                change_lab.Text = "ติดลบ";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string a = "succes";
            //Main  main= new Main();
            //main.ad(a.ToString(),textID.ToString());
            
            //this.Close();
        }
        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void Total_lab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string a = "fail";
            //Main main = new Main();
            //main.ad(a.ToString(), textID.ToString());
            //main.button6_Click("ยกเลิก", e);
            //this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                
            }
        }
    }
}
