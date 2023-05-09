namespace SMS_Unicons
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.deliveryPriceTXTBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTXTBOX = new System.Windows.Forms.TextBox();
            this.nameTXTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addStockBttn = new System.Windows.Forms.Button();
            this.closeBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deliveryPriceTXTBOX
            // 
            this.deliveryPriceTXTBOX.Location = new System.Drawing.Point(200, 186);
            this.deliveryPriceTXTBOX.Name = "deliveryPriceTXTBOX";
            this.deliveryPriceTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.deliveryPriceTXTBOX.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Доставна цена :";
            // 
            // priceTXTBOX
            // 
            this.priceTXTBOX.Location = new System.Drawing.Point(200, 140);
            this.priceTXTBOX.Name = "priceTXTBOX";
            this.priceTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.priceTXTBOX.TabIndex = 15;
            // 
            // nameTXTBOX
            // 
            this.nameTXTBOX.Location = new System.Drawing.Point(200, 91);
            this.nameTXTBOX.Name = "nameTXTBOX";
            this.nameTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.nameTXTBOX.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Цена :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Име :";
            // 
            // addStockBttn
            // 
            this.addStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addStockBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addStockBttn.Location = new System.Drawing.Point(348, 249);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(269, 65);
            this.addStockBttn.TabIndex = 9;
            this.addStockBttn.Text = "Добави";
            this.addStockBttn.UseVisualStyleBackColor = false;
            this.addStockBttn.Click += new System.EventHandler(this.addStockBttn_Click);
            // 
            // closeBttn
            // 
            this.closeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.closeBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeBttn.Location = new System.Drawing.Point(44, 249);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(269, 65);
            this.closeBttn.TabIndex = 18;
            this.closeBttn.Text = "Затвори";
            this.closeBttn.UseVisualStyleBackColor = false;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.closeBttn);
            this.Controls.Add(this.deliveryPriceTXTBOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTXTBOX);
            this.Controls.Add(this.nameTXTBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deliveryPriceTXTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTXTBOX;
        private System.Windows.Forms.TextBox nameTXTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.Button closeBttn;
    }
}