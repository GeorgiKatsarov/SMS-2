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
    public partial class DeletingProcedure : Form
    {
        public bool delivery;
        public bool sale;
        public bool scrapping;
        Database database = new Database();
        public DeletingProcedure()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delivery)
            {
                int idDelivery = database.GetId($"Select idDelivery from deliveredproducts where id = {int.Parse(idTXTBOX.Text)}");
                int number = database.GetId($"Select numberOfProducts from deliveries where id = {idDelivery}") - 1;
                database.RunQuery($"DELETE FROM `deliveredproducts` WHERE id = {int.Parse(idTXTBOX.Text)}");
                database.RunQuery($"UPDATE deliveries set numberOfProducts = {number} where id = {idDelivery}");
                if (database.GetId($"Select numberOfProducts from deliveries where id = {idDelivery}") == 0)
                {
                    database.RunQuery($"Delete from deliveries where id = {idDelivery}");
                }
            }
            else if (sale)
            {
                int idSale = database.GetId($"Select idSale from soldproducts where id = { int.Parse(idTXTBOX.Text)} ");
                int number = database.GetId($"Select numberOfProducts from sales where id = {idSale}") -1;
                database.RunQuery($"delete from soldproducts where id = {int.Parse(idTXTBOX.Text)}");
                database.RunQuery($"UPDATE sales set numberOfProducts = {number} where id = {idSale}");
                if (database.GetId($"Select numberOfProducts from sales where id = {idSale}") == 0)
                {
                    database.RunQuery($"Delete from sales where id = {idSale}");
                }
            }
            else if (scrapping)
            {
                int idScrapping= database.GetId($"Select idScrapping from scrappedproducts where id = { int.Parse(idTXTBOX.Text)} ");
                int number = database.GetId($"Select numberOfProducts from scrapping where id = {idScrapping}") - 1;
                database.RunQuery($"delete from scrappedproducts where id = {int.Parse(idTXTBOX.Text)}");
                database.RunQuery($"UPDATE scrapping set numberOfProducts = {number} where id = {idScrapping}");
                if (database.GetId($"Select numberOfProducts from scrapping where id = {idScrapping}") == 0)
                {
                    database.RunQuery($"Delete from scrapping where id = {idScrapping}");
                }
            }
            idTXTBOX.Text = "";
            this.Close();
        }
    }
}
