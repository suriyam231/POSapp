namespace POSTiw
{
    partial class LowProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowProduct));
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LaId = new System.Windows.Forms.Label();
            this.LaName = new System.Windows.Forms.Label();
            this.LaType2 = new System.Windows.Forms.Label();
            this.LaInput = new System.Windows.Forms.TextBox();
            this.LaUp = new System.Windows.Forms.Label();
            this.LaType = new System.Windows.Forms.Label();
            this.Amount_lab = new System.Windows.Forms.Label();
            this.LaQu = new System.Windows.Forms.Label();
            this.Labutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(1459, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 73);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 49);
            this.label1.TabIndex = 12;
            this.label1.Text = "สินค้าที่เหลือน้อย";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "สินค้าที่น้อยกว่า : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(156, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 32);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "ชิ้น";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 521);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "เลือกประเภทสินค้า :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(570, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 30);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Onkey);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.LightYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(858, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(664, 521);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1120, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 42);
            this.label6.TabIndex = 20;
            this.label6.Text = "จัดการสินค้า";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1019, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "พิมพ์รายการสินค้าที่ต้องซื้อ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1019, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "ต้องการเพิ่มสินค้า";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LaId
            // 
            this.LaId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaId.AutoSize = true;
            this.LaId.BackColor = System.Drawing.Color.LightYellow;
            this.LaId.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaId.Location = new System.Drawing.Point(1100, 438);
            this.LaId.Name = "LaId";
            this.LaId.Size = new System.Drawing.Size(24, 36);
            this.LaId.TabIndex = 23;
            this.LaId.Text = "x";
            // 
            // LaName
            // 
            this.LaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaName.AutoSize = true;
            this.LaName.BackColor = System.Drawing.Color.LightYellow;
            this.LaName.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaName.Location = new System.Drawing.Point(1319, 438);
            this.LaName.Name = "LaName";
            this.LaName.Size = new System.Drawing.Size(24, 36);
            this.LaName.TabIndex = 24;
            this.LaName.Text = "x";
            // 
            // LaType2
            // 
            this.LaType2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaType2.AutoSize = true;
            this.LaType2.BackColor = System.Drawing.Color.LightYellow;
            this.LaType2.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaType2.ForeColor = System.Drawing.Color.Green;
            this.LaType2.Location = new System.Drawing.Point(1411, 519);
            this.LaType2.Name = "LaType2";
            this.LaType2.Size = new System.Drawing.Size(38, 36);
            this.LaType2.TabIndex = 30;
            this.LaType2.Text = "ชิ้น";
            // 
            // LaInput
            // 
            this.LaInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaInput.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaInput.Location = new System.Drawing.Point(1330, 518);
            this.LaInput.Name = "LaInput";
            this.LaInput.Size = new System.Drawing.Size(75, 32);
            this.LaInput.TabIndex = 29;
            // 
            // LaUp
            // 
            this.LaUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaUp.AutoSize = true;
            this.LaUp.BackColor = System.Drawing.Color.LightYellow;
            this.LaUp.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaUp.ForeColor = System.Drawing.Color.Green;
            this.LaUp.Location = new System.Drawing.Point(1234, 516);
            this.LaUp.Name = "LaUp";
            this.LaUp.Size = new System.Drawing.Size(99, 36);
            this.LaUp.TabIndex = 28;
            this.LaUp.Text = "เพิ่มสินค้า :";
            // 
            // LaType
            // 
            this.LaType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaType.AutoSize = true;
            this.LaType.BackColor = System.Drawing.Color.LightYellow;
            this.LaType.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LaType.Location = new System.Drawing.Point(1156, 516);
            this.LaType.Name = "LaType";
            this.LaType.Size = new System.Drawing.Size(38, 36);
            this.LaType.TabIndex = 27;
            this.LaType.Text = "ชิ้น";
            // 
            // Amount_lab
            // 
            this.Amount_lab.AutoSize = true;
            this.Amount_lab.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Amount_lab.Location = new System.Drawing.Point(1052, 516);
            this.Amount_lab.Name = "Amount_lab";
            this.Amount_lab.Size = new System.Drawing.Size(0, 36);
            this.Amount_lab.TabIndex = 26;
            // 
            // LaQu
            // 
            this.LaQu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaQu.AutoSize = true;
            this.LaQu.BackColor = System.Drawing.Color.LightYellow;
            this.LaQu.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaQu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LaQu.Location = new System.Drawing.Point(1126, 514);
            this.LaQu.Name = "LaQu";
            this.LaQu.Size = new System.Drawing.Size(24, 36);
            this.LaQu.TabIndex = 25;
            this.LaQu.Text = "x";
            // 
            // Labutton
            // 
            this.Labutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Labutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Labutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Labutton.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Labutton.Location = new System.Drawing.Point(1152, 601);
            this.Labutton.Name = "Labutton";
            this.Labutton.Size = new System.Drawing.Size(93, 40);
            this.Labutton.TabIndex = 31;
            this.Labutton.Text = "เพิ่ม";
            this.Labutton.UseVisualStyleBackColor = false;
            this.Labutton.Click += new System.EventHandler(this.Labutton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightYellow;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(994, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 36);
            this.label7.TabIndex = 32;
            this.label7.Text = "สินค้าเหลืออยู่ :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightYellow;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(994, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 36);
            this.label8.TabIndex = 33;
            this.label8.Text = "รหัสสินค้า  :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1244, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 36);
            this.label9.TabIndex = 34;
            this.label9.Text = "สินค้า :";
            // 
            // LowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1534, 791);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Labutton);
            this.Controls.Add(this.LaType2);
            this.Controls.Add(this.LaInput);
            this.Controls.Add(this.LaUp);
            this.Controls.Add(this.LaType);
            this.Controls.Add(this.Amount_lab);
            this.Controls.Add(this.LaQu);
            this.Controls.Add(this.LaName);
            this.Controls.Add(this.LaId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LowProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการสินค้าเหลือน้อย";
            this.Load += new System.EventHandler(this.LowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LaId;
        private System.Windows.Forms.Label LaName;
        private System.Windows.Forms.Label LaType2;
        private System.Windows.Forms.TextBox LaInput;
        private System.Windows.Forms.Label LaUp;
        private System.Windows.Forms.Label LaType;
        private System.Windows.Forms.Label Amount_lab;
        private System.Windows.Forms.Label LaQu;
        private System.Windows.Forms.Button Labutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}