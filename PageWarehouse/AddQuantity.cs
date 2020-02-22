using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POSTiw.PageWarehouse;

namespace POSTiw
{
    public partial class AddQuantity : UserControl
    {
        public AddQuantity()
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

        public void Onkey(object sender, KeyEventArgs kea)
        {

            if (comboBox1.SelectedItem == null)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = comboBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");



            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM [dbo].[Products] WHERE TypeName = '" + values + "'";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddQuantity_Load(object sender, EventArgs e)
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


            dataGridView1.Columns["ProductQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ProductPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[7].Width = 200;
            dataGridView1.Columns[8].Width = 130;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox3.Text = null;
                ID_lab.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Name_lab.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Amount_lab.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception i)
            {
                MessageBox.Show("กรุณาคลิกที่หน้าสินค้าที่ต้องการแก้ไข");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = ID_lab.Text.ToString();
            string Name = Name_lab.Text.ToString();
            int addAmuont;
            Int32.TryParse(textBox3.Text, out addAmuont);
            if (ID != null && addAmuont != 0)
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                conn.Open();
                string qry = "SELECT ProductQuantity , Description FROM Products WHERE ProductID = '" + ID+"'";



                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(qry,conn);
                int number = 0;
                adapter.Fill(data);
                number = data.Rows[0].Field<int>(0);

                string Descrip = data.Rows[0][1].ToString();
                string Strsup;
                try
                {
                    Strsup = Descrip.Substring(0, 4).ToString();
                }
                catch (Exception ex)
                {
                    Strsup = "NOTS";
                }


                //if (Strsup == "Pack")
                //{
                    
                //    string str = ID.Substring(1);
                //    string Pack = "select ProductQuantity from Products where ProductID= '" + str + "'";
                //    DataTable PackData = new DataTable();
                //    SqlDataAdapter AdapterPack = new SqlDataAdapter(Pack, conn);
                //    int piece;
                //    int Packnumber;
                //    Int32.TryParse(Descrip.Substring(5), out Packnumber);
                //    AdapterPack.Fill(PackData);
                //    piece = PackData.Rows[0].Field<int>(0);
                //    int Totals = piece + (Packnumber * addAmuont);

                //    string ChangPack = "UPDATE Products SET ProductQuantity = '" + Totals + "', Date = '" + DateTime.Now + "' WHERE ProductID = '" + str + "'";
                    
                //    SqlDataReader PackUdate = new SqlCommand(ChangPack, conn).ExecuteReader();
                //    conn.Close();
                //}
                //else if (Strsup != "Pack")
                //{
                   
                //    string str = "1" + ID;
                //    string Pack = "select ProductQuantity ,Description from Products where ProductID= '" + str + "'";
                //    DataTable PackData = new DataTable();
                //    SqlDataAdapter AdapterPack = new SqlDataAdapter(Pack, conn);
                //    int piece;
                //    int PackNumber;
                //    AdapterPack.Fill(PackData);
                //    if (PackData.Rows.Count != 0)
                //    {
                //        Int32.TryParse(PackData.Rows[0][1].ToString().Substring(5), out PackNumber);
                //        piece = PackData.Rows[0].Field<int>(0);

                //        int TotalPack = piece * PackNumber;
                //        int Totals = TotalPack + addAmuont;
                       
                            
                //            string ChangPack = "UPDATE Products SET ProductQuantity = '" + Totals/PackNumber + "', Date = '" + DateTime.Now + "' WHERE ProductID = '" + str + "'";
                //            SqlDataReader PackUdate = new SqlCommand(ChangPack, conn).ExecuteReader();
                        

                //    }
                //    conn.Close();
                //}
                int Total = 0;
                Total = number + addAmuont;

               
                string update = "UPDATE Products SET ProductQuantity = '"+Total+"',Date = '"+DateTime.Now+"' WHERE ProductID = '"+ID+"'";

                
                SqlDataReader reader = new SqlCommand(update, conn).ExecuteReader();
                MessageBox.Show("เพิ่มจำนวนสินค้า : " + Name + "เป็นจำนวน : " + Total + " เรียบร้อยแล้ว");

                SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                SqlCommand command = new SqlCommand();
                command.Connection = connn;
                command.CommandText = "SELECT * FROM [dbo].[Products]";
                DataTable data2 = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                adapter2.Fill(data2);
                dataGridView1.DataSource = data2;
                ID_lab.Text = null;
                Name_lab.Text = null;
                Amount_lab.Text = null;
                textBox3.Text = null;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนกดเพิ่มสินค้า");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT * FROM [dbo].[Products] WHERE ProductName LIKE '%"+textBox1.Text.ToString()+"%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string test = "";
            using (ShareProduct share = new ShareProduct())
            {
                share.ShowDialog();

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
    }
}
