namespace POSTiw
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.editProduct1 = new POSTiw.Page.EditProduct();
            this.typeProduct1 = new POSTiw.TypeProduct();
            this.addProdcutNew1 = new POSTiw.AddProdcutNew();
            this.addQuantity1 = new POSTiw.AddQuantity();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1440, 100);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(16, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "เพิ่มจำนวนสินค้า";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(178, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "เพิ่มสินค้าใหม่";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(336, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 90);
            this.button3.TabIndex = 6;
            this.button3.Text = "ข้อมูลสินค้า";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.LightYellow;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(495, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 90);
            this.button4.TabIndex = 7;
            this.button4.Text = "ประเภทสินค้า";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1256, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 79);
            this.button5.TabIndex = 9;
            this.button5.Text = "หน้าขายของ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // editProduct1
            // 
            this.editProduct1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editProduct1.BackColor = System.Drawing.Color.Thistle;
            this.editProduct1.Location = new System.Drawing.Point(1, 97);
            this.editProduct1.Name = "editProduct1";
            this.editProduct1.Size = new System.Drawing.Size(1440, 800);
            this.editProduct1.TabIndex = 8;
            // 
            // typeProduct1
            // 
            this.typeProduct1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeProduct1.BackColor = System.Drawing.Color.LightYellow;
            this.typeProduct1.Location = new System.Drawing.Point(1, 97);
            this.typeProduct1.Name = "typeProduct1";
            this.typeProduct1.Size = new System.Drawing.Size(1440, 800);
            this.typeProduct1.TabIndex = 5;
            // 
            // addProdcutNew1
            // 
            this.addProdcutNew1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProdcutNew1.BackColor = System.Drawing.Color.PowderBlue;
            this.addProdcutNew1.Location = new System.Drawing.Point(1, 97);
            this.addProdcutNew1.Name = "addProdcutNew1";
            this.addProdcutNew1.Size = new System.Drawing.Size(1440, 800);
            this.addProdcutNew1.TabIndex = 4;
            // 
            // addQuantity1
            // 
            this.addQuantity1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addQuantity1.BackColor = System.Drawing.Color.Linen;
            this.addQuantity1.Location = new System.Drawing.Point(1, 97);
            this.addQuantity1.Name = "addQuantity1";
            this.addQuantity1.Size = new System.Drawing.Size(1440, 800);
            this.addQuantity1.TabIndex = 3;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.editProduct1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.typeProduct1);
            this.Controls.Add(this.addProdcutNew1);
            this.Controls.Add(this.addQuantity1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button button2;
        private AddQuantity addQuantity1;
        private AddProdcutNew addProdcutNew1;
        private TypeProduct typeProduct1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Page.EditProduct editProduct1;
        private System.Windows.Forms.Button button5;
    }
}