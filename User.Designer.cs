using System;

namespace POSTiw
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adduser = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.addRepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addFname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addLname = new System.Windows.Forms.TextBox();
            this.edituser = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showStatus = new System.Windows.Forms.Label();
            this.showLname = new System.Windows.Forms.Label();
            this.showFname = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.Label();
            this.showID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adduser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.edituser.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 90);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(157, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 90);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adduser
            // 
            this.adduser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adduser.BackColor = System.Drawing.Color.LightBlue;
            this.adduser.Controls.Add(this.edituser);
            this.adduser.Controls.Add(this.button4);
            this.adduser.Controls.Add(this.button3);
            this.adduser.Controls.Add(this.panel3);
            this.adduser.Controls.Add(this.panel2);
            this.adduser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adduser.Location = new System.Drawing.Point(1, 89);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(1535, 704);
            this.adduser.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(583, 615);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "ยกเลิก";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(733, 615);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "เพิ่ม";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addRepass);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addPass);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.addID);
            this.panel3.Location = new System.Drawing.Point(70, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 460);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(57, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "รหัสผ่านอีกครั้ง :";
            // 
            // addRepass
            // 
            this.addRepass.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRepass.Location = new System.Drawing.Point(208, 329);
            this.addRepass.Name = "addRepass";
            this.addRepass.Size = new System.Drawing.Size(262, 43);
            this.addRepass.TabIndex = 5;
            this.addRepass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_Event);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(108, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสผ่าน :";
            // 
            // addPass
            // 
            this.addPass.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPass.Location = new System.Drawing.Point(208, 232);
            this.addPass.Name = "addPass";
            this.addPass.Size = new System.Drawing.Size(262, 43);
            this.addPass.TabIndex = 3;
            this.addPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_Event);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(34, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "ข้อมูลผู้ใช้งาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(78, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสผู้ใช้งาน :";
            // 
            // addID
            // 
            this.addID.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addID.Location = new System.Drawing.Point(208, 133);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(262, 43);
            this.addID.TabIndex = 0;
            this.addID.TextChanged += new System.EventHandler(this.addID_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.addStatus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addFname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.addLname);
            this.panel2.Location = new System.Drawing.Point(700, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 460);
            this.panel2.TabIndex = 0;
            // 
            // addStatus
            // 
            this.addStatus.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatus.FormattingEnabled = true;
            this.addStatus.Items.AddRange(new object[] {
            "เจ้าของร้าน",
            "ผู้จัดการ",
            "พนักงาน"});
            this.addStatus.Location = new System.Drawing.Point(213, 329);
            this.addStatus.Name = "addStatus";
            this.addStatus.Size = new System.Drawing.Size(282, 44);
            this.addStatus.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(105, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "ตำแหน่ง : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addFname
            // 
            this.addFname.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFname.Location = new System.Drawing.Point(212, 133);
            this.addFname.Name = "addFname";
            this.addFname.Size = new System.Drawing.Size(283, 43);
            this.addFname.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SlateBlue;
            this.label9.Location = new System.Drawing.Point(150, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 39);
            this.label9.TabIndex = 9;
            this.label9.Text = "ชื่อ : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateBlue;
            this.label7.Location = new System.Drawing.Point(105, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "นามสกุล : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(62, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 47);
            this.label8.TabIndex = 8;
            this.label8.Text = "ข้อมูลส่วนตัว";
            // 
            // addLname
            // 
            this.addLname.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLname.Location = new System.Drawing.Point(213, 232);
            this.addLname.Name = "addLname";
            this.addLname.Size = new System.Drawing.Size(282, 43);
            this.addLname.TabIndex = 10;
            // 
            // edituser
            // 
            this.edituser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edituser.BackColor = System.Drawing.Color.Bisque;
            this.edituser.Controls.Add(this.panel5);
            this.edituser.Controls.Add(this.panel6);
            this.edituser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.edituser.Location = new System.Drawing.Point(0, 3);
            this.edituser.Name = "edituser";
            this.edituser.Size = new System.Drawing.Size(1535, 707);
            this.edituser.TabIndex = 7;
            this.edituser.Paint += new System.Windows.Forms.PaintEventHandler(this.edituser_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(67, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(526, 488);
            this.panel5.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Tomato;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button10.Location = new System.Drawing.Point(110, 400);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 54);
            this.button10.TabIndex = 20;
            this.button10.Text = "ลบ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.showStatus);
            this.panel1.Controls.Add(this.showLname);
            this.panel1.Controls.Add(this.showFname);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.showID);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(39, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 168);
            this.panel1.TabIndex = 17;
            // 
            // showStatus
            // 
            this.showStatus.AutoSize = true;
            this.showStatus.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.showStatus.Location = new System.Drawing.Point(116, 109);
            this.showStatus.Name = "showStatus";
            this.showStatus.Size = new System.Drawing.Size(24, 39);
            this.showStatus.TabIndex = 28;
            this.showStatus.Text = " ";
            // 
            // showLname
            // 
            this.showLname.AutoSize = true;
            this.showLname.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLname.ForeColor = System.Drawing.Color.DarkBlue;
            this.showLname.Location = new System.Drawing.Point(297, 71);
            this.showLname.Name = "showLname";
            this.showLname.Size = new System.Drawing.Size(24, 39);
            this.showLname.TabIndex = 27;
            this.showLname.Text = " ";
            this.showLname.Click += new System.EventHandler(this.label28_Click);
            // 
            // showFname
            // 
            this.showFname.AutoSize = true;
            this.showFname.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFname.ForeColor = System.Drawing.Color.DarkBlue;
            this.showFname.Location = new System.Drawing.Point(72, 69);
            this.showFname.Name = "showFname";
            this.showFname.Size = new System.Drawing.Size(24, 39);
            this.showFname.TabIndex = 26;
            this.showFname.Text = " ";
            this.showFname.Click += new System.EventHandler(this.label27_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.showPass.Location = new System.Drawing.Point(297, 17);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(24, 39);
            this.showPass.TabIndex = 25;
            this.showPass.Text = " ";
            this.showPass.Click += new System.EventHandler(this.label26_Click);
            // 
            // showID
            // 
            this.showID.AutoSize = true;
            this.showID.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showID.ForeColor = System.Drawing.Color.DarkBlue;
            this.showID.Location = new System.Drawing.Point(101, 20);
            this.showID.Name = "showID";
            this.showID.Size = new System.Drawing.Size(24, 39);
            this.showID.TabIndex = 24;
            this.showID.Text = " ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.DarkBlue;
            this.label24.Location = new System.Drawing.Point(107, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 24);
            this.label24.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkBlue;
            this.label23.Location = new System.Drawing.Point(6, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 28);
            this.label23.TabIndex = 22;
            this.label23.Text = "ตำแหน่ง :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(221, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 28);
            this.label22.TabIndex = 21;
            this.label22.Text = "รหัสผ่าน : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(6, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 28);
            this.label21.TabIndex = 20;
            this.label21.Text = "รหัสผู้ใช้งาน :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkBlue;
            this.label20.Location = new System.Drawing.Point(219, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 28);
            this.label20.TabIndex = 19;
            this.label20.Text = "นามสกุล : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("TH SarabunPSK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(32, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 28);
            this.label13.TabIndex = 18;
            this.label13.Text = "ชื่อ :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Peru;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.Location = new System.Drawing.Point(264, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 54);
            this.button7.TabIndex = 4;
            this.button7.Text = "แก้ไข";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(177, 122);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(259, 41);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(45, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 39);
            this.label19.TabIndex = 15;
            this.label19.Text = "รหัสผู้ใช้งาน :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(22, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 43);
            this.label12.TabIndex = 2;
            this.label12.Text = "ข้อมูลผู้ใช้งาน";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Moccasin;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.passWord);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.userID);
            this.panel6.Controls.Add(this.status);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.firstName);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.lastName);
            this.panel6.Location = new System.Drawing.Point(659, 122);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(758, 488);
            this.panel6.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Tomato;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.Location = new System.Drawing.Point(247, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 54);
            this.button6.TabIndex = 18;
            this.button6.Text = "ยกเลิก";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(401, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 54);
            this.button5.TabIndex = 3;
            this.button5.Text = "บันทึก";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SlateBlue;
            this.label10.Location = new System.Drawing.Point(396, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = "รหัสผ่าน :";
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(503, 132);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(202, 43);
            this.passWord.TabIndex = 17;
            this.passWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_Event);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SlateBlue;
            this.label11.Location = new System.Drawing.Point(74, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 39);
            this.label11.TabIndex = 16;
            this.label11.Text = "รหัสผู้ใช้งาน :";
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(208, 131);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(172, 43);
            this.userID.TabIndex = 15;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "เจ้าของร้าน",
            "ผู้จัดการ",
            "พนักงาน"});
            this.status.Location = new System.Drawing.Point(208, 288);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(295, 44);
            this.status.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SlateBlue;
            this.label15.Location = new System.Drawing.Point(98, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 39);
            this.label15.TabIndex = 13;
            this.label15.Text = "ตำแหน่ง  :";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(208, 211);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(172, 43);
            this.firstName.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SlateBlue;
            this.label16.Location = new System.Drawing.Point(149, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 39);
            this.label16.TabIndex = 9;
            this.label16.Text = "ชื่อ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("TH SarabunPSK", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SlateBlue;
            this.label17.Location = new System.Drawing.Point(395, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 39);
            this.label17.TabIndex = 11;
            this.label17.Text = "นามสกุล :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SlateBlue;
            this.label18.Location = new System.Drawing.Point(34, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 43);
            this.label18.TabIndex = 8;
            this.label18.Text = "ข้อมูลส่วนตัว";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(503, 214);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(202, 43);
            this.lastName.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(1456, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 73);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 791);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ผู้ใช้งาน";
            this.Load += new System.EventHandler(this.User_Load);
            this.adduser.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.edituser.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel adduser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addRepass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addFname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addLname;
        private System.Windows.Forms.Panel edituser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label showStatus;
        private System.Windows.Forms.Label showLname;
        private System.Windows.Forms.Label showFname;
        private System.Windows.Forms.Label showPass;
        private System.Windows.Forms.Label showID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
    }
}