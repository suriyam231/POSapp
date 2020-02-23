namespace POSTiw.PageWarehouse
{
    partial class ShareProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Labutton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "สแกนสินค้าที่เป็นแพ็ค : ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 32);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onkey);
            // 
            // Labutton
            // 
            this.Labutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Labutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Labutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Labutton.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Labutton.Location = new System.Drawing.Point(590, 112);
            this.Labutton.Name = "Labutton";
            this.Labutton.Size = new System.Drawing.Size(109, 39);
            this.Labutton.TabIndex = 32;
            this.Labutton.Text = "ค้นหาสินค้า";
            this.Labutton.UseVisualStyleBackColor = false;
            this.Labutton.Click += new System.EventHandler(this.Labutton_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.MistyRose;
            this.label14.Font = new System.Drawing.Font("TH SarabunPSK", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(341, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "ค้นหาสินค้าโดยการสแกนสินค้า";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("TH SarabunPSK", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(459, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 32);
            this.textBox2.TabIndex = 45;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnkeyPack);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 36);
            this.label7.TabIndex = 46;
            this.label7.Text = "แพ็ค";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 36);
            this.label8.TabIndex = 47;
            this.label8.Text = "เลือกจำนวนแพ็คทที่ต้องการแยก :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(592, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "แยกแพ็ค";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(147, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 89);
            this.panel1.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.ForestGreen;
            this.label17.Location = new System.Drawing.Point(499, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 36);
            this.label17.TabIndex = 50;
            this.label17.Text = "ชิ้น";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.ForestGreen;
            this.label16.Location = new System.Drawing.Point(451, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 36);
            this.label16.TabIndex = 51;
            this.label16.Text = "00";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(358, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 36);
            this.label15.TabIndex = 50;
            this.label15.Text = "1 แพ็ค  : ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(499, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 36);
            this.label13.TabIndex = 50;
            this.label13.Text = "แพ็ค";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.ForestGreen;
            this.label12.Location = new System.Drawing.Point(451, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 36);
            this.label12.TabIndex = 50;
            this.label12.Text = "00";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 36);
            this.label11.TabIndex = 50;
            this.label11.Text = "เหลือจำนวน  : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(68, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 36);
            this.label10.TabIndex = 50;
            this.label10.Text = "00";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 36);
            this.label9.TabIndex = 50;
            this.label9.Text = "สินค้า : ";
            // 
            // ShareProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(842, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Labutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "ShareProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แยกแพ็คของสินค้า";
            this.Load += new System.EventHandler(this.ShareProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Labutton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}