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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            edituser.Show();
            edituser.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edituser.Hide();
            adduser.Show();
            adduser.BringToFront();

        }



        private void edituser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Main ss = new Main();
            ss.Show();
        }
    }
}
