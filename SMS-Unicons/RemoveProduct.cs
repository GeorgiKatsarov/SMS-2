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
        DataTable data = new DataTable();
        StringBuilder sb = new StringBuilder();
        List<Scrapping> scrappings;
        public RemoveProduct()
        {
            scrappings = new List<Scrapping>();
            InitializeComponent();
            dataGridView1.DataSource = data;
        }

        private void RemoveStockBttn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("quantity", typeof(int));
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count != 0)
            {
                sb.AppendLine("************************************");
                sb.AppendLine($"Бракуващ - {recievingTXTBOX.Text}");
                sb.AppendLine("************************************");
                sb.AppendLine($"Бележка - {noteTXTBOX.Text}");
                sb.AppendLine("************************************");
                sb.AppendLine("Бракувани стоки:");
                List<Scrapping> scrappings1 = new List<Scrapping>();
                int i = 1;
                foreach (DataRow row in data.Rows)
                {
                    Database db1 = new Database();
                    Product product = db1.Product(int.Parse(row["id"].ToString()));
                    decimal priceOfProduct = product.DeliveryPrice;
                    decimal totalPrice = priceOfProduct * int.Parse(row["quantity"].ToString());
                    string nameOfProduct = product.Name;
                    Scrapping scrapping = new Scrapping();
                    scrapping.IdProduct = int.Parse(row["id"].ToString());
                    scrapping.Quantity = int.Parse(row["quantity"].ToString());
                    scrappings1.Add(scrapping);
                    sb.AppendLine($"{i} - {nameOfProduct} - {priceOfProduct:f2}лв - {row["quantity"].ToString()}бр.");
                }
                Database db2 = new Database();
                db2.RunQuery($"insert into scrapping ( numberOfProducts, scrapper, note) values ({scrappings1.Count}, '{recievingTXTBOX.Text}', '{noteTXTBOX.Text}')");
                db2 = new Database();
                int id = db2.GetId($"select id from scrapping where numberOfProducts = {scrappings1.Count} order by id desc limit 1");
                foreach (var item in scrappings1)
                {
                    db2 = new Database();
                    db2.RunQuery($"INSERT INTO scrappedproducts(idScrapping, idProduct, quantity) VALUES ({id},{item.IdProduct},{item.Quantity})");
                }
                int id1 = db2.GetId($"select id from scrapping where numberOfProducts = {scrappings1.Count} order by time desc limit 1");
                sb.AppendLine($"Номер на бракуване - {id1}");
                MessageBox.Show($"{sb.ToString()}", "Успешно въведенo бракуване");
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }


            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(sb.ToString(), new Font("Time New Romans", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }
    }
}
