namespace POSTiw.ModalPage
{
    partial class CheckBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.change_lab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "คำนวนเงินทอน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(231, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "ตกลง";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "ราคาสินค้ารวม : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Total_lab
            // 
            this.Total_lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_lab.Font = new System.Drawing.Font("TH SarabunPSK", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Total_lab.Location = new System.Drawing.Point(266, 84);
            this.Total_lab.Name = "Total_lab";
            this.Total_lab.Size = new System.Drawing.Size(141, 39);
            this.Total_lab.TabIndex = 3;
            this.Total_lab.Text = "0";
            this.Total_lab.Click += new System.EventHandler(this.Total_lab_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "บาท";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "รับเงิน : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(249, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 49);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onkey);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keydown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "บาท";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "ทอนเงิน : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // change_lab
            // 
            this.change_lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.change_lab.Font = new System.Drawing.Font("TH SarabunPSK", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_lab.ForeColor = System.Drawing.Color.Green;
            this.change_lab.Location = new System.Drawing.Point(259, 235);
            this.change_lab.Name = "change_lab";
            this.change_lab.Size = new System.Drawing.Size(141, 39);
            this.change_lab.TabIndex = 9;
            this.change_lab.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "บาท";
            // 
            // CheckBill
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.change_lab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Total_lab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CheckBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Total_lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label change_lab;
        private System.Windows.Forms.Label label8;
    }
}