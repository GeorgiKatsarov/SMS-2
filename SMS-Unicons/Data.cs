using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;


namespace SMS_Unicons
{
    public partial class Data : Form
    {
        Database database = new Database();
        public Data()
        {
            
            InitializeComponent();
        }

        private void DeliveriesBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT deliveredproducts.id, products.name, products.deliveryPrice, deliveredproducts.quantity, deliveredproducts.idDelivery, deliveries.date FROM deliveredproducts inner join products on deliveredproducts.idProduct = products.id inner join deliveries on deliveredproducts.idDelivery = deliveries.id");
        }

        private void SalesBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT soldproducts.id, products.name, products.price, soldproducts.quantity, soldproducts.idSale, sales.time FROM soldproducts inner join products on soldproducts.idProduct = products.id inner join sales on soldproducts.idSale = sales.id");
        }

        private void ScrappingBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT scrappedproducts.id, products.name, products.price, scrappedproducts.quantity, scrappedproducts.idScrapping, scrapping.time  FROM scrappedproducts inner join products on scrappedproducts.idProduct = products.id inner join scrapping on scrappedproducts.idScrapping = scrapping.id");
        }

        private void stockBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT p.id, p.name, p.price, p.deliveryPrice, COALESCE(d.deliveredQuantity, 0) AS deliveredQuantity, COALESCE(s.soldQuantity, 0) AS soldQuantity, COALESCE(r.scrappedQuantity, 0) AS scrappedQuantity, COALESCE(d.deliveredQuantity, 0) - COALESCE(s.soldQuantity, 0) - COALESCE(r.scrappedQuantity, 0) AS availableQuantity FROM products p LEFT OUTER JOIN (SELECT idProduct, SUM(quantity) AS deliveredQuantity FROM deliveredproducts GROUP BY idProduct) d ON p.id = d.idProduct LEFT OUTER JOIN (SELECT idProduct, SUM(quantity) AS soldQuantity FROM soldproducts GROUP BY idProduct) s ON p.id = s.idProduct LEFT OUTER JOIN (SELECT idProduct, SUM(quantity) AS scrappedQuantity FROM scrappedproducts GROUP BY idProduct) r ON p.id = r.idProduct");
        }

        private void revenueBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT p.id, p.name, COALESCE(s.soldQuantity, 0) AS soldQuantity, p.price AS unitPrice, p.deliveryPrice AS deliveryCost, COALESCE(s.soldQuantity, 0) * p.price AS revenue, COALESCE(s.soldQuantity, 0) * (p.price - p.deliveryPrice) AS profit FROM products p LEFT OUTER JOIN (SELECT idProduct, SUM(quantity) AS soldQuantity FROM soldproducts GROUP BY idProduct) s ON p.id = s.idProduct UNION ALL SELECT NULL, 'Total', COALESCE(SUM(s.soldQuantity), 0), NULL, NULL, COALESCE(SUM(s.soldQuantity * p.price), 0), COALESCE(SUM(s.soldQuantity * (p.price - p.deliveryPrice)), 0) FROM products p LEFT OUTER JOIN (SELECT idProduct, SUM(quantity) AS soldQuantity FROM soldproducts GROUP BY idProduct) s ON p.id = s.idProduct");
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void delivery2Bttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.GetTable("SELECT * from deliveries");
        }
    }
    
}
