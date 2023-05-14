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
    public partial class SaleChanging : Form
    {
        List<Scrapping> scrappings = new List<Scrapping>();
        DataTable first = new DataTable();
        Database database = new Database();
        public SaleChanging()
        {
            InitializeComponent();
        }

        private void visualiseBttn_Click(object sender, EventArgs e)
        {
            if (idTXTBOX.Text != "")
            {
                first = database.GetTable($"select id, idProduct, quantity from soldproducts where idSale = {idTXTBOX.Text} ");
                dataGridView1.DataSource = first;
            }
        }
        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveBttn_Click(object sender, EventArgs e)
        {
          
            foreach (DataRow row in first.Rows)
            {
                Scrapping scrapping = new Scrapping();
                scrapping.Quantity = int.Parse(row["quantity"].ToString());
                scrapping.IdProduct = int.Parse(row["idProduct"].ToString());
                scrapping.IdScrapping = int.Parse(row["id"].ToString());
                scrappings.Add(scrapping);
            }
            foreach (var item in scrappings)
            {
                database = new Database();
                database.RunQuery($"UPDATE soldproducts SET idProduct={item.IdProduct},quantity={item.Quantity} WHERE id = {item.IdScrapping}");
            }
        }

        private void saveBttn_Click_1(object sender, EventArgs e)
        {
            foreach (DataRow row in first.Rows)
            {
                Scrapping scrapping = new Scrapping();
                scrapping.Quantity = int.Parse(row["quantity"].ToString());
                scrapping.IdProduct = int.Parse(row["idProduct"].ToString());
                scrapping.IdScrapping = int.Parse(row["id"].ToString());
                scrappings.Add(scrapping);
            }
            foreach (var item in scrappings)
            {
                database = new Database();
                database.RunQuery($"UPDATE soldproducts SET idProduct={item.IdProduct},quantity={item.Quantity} WHERE id = {item.IdScrapping}");
            }
        }
    }
}
