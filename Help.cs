using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e)
        {

            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าขาย.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าตรวจสอบบิล.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าคลังสินค้า.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าสินค้าใกล้หมด.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้ารายงานการขาย.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าสินค้าขายดี.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\PDF\\การใช้งานหน้าเพิ่มผู้ใช้งาน.pdf";

            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = path;
            axAcroPDF1.Show();
        }
    }
}
