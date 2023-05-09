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
    public partial class RemoveProduct : Form
    {
        List<Scrapping> scrappings;
        public RemoveProduct()
        {
            scrappings = new List<Scrapping>();
            InitializeComponent();
        }

        private void RemoveStockBttn_Click(object sender, EventArgs e)
        {
            Scrapping scrapping = new Scrapping();
            scrapping.Quantity = int.Parse(quantityTXTBOX.Text);
            scrapping.IdProduct = int.Parse(idTXTBOX.Text);
            scrappings.Add(scrapping);
            quantityTXTBOX.Text = "";
            idTXTBOX.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.RunQuery($"INSERT INTO scrapping (numberOfProducts) VALUES ({scrappings.Count})");
            int idScrapping = db.GetId($"select id from scrapping where numberOfProducts = {scrappings.Count} order by time desc limit 1");
            foreach (var item in scrappings)
            {
                item.IdScrapping = idScrapping;
                db.RunQuery($"INSERT INTO `scrappedproducts`(idScrapping, idProduct, quantity) VALUES ({item.IdScrapping},{item.IdProduct},{item.Quantity})");

            }
            this.Close();
        }
    }
}
