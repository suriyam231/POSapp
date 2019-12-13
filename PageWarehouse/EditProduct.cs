﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POSTiw.Page
{
    public partial class EditProduct : UserControl
    {
        public EditProduct()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM [dbo].[Products]";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

            conn.Open();
            string qry = "SELECT * FROM TypeProduct";

            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(1).ToString());
            }
            reader.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["Description"].HeaderText = "รายละเอียด";
            dataGridView1.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
            dataGridView1.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView1.Columns["CostPrice"].HeaderText = "ราคาต้นทุน";
            dataGridView1.Columns["ProductFrom"].HeaderText = "ซื้อสินค้ามาจาก";
            dataGridView1.Columns["TypeName"].HeaderText = "ประเภทสินค้า";
            dataGridView1.Columns["Date"].HeaderText = "วันที่เพิ่มสินค้าล่าสุด";

        }

        public void search(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                string values = textBox2.Text.ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[Products] WHERE ProductID = '" + values + "'";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                dataGridView1.DataSource = data;


            }
        }
        public void deleteText(object sender, KeyEventArgs kea)
        {

            if (textBox2.Text == "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM [dbo].[Products]";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT * FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox1.Text.ToString() + "%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                //ID_lab.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //Name_lab.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //Amount_lab.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ID_lab.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                PNAME_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PDes_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Pamuont_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Pprice_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Pcost_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Presfer_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }
    }
}
