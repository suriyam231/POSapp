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
            fillComboBox();
        }
        public void fillComboBox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            string qry = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string fname = reader.GetString(3);
                    comboBox3.Items.Add(fname);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string ID = userID.Text.ToString();
                string Password = passWord.Text.ToString();
                string Firstname = firstName.Text.ToString();
                string Lastname = lastName.Text.ToString();
                string Status = status.SelectedItem.ToString();


                if (ID != null && Password != null && Firstname != null && Lastname != null && Status != null)
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                    conn.Open();
                    string qry = "UPDATE Users SET Username = '" + ID.ToString()+ "', Password = '" + Password.ToString() + "', FirstName = '" + Firstname.ToString() + "', Lastname = '" + Lastname.ToString() + "', Position = '" + Status.ToString() + "' WHERE Firstname = '" + comboBox3.Text + "' ";
                    SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                    MessageBox.Show("แก้ไขผู้ใช้งาน : คุณ" + Firstname + " เรียบร้อยแล้ว");
                    userID.Text = null;
                    passWord.Text = null;
                    firstName.Text = null;
                    lastName.Text = null;
                    status.SelectedItem = null;
                    comboBox3.SelectedItem = null;
                    showID.Text = null;
                    showPass.Text = null;
                    showFname.Text = null;
                    showLname.Text = null;
                    showStatus.Text = null;
                }


            }
            catch (SqlException error)
            {
                string ID = userID.Text.ToString();
                MessageBox.Show("มีรหัสผู้ใช้งาน : " + ID + " อยู่ในระบบแล้ว ไม่สามารถแก้ไขข้อมูลซ้ำได้");
            }
            catch (NullReferenceException nul)
            {
                MessageBox.Show("กรุณาเลือกประเภทสินค้า");
            }

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            string qry = "SELECT * FROM Users WHERE Firstname = '"+comboBox3.Text+"';";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ShowID = reader.GetString(1);
                    string ShowPass = reader.GetString(2);
                    string ShowFname = reader.GetString(3);
                    string ShowLname = reader.GetString(4);
                    string ShowStatus = reader.GetString(5);
                    showID.Text = ShowID;
                    showPass.Text = ShowPass;
                    showFname.Text = ShowFname;
                    showLname.Text = ShowLname;
                    showStatus.Text = ShowStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        if (ID == null)
                        {
                            MessageBox.Show("ตามเงื่อนไข");
                        }

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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            string qry = "SELECT * FROM Users WHERE Firstname = '" + comboBox3.Text + "';";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ShowID = reader.GetString(1);
                    string ShowPass = reader.GetString(2);
                    string ShowFname = reader.GetString(3);
                    string ShowLname = reader.GetString(4);
                    string ShowStatus = reader.GetString(5);
                    userID.Text = ShowID;
                    passWord.Text = ShowPass;
                    firstName.Text = ShowFname;
                    lastName.Text = ShowLname;
                    status.Text = ShowStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userID.Text = null;
            passWord.Text = null;
            firstName.Text = null;
            lastName.Text = null;
            status.SelectedItem = null;
            comboBox3.SelectedItem = null;
            showID.Text = null;
            showPass.Text = null;
            showFname.Text = null;
            showLname.Text = null;
            showStatus.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (comboBox3.Items.Count > 0)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                    conn.Open();
                    string qry = "DELETE Users WHERE Firstname = '" + comboBox3.Text + "';";
                    SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    MessageBox.Show("ลบรหัสผู้ใช้งานเรียบร้อย");
                    userID.Text = null;
                    passWord.Text = null;
                    firstName.Text = null;
                    lastName.Text = null;
                    status.SelectedItem = null;
                    comboBox3.SelectedItem = null;
                    showID.Text = null;
                    showPass.Text = null;
                    showFname.Text = null;
                    showLname.Text = null;
                    showStatus.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
