namespace SMS_Unicons
{
    partial class Changing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changing));
            this.priceChangeBttn = new System.Windows.Forms.Button();
            this.saleChangeBttn = new System.Windows.Forms.Button();
            this.deliveryChangeBttn = new System.Windows.Forms.Button();
            this.scrapChangeBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceChangeBttn
            // 
            this.priceChangeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.priceChangeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.priceChangeBttn.Location = new System.Drawing.Point(12, 26);
            this.priceChangeBttn.Name = "priceChangeBttn";
            this.priceChangeBttn.Size = new System.Drawing.Size(153, 113);
            this.priceChangeBttn.TabIndex = 25;
            this.priceChangeBttn.Text = "Промяна на цени";
            this.priceChangeBttn.UseVisualStyleBackColor = false;
            this.priceChangeBttn.Click += new System.EventHandler(this.priceChangeBttn_Click);
            // 
            // saleChangeBttn
            // 
            this.saleChangeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.saleChangeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.saleChangeBttn.Location = new System.Drawing.Point(12, 145);
            this.saleChangeBttn.Name = "saleChangeBttn";
            this.saleChangeBttn.Size = new System.Drawing.Size(153, 113);
            this.saleChangeBttn.TabIndex = 26;
            this.saleChangeBttn.Text = "Промяна на продажби";
            this.saleChangeBttn.UseVisualStyleBackColor = false;
            // 
            // deliveryChangeBttn
            // 
            this.deliveryChangeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.deliveryChangeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.deliveryChangeBttn.Location = new System.Drawing.Point(174, 26);
            this.deliveryChangeBttn.Name = "deliveryChangeBttn";
            this.deliveryChangeBttn.Size = new System.Drawing.Size(153, 113);
            this.deliveryChangeBttn.TabIndex = 27;
            this.deliveryChangeBttn.Text = "Промяна на доставки";
            this.deliveryChangeBttn.UseVisualStyleBackColor = false;
            this.deliveryChangeBttn.Click += new System.EventHandler(this.deliveryChangeBttn_Click);
            // 
            // scrapChangeBttn
            // 
            this.scrapChangeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.scrapChangeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.scrapChangeBttn.Location = new System.Drawing.Point(174, 145);
            this.scrapChangeBttn.Name = "scrapChangeBttn";
            this.scrapChangeBttn.Size = new System.Drawing.Size(153, 113);
            this.scrapChangeBttn.TabIndex = 28;
            this.scrapChangeBttn.Text = "Промяна на бракуване";
            this.scrapChangeBttn.UseVisualStyleBackColor = false;
            // 
            // Changing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.scrapChangeBttn);
            this.Controls.Add(this.deliveryChangeBttn);
            this.Controls.Add(this.saleChangeBttn);
            this.Controls.Add(this.priceChangeBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Changing";
            this.Text = "Changing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button priceChangeBttn;
        private System.Windows.Forms.Button saleChangeBttn;
        private System.Windows.Forms.Button deliveryChangeBttn;
        private System.Windows.Forms.Button scrapChangeBttn;
    }
}