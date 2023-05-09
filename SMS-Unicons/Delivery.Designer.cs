namespace SMS_Unicons
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.saveBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.recievingTXTBOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.providerTXTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewProductBttn = new System.Windows.Forms.Button();
            this.priceChangeButton = new System.Windows.Forms.Button();
            this.noteTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBttn
            // 
            this.saveBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.saveBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBttn.Location = new System.Drawing.Point(30, 599);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(191, 46);
            this.saveBttn.TabIndex = 34;
            this.saveBttn.Text = "Запази";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(888, 402);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cancelBttn
            // 
            this.cancelBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBttn.Location = new System.Drawing.Point(227, 599);
            this.cancelBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(191, 46);
            this.cancelBttn.TabIndex = 42;
            this.cancelBttn.Text = "Откажи";
            this.cancelBttn.UseVisualStyleBackColor = false;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // recievingTXTBOX
            // 
            this.recievingTXTBOX.Location = new System.Drawing.Point(161, 66);
            this.recievingTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recievingTXTBOX.Name = "recievingTXTBOX";
            this.recievingTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.recievingTXTBOX.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "приемащ:";
            // 
            // providerTXTBOX
            // 
            this.providerTXTBOX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerTXTBOX.Location = new System.Drawing.Point(161, 13);
            this.providerTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerTXTBOX.Name = "providerTXTBOX";
            this.providerTXTBOX.Size = new System.Drawing.Size(372, 35);
            this.providerTXTBOX.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "доставчик:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addNewProductBttn
            // 
            this.addNewProductBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addNewProductBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewProductBttn.Location = new System.Drawing.Point(560, 9);
            this.addNewProductBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewProductBttn.Name = "addNewProductBttn";
            this.addNewProductBttn.Size = new System.Drawing.Size(374, 35);
            this.addNewProductBttn.TabIndex = 43;
            this.addNewProductBttn.Text = "Добавяне на нов продукт";
            this.addNewProductBttn.UseVisualStyleBackColor = false;
            this.addNewProductBttn.Click += new System.EventHandler(this.addNewProductBttn_Click);
            // 
            // priceChangeButton
            // 
            this.priceChangeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.priceChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceChangeButton.Location = new System.Drawing.Point(560, 68);
            this.priceChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceChangeButton.Name = "priceChangeButton";
            this.priceChangeButton.Size = new System.Drawing.Size(374, 35);
            this.priceChangeButton.TabIndex = 44;
            this.priceChangeButton.Text = "Смяна на цена на продукт";
            this.priceChangeButton.UseVisualStyleBackColor = false;
            this.priceChangeButton.Click += new System.EventHandler(this.priceChangeButton_Click);
            // 
            // noteTXTBOX
            // 
            this.noteTXTBOX.Location = new System.Drawing.Point(161, 121);
            this.noteTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteTXTBOX.Name = "noteTXTBOX";
            this.noteTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.noteTXTBOX.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "бележка:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 660);
            this.Controls.Add(this.noteTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceChangeButton);
            this.Controls.Add(this.addNewProductBttn);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.recievingTXTBOX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.providerTXTBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.TextBox recievingTXTBOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox providerTXTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewProductBttn;
        private System.Windows.Forms.Button priceChangeButton;
        private System.Windows.Forms.TextBox noteTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}