namespace POSTiw.PageReport
{
    partial class MonthReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "รายงานการขายแบบรายเดือน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH SarabunPSK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "รายงานงบกำไร/ขาดทุน";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.January,
            this.February,
            this.March,
            this.April,
            this.May,
            this.June,
            this.July,
            this.August,
            this.September,
            this.October,
            this.November,
            this.December});
            this.dataGridView1.Location = new System.Drawing.Point(370, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(885, 117);
            this.dataGridView1.TabIndex = 7;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "รายการ";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            // 
            // January
            // 
            this.January.HeaderText = "มกราคม";
            this.January.Name = "January";
            this.January.ReadOnly = true;
            // 
            // February
            // 
            this.February.HeaderText = "กุมภาพันธ์";
            this.February.Name = "February";
            this.February.ReadOnly = true;
            // 
            // March
            // 
            this.March.HeaderText = "มีนาคม";
            this.March.Name = "March";
            this.March.ReadOnly = true;
            // 
            // April
            // 
            this.April.HeaderText = "เมษายน";
            this.April.Name = "April";
            this.April.ReadOnly = true;
            // 
            // May
            // 
            this.May.HeaderText = "พฤษภาคม";
            this.May.Name = "May";
            this.May.ReadOnly = true;
            // 
            // June
            // 
            this.June.HeaderText = "มิถุนายน";
            this.June.Name = "June";
            this.June.ReadOnly = true;
            // 
            // July
            // 
            this.July.HeaderText = "กรกฎาคม ";
            this.July.Name = "July";
            this.July.ReadOnly = true;
            // 
            // August
            // 
            this.August.HeaderText = "สิงหาคม";
            this.August.Name = "August";
            this.August.ReadOnly = true;
            // 
            // September
            // 
            this.September.HeaderText = "กันยายน";
            this.September.Name = "September";
            this.September.ReadOnly = true;
            // 
            // October
            // 
            this.October.HeaderText = "ตุลาคม";
            this.October.Name = "October";
            this.October.ReadOnly = true;
            // 
            // November
            // 
            this.November.HeaderText = "พฤศจิกายน";
            this.November.Name = "November";
            this.November.ReadOnly = true;
            // 
            // December
            // 
            this.December.HeaderText = "ธันวาคม";
            this.December.Name = "December";
            this.December.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "เลือกเดือนที่ต้องการดูยอดขาย :";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 30);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1033, 246);
            this.dataGridView2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(1199, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 51);
            this.button4.TabIndex = 43;
            this.button4.Text = "พิมพ์รายงาน";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MonthReport";
            this.Size = new System.Drawing.Size(1550, 713);
            this.Load += new System.EventHandler(this.MonthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
    }
}
