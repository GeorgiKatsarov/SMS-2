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
            this.quantityTXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveStockBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quantityTXTBOX
            // 
            this.quantityTXTBOX.Location = new System.Drawing.Point(198, 144);
            this.quantityTXTBOX.Name = "quantityTXTBOX";
            this.quantityTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.quantityTXTBOX.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "количество:";
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(198, 71);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.idTXTBOX.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "id:";
            // 
            // RemoveStockBttn
            // 
            this.RemoveStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.RemoveStockBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveStockBttn.Location = new System.Drawing.Point(320, 224);
            this.RemoveStockBttn.Name = "RemoveStockBttn";
            this.RemoveStockBttn.Size = new System.Drawing.Size(269, 65);
            this.RemoveStockBttn.TabIndex = 24;
            this.RemoveStockBttn.Text = "Бракувай";
            this.RemoveStockBttn.UseVisualStyleBackColor = false;
            this.RemoveStockBttn.Click += new System.EventHandler(this.RemoveStockBttn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(22, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 65);
            this.button1.TabIndex = 29;
            this.button1.Text = "Затвори";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityTXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quantityTXTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveStockBttn;
        private System.Windows.Forms.Button button1;
    }
}