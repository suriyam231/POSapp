namespace POSTiw.Page
{
    partial class EditProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PNAME_txt = new System.Windows.Forms.TextBox();
            this.PDes_txt = new System.Windows.Forms.TextBox();
            this.Pamuont_txt = new System.Windows.Forms.TextBox();
            this.Pprice_txt = new System.Windows.Forms.TextBox();
            this.Pcost_txt = new System.Windows.Forms.TextBox();
            this.Presfer_txt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ID_lab = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Total_lab = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalProduct_lab = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "ข้อมูลสินค้า";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 438);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "ค้นหาชื่อสินค้า :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(501, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 25);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "สแกนสินค้า  :";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(147, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.deleteText);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(26, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(276, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "* กรุณาเปลื่อนภาษาให้เป็นภาษา English ก่อนจะสแกนสินค้า";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(795, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 652);
            this.label2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1013, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 47);
            this.label5.TabIndex = 22;
            this.label5.Text = "แก้ไขข้อมูลสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(848, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "รหัสสินค้า(สแกนสินค้า) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(960, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "ชื่อสินค้า :";
            // 
            // PNAME_txt
            // 
            this.PNAME_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNAME_txt.Location = new System.Drawing.Point(1057, 217);
            this.PNAME_txt.Name = "PNAME_txt";
            this.PNAME_txt.Size = new System.Drawing.Size(276, 32);
            this.PNAME_txt.TabIndex = 26;
            // 
            // PDes_txt
            // 
            this.PDes_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDes_txt.Location = new System.Drawing.Point(1057, 278);
            this.PDes_txt.Name = "PDes_txt";
            this.PDes_txt.Size = new System.Drawing.Size(276, 32);
            this.PDes_txt.TabIndex = 27;
            // 
            // Pamuont_txt
            // 
            this.Pamuont_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pamuont_txt.Location = new System.Drawing.Point(1057, 337);
            this.Pamuont_txt.Name = "Pamuont_txt";
            this.Pamuont_txt.Size = new System.Drawing.Size(276, 32);
            this.Pamuont_txt.TabIndex = 28;
            // 
            // Pprice_txt
            // 
            this.Pprice_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pprice_txt.Location = new System.Drawing.Point(1057, 395);
            this.Pprice_txt.Name = "Pprice_txt";
            this.Pprice_txt.Size = new System.Drawing.Size(276, 32);
            this.Pprice_txt.TabIndex = 29;
            // 
            // Pcost_txt
            // 
            this.Pcost_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcost_txt.Location = new System.Drawing.Point(1057, 456);
            this.Pcost_txt.Name = "Pcost_txt";
            this.Pcost_txt.Size = new System.Drawing.Size(276, 32);
            this.Pcost_txt.TabIndex = 30;
            // 
            // Presfer_txt
            // 
            this.Presfer_txt.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presfer_txt.Location = new System.Drawing.Point(1057, 516);
            this.Presfer_txt.Name = "Presfer_txt";
            this.Presfer_txt.Size = new System.Drawing.Size(276, 32);
            this.Presfer_txt.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1057, 578);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 34);
            this.comboBox1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1047, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "แก้ไขสินค้า";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Thistle;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(896, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 36);
            this.label8.TabIndex = 34;
            this.label8.Text = "รายละเอียดสินค้า :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(928, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 36);
            this.label9.TabIndex = 35;
            this.label9.Text = "จำนวนสินค้า :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Thistle;
            this.label10.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(957, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 36);
            this.label10.TabIndex = 36;
            this.label10.Text = "ราคาขาย :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Thistle;
            this.label12.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(940, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 36);
            this.label12.TabIndex = 37;
            this.label12.Text = "ราคาต้นทุน :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Thistle;
            this.label13.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(928, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 36);
            this.label13.TabIndex = 38;
            this.label13.Text = "ซื้อสินค้าจาก :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Thistle;
            this.label14.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(923, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 36);
            this.label14.TabIndex = 39;
            this.label14.Text = "ประเภทสินค้า :";
            // 
            // ID_lab
            // 
            this.ID_lab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ID_lab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_lab.Font = new System.Drawing.Font("TH SarabunPSK", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lab.Location = new System.Drawing.Point(1057, 154);
            this.ID_lab.Name = "ID_lab";
            this.ID_lab.Size = new System.Drawing.Size(276, 32);
            this.ID_lab.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Thistle;
            this.label15.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(106, 659);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 36);
            this.label15.TabIndex = 41;
            this.label15.Text = "สินค้าทั้งหมด : ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Total_lab
            // 
            this.Total_lab.AutoSize = true;
            this.Total_lab.BackColor = System.Drawing.Color.Thistle;
            this.Total_lab.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lab.Location = new System.Drawing.Point(242, 659);
            this.Total_lab.Name = "Total_lab";
            this.Total_lab.Size = new System.Drawing.Size(60, 36);
            this.Total_lab.TabIndex = 42;
            this.Total_lab.Text = "xxxxx";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Thistle;
            this.label16.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(321, 661);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 36);
            this.label16.TabIndex = 43;
            this.label16.Text = "อย่าง";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Thistle;
            this.label17.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(447, 661);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 36);
            this.label17.TabIndex = 44;
            this.label17.Text = "ทั้งหมด : ";
            // 
            // TotalProduct_lab
            // 
            this.TotalProduct_lab.AutoSize = true;
            this.TotalProduct_lab.BackColor = System.Drawing.Color.Thistle;
            this.TotalProduct_lab.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProduct_lab.Location = new System.Drawing.Point(550, 661);
            this.TotalProduct_lab.Name = "TotalProduct_lab";
            this.TotalProduct_lab.Size = new System.Drawing.Size(51, 36);
            this.TotalProduct_lab.TabIndex = 45;
            this.TotalProduct_lab.Text = "xxxx";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Thistle;
            this.label18.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(634, 661);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 36);
            this.label18.TabIndex = 46;
            this.label18.Text = "ชิ้น";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TotalProduct_lab);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Total_lab);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ID_lab);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Presfer_txt);
            this.Controls.Add(this.Pcost_txt);
            this.Controls.Add(this.Pprice_txt);
            this.Controls.Add(this.Pamuont_txt);
            this.Controls.Add(this.PDes_txt);
            this.Controls.Add(this.PNAME_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EditProduct";
            this.Size = new System.Drawing.Size(1440, 800);
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PNAME_txt;
        private System.Windows.Forms.TextBox PDes_txt;
        private System.Windows.Forms.TextBox Pamuont_txt;
        private System.Windows.Forms.TextBox Pprice_txt;
        private System.Windows.Forms.TextBox Pcost_txt;
        private System.Windows.Forms.TextBox Presfer_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ID_lab;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Total_lab;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalProduct_lab;
        private System.Windows.Forms.Label label18;
    }
}
