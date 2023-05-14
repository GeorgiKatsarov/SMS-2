namespace SMS_Unicons
{
    partial class SaleChanging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleChanging));
            this.label5 = new System.Windows.Forms.Label();
            this.visualiseBttn = new System.Windows.Forms.Button();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.saveBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "не променяйте ID!";
            // 
            // visualiseBttn
            // 
            this.visualiseBttn.Location = new System.Drawing.Point(693, 27);
            this.visualiseBttn.Name = "visualiseBttn";
            this.visualiseBttn.Size = new System.Drawing.Size(128, 125);
            this.visualiseBttn.TabIndex = 31;
            this.visualiseBttn.Text = "Покажи \r\nданни";
            this.visualiseBttn.UseVisualStyleBackColor = true;
            this.visualiseBttn.Click += new System.EventHandler(this.visualiseBttn_Click);
            // 
            // cancelBttn
            // 
            this.cancelBttn.Location = new System.Drawing.Point(693, 316);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(128, 125);
            this.cancelBttn.TabIndex = 30;
            this.cancelBttn.Text = "Откажи";
            this.cancelBttn.UseVisualStyleBackColor = true;
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(693, 173);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(128, 125);
            this.saveBttn.TabIndex = 29;
            this.saveBttn.Text = "Запази";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(639, 352);
            this.dataGridView1.TabIndex = 28;
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(482, 27);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(100, 40);
            this.idTXTBOX.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID на продажба за редактиране:";
            // 
            // SaleChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visualiseBttn);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SaleChanging";
            this.Text = "SaleChanging";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button visualiseBttn;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.Label label1;
    }
}