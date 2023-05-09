namespace SMS_Unicons
{
    partial class DeliveryChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryChange));
            this.label1 = new System.Windows.Forms.Label();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBttn = new System.Windows.Forms.Button();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.visualiseBttn = new System.Windows.Forms.Button();
            this.noteTXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.providerTXTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receiverTXTBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID на доставка за редактиране:";
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(516, 19);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(100, 40);
            this.idTXTBOX.TabIndex = 1;
            this.idTXTBOX.TextChanged += new System.EventHandler(this.idTXTBOX_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(639, 352);
            this.dataGridView1.TabIndex = 2;
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(682, 165);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(128, 125);
            this.saveBttn.TabIndex = 3;
            this.saveBttn.Text = "Запази";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // cancelBttn
            // 
            this.cancelBttn.Location = new System.Drawing.Point(682, 308);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(128, 125);
            this.cancelBttn.TabIndex = 4;
            this.cancelBttn.Text = "Откажи";
            this.cancelBttn.UseVisualStyleBackColor = true;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // visualiseBttn
            // 
            this.visualiseBttn.Location = new System.Drawing.Point(682, 19);
            this.visualiseBttn.Name = "visualiseBttn";
            this.visualiseBttn.Size = new System.Drawing.Size(128, 125);
            this.visualiseBttn.TabIndex = 5;
            this.visualiseBttn.Text = "Покажи \r\nданни";
            this.visualiseBttn.UseVisualStyleBackColor = true;
            this.visualiseBttn.Click += new System.EventHandler(this.visualiseBttn_Click);
            // 
            // noteTXTBOX
            // 
            this.noteTXTBOX.Location = new System.Drawing.Point(131, 455);
            this.noteTXTBOX.Name = "noteTXTBOX";
            this.noteTXTBOX.Size = new System.Drawing.Size(100, 40);
            this.noteTXTBOX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "бележка:";
            // 
            // providerTXTBOX
            // 
            this.providerTXTBOX.Location = new System.Drawing.Point(415, 458);
            this.providerTXTBOX.Name = "providerTXTBOX";
            this.providerTXTBOX.Size = new System.Drawing.Size(100, 40);
            this.providerTXTBOX.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "доставчик:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // receiverTXTBOX
            // 
            this.receiverTXTBOX.Location = new System.Drawing.Point(707, 458);
            this.receiverTXTBOX.Name = "receiverTXTBOX";
            this.receiverTXTBOX.Size = new System.Drawing.Size(100, 40);
            this.receiverTXTBOX.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "приемащ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "не променяйте ID!";
            // 
            // DeliveryChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receiverTXTBOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.providerTXTBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteTXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visualiseBttn);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DeliveryChange";
            this.Text = "DeliveryChange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.Button visualiseBttn;
        private System.Windows.Forms.TextBox noteTXTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox providerTXTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receiverTXTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}