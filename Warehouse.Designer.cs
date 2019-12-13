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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.typeProduct1 = new POSTiw.TypeProduct();
            this.addProdcutNew1 = new POSTiw.AddProdcutNew();
            this.addQuantity1 = new POSTiw.AddQuantity();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1440, 100);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "เพิ่มจำนวนสินค้า";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(178, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "เพิ่มสินค้าใหม่";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightYellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(340, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 79);
            this.button3.TabIndex = 6;
            this.button3.Text = "ประเภทสินค้า";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // typeProduct1
            // 
            this.typeProduct1.BackColor = System.Drawing.Color.LightYellow;
            this.typeProduct1.Location = new System.Drawing.Point(1, 97);
            this.typeProduct1.Name = "typeProduct1";
            this.typeProduct1.Size = new System.Drawing.Size(1440, 800);
            this.typeProduct1.TabIndex = 5;
            // 
            // addProdcutNew1
            // 
            this.addProdcutNew1.BackColor = System.Drawing.Color.PowderBlue;
            this.addProdcutNew1.Location = new System.Drawing.Point(1, 97);
            this.addProdcutNew1.Name = "addProdcutNew1";
            this.addProdcutNew1.Size = new System.Drawing.Size(1440, 800);
            this.addProdcutNew1.TabIndex = 4;
            // 
            // addQuantity1
            // 
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
    }
}