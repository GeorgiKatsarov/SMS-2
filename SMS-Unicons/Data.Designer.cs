namespace SMS_Unicons
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ScrappingBttn = new System.Windows.Forms.Button();
            this.SalesBttn = new System.Windows.Forms.Button();
            this.DeliveriesBttn = new System.Windows.Forms.Button();
            this.stockBttn = new System.Windows.Forms.Button();
            this.revenueBttn = new System.Windows.Forms.Button();
            this.delivery2Bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(862, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // ScrappingBttn
            // 
            this.ScrappingBttn.Location = new System.Drawing.Point(12, 174);
            this.ScrappingBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScrappingBttn.Name = "ScrappingBttn";
            this.ScrappingBttn.Size = new System.Drawing.Size(164, 41);
            this.ScrappingBttn.TabIndex = 6;
            this.ScrappingBttn.Text = "Бракуване";
            this.ScrappingBttn.UseVisualStyleBackColor = true;
            this.ScrappingBttn.Click += new System.EventHandler(this.ScrappingBttn_Click);
            // 
            // SalesBttn
            // 
            this.SalesBttn.Location = new System.Drawing.Point(12, 127);
            this.SalesBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesBttn.Name = "SalesBttn";
            this.SalesBttn.Size = new System.Drawing.Size(164, 41);
            this.SalesBttn.TabIndex = 5;
            this.SalesBttn.Text = "Продажби";
            this.SalesBttn.UseVisualStyleBackColor = true;
            this.SalesBttn.Click += new System.EventHandler(this.SalesBttn_Click);
            // 
            // DeliveriesBttn
            // 
            this.DeliveriesBttn.Location = new System.Drawing.Point(12, 28);
            this.DeliveriesBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveriesBttn.Name = "DeliveriesBttn";
            this.DeliveriesBttn.Size = new System.Drawing.Size(164, 41);
            this.DeliveriesBttn.TabIndex = 4;
            this.DeliveriesBttn.Text = "Доставки a";
            this.DeliveriesBttn.UseVisualStyleBackColor = true;
            this.DeliveriesBttn.Click += new System.EventHandler(this.DeliveriesBttn_Click);
            // 
            // stockBttn
            // 
            this.stockBttn.Location = new System.Drawing.Point(12, 222);
            this.stockBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockBttn.Name = "stockBttn";
            this.stockBttn.Size = new System.Drawing.Size(164, 41);
            this.stockBttn.TabIndex = 7;
            this.stockBttn.Text = "Наличност";
            this.stockBttn.UseVisualStyleBackColor = true;
            this.stockBttn.Click += new System.EventHandler(this.stockBttn_Click);
            // 
            // revenueBttn
            // 
            this.revenueBttn.Location = new System.Drawing.Point(12, 268);
            this.revenueBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenueBttn.Name = "revenueBttn";
            this.revenueBttn.Size = new System.Drawing.Size(164, 39);
            this.revenueBttn.TabIndex = 8;
            this.revenueBttn.Text = "Печалби";
            this.revenueBttn.UseVisualStyleBackColor = true;
            this.revenueBttn.Click += new System.EventHandler(this.revenueBttn_Click);
            // 
            // delivery2Bttn
            // 
            this.delivery2Bttn.Location = new System.Drawing.Point(12, 75);
            this.delivery2Bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delivery2Bttn.Name = "delivery2Bttn";
            this.delivery2Bttn.Size = new System.Drawing.Size(164, 41);
            this.delivery2Bttn.TabIndex = 9;
            this.delivery2Bttn.Text = "Доставки b";
            this.delivery2Bttn.UseVisualStyleBackColor = true;
            this.delivery2Bttn.Click += new System.EventHandler(this.delivery2Bttn_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 615);
            this.Controls.Add(this.delivery2Bttn);
            this.Controls.Add(this.revenueBttn);
            this.Controls.Add(this.stockBttn);
            this.Controls.Add(this.ScrappingBttn);
            this.Controls.Add(this.SalesBttn);
            this.Controls.Add(this.DeliveriesBttn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ScrappingBttn;
        private System.Windows.Forms.Button SalesBttn;
        private System.Windows.Forms.Button DeliveriesBttn;
        private System.Windows.Forms.Button stockBttn;
        private System.Windows.Forms.Button revenueBttn;
        private System.Windows.Forms.Button delivery2Bttn;
    }
}