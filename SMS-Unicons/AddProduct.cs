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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStockBttn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (priceTXTBOX.Text != "" && nameTXTBOX.Text != "" )
            {
                string query = $"insert into products (name, price, deliveryPrice) values ('{nameTXTBOX.Text}', {priceTXTBOX.Text}, {deliveryPriceTXTBOX.Text} )";
                database.RunQuery(query);
                int idProduct = database.GetId("select id from products order by id desc limit 1");
                MessageBox.Show($"Успешно добавен продукт с ID - {idProduct}", "Успешно добавен продукт");
            }
            else
            {
                MessageBox.Show("No stock to be added", "Something went wrong");
            }
            priceTXTBOX.Text = "";
            nameTXTBOX.Text = "";
            deliveryPriceTXTBOX.Text = "";
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
