using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Unicons
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            AdminView childForm = new AdminView();
            childForm.Show();
            this.Close();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            StockDataGridView.DataSource = db.GetTable("select * from products");
            CashierDataGridView.DataSource = db.GetTable("select * from cashiers");
        }

        private void addStockBttn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void addCashierBttn_Click(object sender, EventArgs e)
        {
            AddCashier addCashier = new AddCashier();
            addCashier.Show();
        }

        private void removeCashierBttn_Click(object sender, EventArgs e)
        {
            RemoveCashier removeCashier = new RemoveCashier();  
            removeCashier.Show();
        }

        private void removeStockBttn_Click(object sender, EventArgs e)
        {
            RemoveProduct removeProduct = new RemoveProduct();
            removeProduct.Show();
        }

        private void CashierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addMore_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.Show();
        }

        private void AccountingBttn_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();
        }

        private void changeBttn_Click(object sender, EventArgs e)
        {
            Changing changing = new Changing();
            changing.Show();
        }

        private void StockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceChangeBttn_Click(object sender, EventArgs e)
        {
           ChangePrice changePrice = new ChangePrice();
            changePrice.Show();
        }
    }
}
