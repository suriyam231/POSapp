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
    public partial class Warehouse : Form
    {

        public Warehouse()
        {
            InitializeComponent();

            addProdcutNew1.Hide();
            typeProduct1.Hide();
            editProduct1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProdcutNew1.Hide();
            typeProduct1.Hide();
            editProduct1.Hide();
            addQuantity1.Show();
            addQuantity1.BringToFront();

        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addQuantity1.Hide();
            typeProduct1.Hide();
            editProduct1.Hide();
            addProdcutNew1.Show();
            addProdcutNew1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            addQuantity1.Hide();
            addProdcutNew1.Hide();
            typeProduct1.Hide();
            editProduct1.Show();
            editProduct1.BringToFront();

             


        }

        private void button4_Click(object sender, EventArgs e)
        {
            addQuantity1.Hide();
            addProdcutNew1.Hide();
            editProduct1.Hide();
            typeProduct1.Show();
            typeProduct1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Main ss = new Main();
            ss.Show();
        }
    }
}
