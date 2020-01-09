using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POSTiw
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            edituser.Show();
            edituser.BringToFront();

            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

            conn.Open();
            string qry = "SELECT * FROM Users";

            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            while (reader.Read())
            {
                comboBox3.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Main ss = new Main();
            ss.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                string ID = userID.Text.ToString();
                string Password = passWord.Text.ToString();
                string Firstname = firstName.Text.ToString();
                string Lastname = lastName.Text.ToString();
                string Status = status.SelectedItem.ToString();

                if (ID != null && Password != null && Firstname != null && Lastname != null && Status != null)
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                    conn.Open();
                    index += 1;
                    //string qry = "INSERT INTO Users (Username, Password, FirstName, LastName, Position) Values('" + ID + "','" + Password + "','" + Firstname + "','" + Lastname + "','" + Status + "')";
                    string qry = "INSERT INTO TestID Values("+ index +",'" + ID + "','" + Password + "','" + Firstname + "','" + Lastname + "','" + Status + "')";
                    SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                    MessageBox.Show("เพิ่มผู้ใช้งาน : คุณ" + Firstname + " เรียบร้อยแล้ว");
                    
                    userID.Text = null;
                    firstName.Text = null;
                    lastName.Text = null;
                    status.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มผู้ใช้งาน");
                }


            }
            catch (SqlException error)
            {
                string ID = userID.Text.ToString();
                MessageBox.Show("มีรหัสผู้ใช้งาน : " + ID + " อยู่ในระบบแล้ว ไม่สามารถเพิ่มข้อมูลซ้ำได้");
            }
            catch (NullReferenceException nul)
            {
                MessageBox.Show("กรุณาเลือกประเภทสินค้า");
            }

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = addID.Text.ToString();
                string Password = addPass.Text.ToString();
                string Repassword = addRepass.Text.ToString();
                string Firstname = addFname.Text.ToString();
                string Lastname = addLname.Text.ToString();
                string Status = addStatus.SelectedItem.ToString();

                if (ID != null && Password != null && Repassword != null && Firstname != null && Lastname != null && Status != null)
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                    conn.Open();
                    if (Password == Repassword)
                    {
                        string qry = "INSERT INTO Users Values('" + ID + "','" + ID + "','" + Password + "','" + Firstname + "','" + Lastname + "','" + Status + "')";
                        SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                        MessageBox.Show("เพิ่มผู้ใช้งาน : คุณ" + Firstname + " เรียบร้อยแล้ว");

                        addID.Text = null;
                        addPass.Text = null;
                        addRepass.Text = null;
                        addFname.Text = null;
                        addLname.Text = null;
                        addStatus.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("รหัสผ่านไม่ตรงกัน");
                    }

                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มผู้ใช้งาน");
                }


            }
            catch (SqlException error)
            {
                string ID = addID.Text.ToString();
                MessageBox.Show("มีรหัสผู้ใช้งาน : " + ID + " อยู่ในระบบแล้ว ไม่สามารถเพิ่มข้อมูลซ้ำได้");
            }
            catch (NullReferenceException nul)
            {
                MessageBox.Show("กรุณาเลือกสถานะทางร้าน");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            addID.Text = null;
            addPass.Text = null;
            addRepass.Text = null;
            addFname.Text = null;
            addLname.Text = null;
            addStatus.SelectedItem = null;
        }
    }
}
