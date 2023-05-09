namespace SMS_Unicons
{
    partial class RemoveProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProduct));
            this.noteTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.recievingTXTBOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBttn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // noteTXTBOX
            // 
            this.noteTXTBOX.Location = new System.Drawing.Point(171, 94);
            this.noteTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noteTXTBOX.Name = "noteTXTBOX";
            this.noteTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.noteTXTBOX.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "бележка:";
            // 
            // cancelBttn
            // 
            this.cancelBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBttn.Location = new System.Drawing.Point(352, 578);
            this.cancelBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(191, 46);
            this.cancelBttn.TabIndex = 53;
            this.cancelBttn.Text = "Откажи";
            this.cancelBttn.UseVisualStyleBackColor = false;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // recievingTXTBOX
            // 
            this.recievingTXTBOX.Location = new System.Drawing.Point(171, 39);
            this.recievingTXTBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recievingTXTBOX.Name = "recievingTXTBOX";
            this.recievingTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.recievingTXTBOX.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "бракуващ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(28, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(515, 402);
            this.dataGridView1.TabIndex = 48;
            // 
            // saveBttn
            // 
            this.saveBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.saveBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBttn.Location = new System.Drawing.Point(28, 578);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(191, 46);
            this.saveBttn.TabIndex = 47;
            this.saveBttn.Text = "Запази";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
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
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 649);
            this.Controls.Add(this.noteTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.recievingTXTBOX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.TextBox recievingTXTBOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}