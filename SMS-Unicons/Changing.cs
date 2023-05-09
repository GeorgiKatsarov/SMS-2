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
    public partial class Changing : Form
    {
        public Changing()
        {
            InitializeComponent();
        }


        private void priceChangeBttn_Click(object sender, EventArgs e)
        {
            ChangePrice changePrice = new ChangePrice();
            changePrice.Show();
        }

        private void deliveryChangeBttn_Click(object sender, EventArgs e)
        {
            DeliveryChange deliveryChange = new DeliveryChange();
            deliveryChange.Show();
        }
    }
}
