using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SMS_Unicons
{
    public partial class Delivery : Form
    {
        
        DataTable data = new DataTable();
        Decimal totalBeforeTax = 0;
        Decimal tax = 0;
        StringBuilder sb = new StringBuilder();
        public Delivery()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count != 0)
            {
                sb.AppendLine("**********************");
                sb.AppendLine($"Доставчик - {providerTXTBOX.Text}");
                sb.AppendLine($"Приемащ - {recievingTXTBOX.Text}");
                sb.AppendLine($"Бележка - {noteTXTBOX.Text}");
                sb.AppendLine("**********************");
                sb.AppendLine("Успешно добавени продукти:");
                sb.AppendLine();
                List<Scrapping> scrappings1 = new List<Scrapping>();
                int i = 1; 
                foreach (DataRow row in data.Rows)
                {
                    Database db1 = new Database();
                    Product product = db1.Product(int.Parse(row["IDProduct"].ToString()));
                    decimal priceOfProduct = product.DeliveryPrice;
                    decimal totalPrice = priceOfProduct* int.Parse(row["Quantity"].ToString());
                    string nameOfProduct = product.Name;
                    Scrapping scrapping = new Scrapping();
                    scrapping.IdProduct = int.Parse(row["IDProduct"].ToString());
                    scrapping.Quantity = int.Parse(row["Quantity"].ToString());
                    scrappings1.Add(scrapping);
                    sb.AppendLine($"{i} - {nameOfProduct} - {priceOfProduct:f2}лв - {row["Quantity"].ToString()}");
                    totalBeforeTax+= totalPrice;
                    tax += totalPrice* 0.2m;
                }
                sb.AppendLine("**********************");
                sb.AppendLine($"Цена на продукти без ДДС - {totalBeforeTax:f2}лв");
                sb.AppendLine($"ДДС - {tax:f2}лв");
                sb.AppendLine($"Цена на продукти с ДДС - {tax+totalBeforeTax:f2}лв");
                sb.AppendLine("**********************");
                // Save the data in the list to the database
                Database db = new Database();
                db.RunQuery($"INSERT INTO deliveries (numberOfProducts,note, provider, receiver) VALUES ({scrappings1.Count},'{noteTXTBOX.Text}', '{providerTXTBOX.Text}', '{recievingTXTBOX.Text}')");

                int idScrapping = db.GetId($"select id from deliveries where numberOfProducts = {scrappings1.Count} order by date desc limit 1");
                sb.AppendLine($"Номер на доставката - {idScrapping}");
                foreach (var item in scrappings1)
                {
                    item.IdScrapping = idScrapping;
                    db.RunQuery($"INSERT INTO `deliveredproducts`(idDelivery, idProduct, quantity) VALUES ({item.IdScrapping},{item.IdProduct},{item.Quantity})");

                }
                
                MessageBox.Show($"{sb.ToString()}", "Успешно въведена доставка");
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

            }
            
            // Close the form
            this.Close();
        }
   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            data.Columns.Add("IDProduct", typeof(int));
            data.Columns.Add("Quantity", typeof(int));
            dataGridView1.DataSource = data;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewProductBttn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(sb.ToString(), new Font("Time New Romans", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void priceChangeButton_Click(object sender, EventArgs e)
        {
            ChangePrice changePrice = new ChangePrice();
            changePrice.Show();
        }
    }
}
