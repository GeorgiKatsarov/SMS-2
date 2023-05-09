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
    public partial class ChangePrice : Form
    {
        Database database = new Database();
        public ChangePrice()
        {
            InitializeComponent();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {

        }

        private void priceTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceFinderBttn_Click(object sender, EventArgs e)
        {
            if (idTXTBOX.Text != String.Empty)
            {
            Product product = database.Product(int.Parse(idTXTBOX.Text));
            oldDeliveryPriceTXTBOX.Text = product.DeliveryPrice.ToString();
            oldPriceTXTBOX.Text = product.Price.ToString();

            }
        }

        private void priceChangeBttn_Click(object sender, EventArgs e)
        {
            database = new Database();
            database.RunQuery($"UPDATE products set price = {newPriceTXTBOX.Text} where id = {idTXTBOX.Text}");
            database.RunQuery($"UPDATE products set deliveryPrice = {newDeliveryPriceTXTBOX.Text} where id = {idTXTBOX.Text}");
            oldDeliveryPriceTXTBOX.Text = "";
            oldPriceTXTBOX.Text = "";
            idTXTBOX.Text = "";
            newDeliveryPriceTXTBOX.Text = "";
            newPriceTXTBOX.Text = "";
        }
    }
}
