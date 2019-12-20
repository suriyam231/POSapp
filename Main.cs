﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSTiw
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //DataTable dataOrder = new DataTable();
            //dataOrder.Columns.Add("ลำดับ");
            //dataOrder.Columns.Add("รหัสสินค้า");
            //dataOrder.Columns.Add("ชื่อสินค้า");
            //dataOrder.Columns.Add("จำนวนสินค้า");
            //dataOrder.Columns.Add("ราคาต่อหน่วย");
            //dataOrder.Columns.Add("ราคารวม");
            //dataGridView1.DataSource = dataOrder;

            this.ActiveControl = textBox1;
            label20.Hide();
            
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int billID = 0;
            string RID =null;
            string amount=null;
            string ProID = null;
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

            string check = "select COUNT(ReceiptID) from ReceiptDetail where Active = 'N'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(check, connn);
            adapter.Fill(data);
            if (data.Rows[0][0].ToString() == "0")
            {
                Random rand = new Random();
                billID = rand.Next(000000000, 999999999);
              
            }

           
                string ReceiptID = billID.ToString();
                label20.Text = ReceiptID.ToString();
                string getProduct = "Select * from Products where ProductID = '" + textBox1.Text.ToString() + "'";
                SqlDataAdapter adapterGet = new SqlDataAdapter(getProduct, connn);
                DataTable Product = new DataTable();
                adapterGet.Fill(Product);
                string ProductID = Product.Rows[0][0].ToString();
                string ProductName = Product.Rows[0][1].ToString();
                string ProductPrice = Product.Rows[0][4].ToString();

                int Price;
                Int32.TryParse(ProductPrice, out Price);
           

            DataTable dataOrder = new DataTable();



            dataOrder.Columns.Add("index");
            dataOrder.Columns.Add("ProID");
            dataOrder.Columns.Add("Proname");
            dataOrder.Columns.Add("Proamount");
            dataOrder.Columns.Add("Proprice");
            dataOrder.Columns.Add("total");

            //dataOrder.Rows.Add(1, ProductID, ProductName, 1, ProductPrice, 1 * Price);
            //dataGridView1.DataSource = dataOrder;
            DataRow row  = dataOrder.NewRow();
            int index = dataGridView1.Rows.Count;
            
            row["index"] =  index;
            row["ProID"] = ProductID;
            row["Proname"] = ProductName;
            row["Proamount"] = 1;
            row["Proprice"] = ProductPrice;
            row["total"] = ProductPrice;
            dataOrder.Rows.Add(row);

            foreach(DataRow Drow in dataOrder.Rows)
            {
                int num = dataGridView1.Rows.Add();
                int x = num;
                int y = num;
                string text = null;
                string text2 = null;
                string Proamount = null;
                string Proprice = null;
                string total = null;
                if (num > 0) 
                {
                    x = num - 1;
                    text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                    for (int i = 1; i <= num; i++)
                    {
                        x = num - i;
                        text = dataGridView1.Rows[x].Cells[1].Value.ToString();
                        if(ProductID == text)
                        {
                            break;
                        }
                    }

                }
                if (ProductID == text)
                {
                    Proamount = dataGridView1.Rows[x].Cells[3].Value.ToString();
                    Proprice = dataGridView1.Rows[x].Cells[4].Value.ToString();
                    total = dataGridView1.Rows[x].Cells[5].Value.ToString();
                    int amounts;
                    Int32.TryParse(Proamount, out amounts);
                    int price;
                    Int32.TryParse(Proprice, out price);
                    int totals;
                    Int32.TryParse(total, out totals);
                    amounts = amounts + 1;
                    totals = price * amounts;
                    dataGridView1.Rows[x].Cells[3].Value = amounts.ToString();
                    dataGridView1.Rows[x].Cells[5].Value = totals.ToString();
                    dataGridView1.Rows.Remove(dataGridView1.Rows[num]);

                    break;
                }
                
                dataGridView1.Rows[num].Cells[0].Value = Drow["index"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["ProID"].ToString();
                dataGridView1.Rows[num].Cells[2].Value = Drow["Proname"].ToString();
                dataGridView1.Rows[num].Cells[3].Value = Drow["Proamount"].ToString();
                dataGridView1.Rows[num].Cells[4].Value = Drow["Proprice"].ToString();
                dataGridView1.Rows[num].Cells[5].Value = Drow["total"].ToString();

               
            }

            textBox1.Text = "";
            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    string gettext = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    int texts;
                    Int32.TryParse(gettext, out texts);
                    Total = Total + texts;
                }
                catch (Exception er)
                {
                    break;
                }
            }
            label12.Text = Total.ToString();
            //8850987128400
            //8851932378567
            }
            catch (Exception s)
            {
                MessageBox.Show("ค้นหาสินค้าไม่เจอพบ");
                textBox1.Text = "";
            }
        }
        public void Onkey(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warehouse ss = new Warehouse();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
            SqlCommand command = new SqlCommand();
            command.Connection = connn;
            command.CommandText = "SELECT ProductID , ProductName , ProductQuantity , ProductPrice FROM [dbo].[Products] WHERE ProductName LIKE '%" + textBox2.Text.ToString() + "%'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView2.DataSource = data;
            dataGridView2.Columns["ProductID"].HeaderText = "รหัสสินค้า";
            dataGridView2.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView2.Columns["ProductQuantity"].HeaderText = "จำนวนสินค้า";
            dataGridView2.Columns["ProductPrice"].HeaderText = "ราคาขาย";
            dataGridView2.Columns[2].Width = 105;
            dataGridView2.Columns[3].Width = 100;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;

        }
        public void Check_bill(object sender, KeyEventArgs kea)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //namePro_lab.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
           
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                namePro_lab.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            string ProduceName = namePro_lab.Text.ToString();
            string number = textBox3.Text.ToString();

            string text = null;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if(number == "0" || number == "")
                    {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    namePro_lab.Text = "";
                    textBox3.Text = "";
                    }
                    text = row.Cells[2].Value.ToString();
 
                    if (ProduceName == text)
                    {
                        string textPrice = row.Cells[4].Value.ToString();
                        int price = 0;
                        int amount = 0;
                        Int32.TryParse(number, out amount);
                        Int32.TryParse(textPrice, out price);
                        int total = 0;
                        total = amount * price;
                        row.Cells[3].Value = amount.ToString();
                        row.Cells[5].Value = total.ToString();
                 
                        break;
                    }
                }
           // }
            int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    string gettext = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    int texts;
                    Int32.TryParse(gettext, out texts);
                    Total = Total + texts;
                }
                catch (Exception er)
                {
                    
                    break;
                }
            }
            label12.Text = Total.ToString();

        }
        public void Click_OK(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Enter)
            {
                button16.PerformClick();
            }
        }
        //public void ad(string a, string textID)
        //{
           

        //    if (a == "succes")
        //    {
        //        Main m = new Main();

                
        //    }
        //    if (a == "fail")
        //    {
        //        SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

        //        connn.Open();
        //        string qry2 = "delete ReceiptDetail where ReceiptID = '" + textID + "'";
        //        string qry1 = "delete Receipt where ReceiptID = '" + textID + "'";
        //        SqlDataReader reader2 = new SqlCommand(qry2, connn).ExecuteReader();

        //        SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
        //        conn.Open();
        //        SqlDataReader reader1 = new SqlCommand(qry1, conn).ExecuteReader();
        //    }
        //}
        public void button6_Click(object sender, EventArgs e)
        {
            label20.Text = "";
            namePro_lab.Text = "";
            textBox3.Text = "";
            label12.Text = "";
            Main m = new Main();
            this.Controls.Clear();
            this.InitializeComponent();
            this.ActiveControl = textBox1;
            label20.Hide();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Type;
            using(ModalPage.CheckBill bill = new ModalPage.CheckBill())
            {
                string a = label12.Text.ToString();

                bill.ad(a.ToString());
                if (bill.ShowDialog()== DialogResult.OK)
                {
                    Type = bill.Getvalues;
                    if (Type == "succes")
                    {
                        string textID = label20.Text.ToString();
                        int num = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            string ReceiptID = textID.ToString();
                            string ProductID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            string txtPrice = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            string txtAmount = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            int Amount = 0;

                            float Price = 0;
                            Int32.TryParse(txtAmount, out Amount);
                            float.TryParse(txtPrice, out Price);
                            string Active = "Y";
                            num = num + Amount;

                            SqlConnection conn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");
                            conn.Open();
                            string qry = "INSERT ReceiptDetail Values('" + ProductID + "','" + ReceiptID + "'," + Price + "," + Amount + ",'" + Active + "')";
                            SqlDataReader reader = new SqlCommand(qry, conn).ExecuteReader();
                            conn.Close();
                            conn.Open();
                            string Update = "select ProductQuantity from Products where ProductID= '" + ProductID + "'";
                            DataTable data = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(Update, conn);
                            int index;
                            adapter.Fill(data);
                            index = data.Rows[0].Field<int>(0);
                            conn.Close();
                            conn.Open();
                            int TotalAmount = 0;
                            TotalAmount = index - Amount;
                            string Edit = "UPDATE Products SET ProductQuantity = " + TotalAmount + " Where ProductID = '" + ProductID + "'";
                            SqlDataReader readerUdate = new SqlCommand(Edit, conn).ExecuteReader();

                            //8850987128400
                        }
                        SqlConnection connn = new SqlConnection(@"Data Source=122.155.3.151;Initial Catalog=posservicetp_co_cc_data;Persist Security Info=True;User ID=posservicetp_co_cc_data;Password=p@$$w0rd");

                        connn.Open();
                        string qry2 = "INSERT Receipt Values('" + textID + "','" + DateTime.Now.Date + "','" + DateTime.Now.TimeOfDay + "','" + label12.Text.ToString() + "','" + num + "')";
                        SqlDataReader reader2 = new SqlCommand(qry2, connn).ExecuteReader();
                        label20.Text = "";
                        namePro_lab.Text = "";
                        textBox3.Text = "";
                        label12.Text = "";
                        this.Controls.Clear();
                        this.InitializeComponent();
                        this.ActiveControl = textBox1;
                        label20.Hide();
                        dataGridView1.Columns[0].Width = 50;
                        dataGridView1.Columns[1].Width = 150;
                        dataGridView1.Columns[2].Width = 150;
                        dataGridView1.Columns[3].Width = 110;
                        dataGridView1.Columns[4].Width = 110;
                        dataGridView1.Columns[5].Width = 110;
                    }
                }
            }
           
           // string a = label12.Text.ToString();
            //ModalPage.CheckBill Bill = new ModalPage.CheckBill();
            //Bill.ad(a.ToString(),textID.ToString());
            //Bill.Show();
        }
       

        
    }
}
