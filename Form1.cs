using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordTXT.PasswordChar = '*';
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;User ID=posservicetp_co_cc_data;Password=p@$$w0rd;");
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                SqlDataAdapter sda = new SqlDataAdapter("select  * From Users where Username = '" + textBox1.Text + "' and Password = '" + passwordTXT.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Main ss = new Main();
                    string Username = dt.Rows[0][3].ToString()+" "+dt.Rows[0][4].ToString();
                    ss.ad(Username.ToString());
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("เข้าสู่ระบบไม่สำเร็จ กรุณาตรวจสอบชื่อผู้ใช้และรหัสผ่านให้ถูกต้อง");
                }
            }
            catch(SqlException x)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อกับฐานข้อมูลได้ กรุณาตรวจสอบการเชื่อมต่ออินเตอร์เน็ตภายในเครื่องคอมพิวเตอร์ของคุณ");
            }

        }
        public void Onkey(object sender , KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void passwordTXT_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
