namespace SMS_Unicons
{
    partial class EditingProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingProcedure));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.quantityTXTBOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ново количество:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(272, 103);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(291, 40);
            this.idTXTBOX.TabIndex = 2;
            this.idTXTBOX.TextChanged += new System.EventHandler(this.idTXTBOX_TextChanged);
            // 
            // quantityTXTBOX
            // 
            this.quantityTXTBOX.Location = new System.Drawing.Point(272, 158);
            this.quantityTXTBOX.Name = "quantityTXTBOX";
            this.quantityTXTBOX.Size = new System.Drawing.Size(291, 40);
            this.quantityTXTBOX.TabIndex = 3;
            this.quantityTXTBOX.TextChanged += new System.EventHandler(this.quantityTXTBOX_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запази промяна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditingProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityTXTBOX);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "EditingProcedure";
            this.Text = "EditingProcedure";
            this.Load += new System.EventHandler(this.EditingProcedure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.TextBox quantityTXTBOX;
        private System.Windows.Forms.Button button1;
    }
}