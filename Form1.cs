﻿using System;
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
            //SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;User ID=posservicetp_co_cc_data;Password=p@$$w0rd;");
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) From Users where Username = '" + textBox1.Text + "' and Password = '" + passwordTXT.Text + "'", conn);
            DataTable dt = new DataTable();

   
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM [dbo].[Product]";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);



            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("เข้่าสู่ระบบไม่สำเร็จ กรุณาตรวจสอบชื่อผู้ใช้และรหัสผ่านให่้ถูกต้อง");
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
