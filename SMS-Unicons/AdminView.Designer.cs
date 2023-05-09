namespace SMS_Unicons
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.AccountingBttn = new System.Windows.Forms.Button();
            this.addMore = new System.Windows.Forms.Button();
            this.CashierDataGridView = new System.Windows.Forms.DataGridView();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.removeCashierBttn = new System.Windows.Forms.Button();
            this.removeStockBttn = new System.Windows.Forms.Button();
            this.refreshBttn = new System.Windows.Forms.Button();
            this.addCashierBttn = new System.Windows.Forms.Button();
            this.addStockBttn = new System.Windows.Forms.Button();
            this.changeBttn = new System.Windows.Forms.Button();
            this.priceChangeBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CashierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountingBttn
            // 
            this.AccountingBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.AccountingBttn.Location = new System.Drawing.Point(804, 474);
            this.AccountingBttn.Name = "AccountingBttn";
            this.AccountingBttn.Size = new System.Drawing.Size(143, 115);
            this.AccountingBttn.TabIndex = 22;
            this.AccountingBttn.Text = "Справки";
            this.AccountingBttn.UseVisualStyleBackColor = false;
            this.AccountingBttn.Click += new System.EventHandler(this.AccountingBttn_Click);
            // 
            // addMore
            // 
            this.addMore.BackColor = System.Drawing.Color.AliceBlue;
            this.addMore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.addMore.Location = new System.Drawing.Point(804, 355);
            this.addMore.Name = "addMore";
            this.addMore.Size = new System.Drawing.Size(143, 113);
            this.addMore.TabIndex = 20;
            this.addMore.Text = "Доставка";
            this.addMore.UseVisualStyleBackColor = false;
            this.addMore.Click += new System.EventHandler(this.addMore_Click);
            // 
            // CashierDataGridView
            // 
            this.CashierDataGridView.AllowUserToAddRows = false;
            this.CashierDataGridView.AllowUserToDeleteRows = false;
            this.CashierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CashierDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.CashierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashierDataGridView.Location = new System.Drawing.Point(177, 342);
            this.CashierDataGridView.Name = "CashierDataGridView";
            this.CashierDataGridView.ReadOnly = true;
            this.CashierDataGridView.RowHeadersWidth = 62;
            this.CashierDataGridView.RowTemplate.Height = 28;
            this.CashierDataGridView.Size = new System.Drawing.Size(423, 261);
            this.CashierDataGridView.TabIndex = 19;
            this.CashierDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CashierDataGridView_CellContentClick);
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGridView.Location = new System.Drawing.Point(161, 42);
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.StockDataGridView.RowTemplate.Height = 28;
            this.StockDataGridView.Size = new System.Drawing.Size(624, 272);
            this.StockDataGridView.TabIndex = 18;
            this.StockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGridView_CellContentClick);
            // 
            // removeCashierBttn
            // 
            this.removeCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.removeCashierBttn.Location = new System.Drawing.Point(12, 488);
            this.removeCashierBttn.Name = "removeCashierBttn";
            this.removeCashierBttn.Size = new System.Drawing.Size(143, 113);
            this.removeCashierBttn.TabIndex = 17;
            this.removeCashierBttn.Text = "Махане касиер";
            this.removeCashierBttn.UseVisualStyleBackColor = false;
            this.removeCashierBttn.Click += new System.EventHandler(this.removeCashierBttn_Click);
            // 
            // removeStockBttn
            // 
            this.removeStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.removeStockBttn.Font = new System.Drawing.Font("Palatino Linotype", 11.5F, System.Drawing.FontStyle.Bold);
            this.removeStockBttn.Location = new System.Drawing.Point(12, 369);
            this.removeStockBttn.Name = "removeStockBttn";
            this.removeStockBttn.Size = new System.Drawing.Size(143, 113);
            this.removeStockBttn.TabIndex = 16;
            this.removeStockBttn.Text = "Бракуване стока";
            this.removeStockBttn.UseVisualStyleBackColor = false;
            this.removeStockBttn.Click += new System.EventHandler(this.removeStockBttn_Click);
            // 
            // refreshBttn
            // 
            this.refreshBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.refreshBttn.Location = new System.Drawing.Point(12, 12);
            this.refreshBttn.Name = "refreshBttn";
            this.refreshBttn.Size = new System.Drawing.Size(143, 113);
            this.refreshBttn.TabIndex = 15;
            this.refreshBttn.Text = "Oбнови";
            this.refreshBttn.UseVisualStyleBackColor = false;
            this.refreshBttn.Click += new System.EventHandler(this.refreshBttn_Click);
            // 
            // addCashierBttn
            // 
            this.addCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addCashierBttn.Location = new System.Drawing.Point(12, 250);
            this.addCashierBttn.Name = "addCashierBttn";
            this.addCashierBttn.Size = new System.Drawing.Size(143, 113);
            this.addCashierBttn.TabIndex = 14;
            this.addCashierBttn.Text = "Добави касиер";
            this.addCashierBttn.UseVisualStyleBackColor = false;
            this.addCashierBttn.Click += new System.EventHandler(this.addCashierBttn_Click);
            // 
            // addStockBttn
            // 
            this.addStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addStockBttn.Location = new System.Drawing.Point(12, 131);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(143, 113);
            this.addStockBttn.TabIndex = 13;
            this.addStockBttn.Text = "Добави продукт";
            this.addStockBttn.UseVisualStyleBackColor = false;
            this.addStockBttn.Click += new System.EventHandler(this.addStockBttn_Click);
            // 
            // changeBttn
            // 
            this.changeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.changeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.changeBttn.Location = new System.Drawing.Point(804, 171);
            this.changeBttn.Name = "changeBttn";
            this.changeBttn.Size = new System.Drawing.Size(143, 59);
            this.changeBttn.TabIndex = 23;
            this.changeBttn.Text = "Промяна";
            this.changeBttn.UseVisualStyleBackColor = false;
            this.changeBttn.Click += new System.EventHandler(this.changeBttn_Click);
            // 
            // priceChangeBttn
            // 
            this.priceChangeBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.priceChangeBttn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.priceChangeBttn.Location = new System.Drawing.Point(804, 236);
            this.priceChangeBttn.Name = "priceChangeBttn";
            this.priceChangeBttn.Size = new System.Drawing.Size(143, 113);
            this.priceChangeBttn.TabIndex = 24;
            this.priceChangeBttn.Text = "Промяна на цени";
            this.priceChangeBttn.UseVisualStyleBackColor = false;
            this.priceChangeBttn.Click += new System.EventHandler(this.priceChangeBttn_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 615);
            this.Controls.Add(this.priceChangeBttn);
            this.Controls.Add(this.changeBttn);
            this.Controls.Add(this.AccountingBttn);
            this.Controls.Add(this.addMore);
            this.Controls.Add(this.CashierDataGridView);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.removeCashierBttn);
            this.Controls.Add(this.removeStockBttn);
            this.Controls.Add(this.refreshBttn);
            this.Controls.Add(this.addCashierBttn);
            this.Controls.Add(this.addStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CashierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountingBttn;
        private System.Windows.Forms.Button addMore;
        private System.Windows.Forms.DataGridView CashierDataGridView;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.Button removeCashierBttn;
        private System.Windows.Forms.Button removeStockBttn;
        private System.Windows.Forms.Button refreshBttn;
        private System.Windows.Forms.Button addCashierBttn;
        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.Button changeBttn;
        private System.Windows.Forms.Button priceChangeBttn;
    }
}