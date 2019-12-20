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
    public partial class PauseBill : Form
    {
        public string Getvalues
        {
            get
            {
                return textBox1.Text.ToString();
            }

        }
        public PauseBill()
        {
            InitializeComponent();
        }

        private void PauseBill_Load(object sender, EventArgs e)
        {

        }
        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
