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
    public partial class CashierView : Form
    {
        StringBuilder receipt = new StringBuilder();
        List<Product> products;
        DataTable dataTable = new DataTable();
        public CashierView()
        {
            products = new List<Product>();
            InitializeComponent();
        }

        private void CashierView_Load(object sender, EventArgs e)
        {
            Database db = new Database();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

        }

        

        private void CashierView_Load_1(object sender, EventArgs e)
        {
            Database db = new Database();
            dataGridView2.DataSource = dataTable;
            dataTable.Columns.Add("IDProduct", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(decimal));


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (idTXTBOX.Text != "" && quantityTXTBOX.Text != "")
            {
                Database database = new Database();
                Product product = database.Product(int.Parse(idTXTBOX.Text), int.Parse(quantityTXTBOX.Text));
                DataRow newRow = dataTable.NewRow();
                newRow["IDProduct"] = product.Id;
                newRow["ProductName"] = product.Name;
                newRow["Quantity"] = product.Quantity;
                newRow["Price"] = product.Price;
                dataTable.Rows.Add(newRow);

                idTXTBOX.Text = "";
                quantityTXTBOX.Text = "";
            }
            else
            {
                MessageBox.Show("You have to fill both text boxes");
                idTXTBOX.Text = "";
                quantityTXTBOX.Text = "";
            }
        }

        private void finaliseButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product();
                product.Id = int.Parse(row["IDProduct"].ToString());
                product.Quantity = int.Parse(row["Quantity"].ToString());
                product.Price = decimal.Parse(row["Price"].ToString());
                product.Name = row["ProductName"].ToString();
                products.Add(product);
            }
            Database database = new Database();
            decimal total = new decimal();
            receipt.AppendLine("Благордарим Ви, че избрахте нас");
            receipt.AppendLine("------------------------------");
            database.RunQuery($"INSERT INTO `sales` (`id`, `numberOfProducts`, `time`) VALUES (NULL, '{products.Count}', CURRENT_TIMESTAMP)");
            foreach (var item in products)
            {
                total += item.Price * item.Quantity;
                receipt.AppendLine($"{item.Id} -- {item.Name} -- {item.Quantity} -- {item.Price}лв");
                database.RunQuery($"INSERT INTO `soldproducts` (`idSale`, `idProduct`, `quantity`) VALUES ('{database.GetId1(products.Count)}', '{item.Id}', '{item.Quantity}')");
            }

            receipt.AppendLine($"Обща цена {total:f2}лв");
            receipt.AppendLine($"Номер на продажбата - {database.GetId($"Select id from sales where numberOfProducts = {products.Count} order by time desc limit 1")}");
            MessageBox.Show(receipt.ToString());
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            products.Clear();
            CashierView cashierView = new CashierView();
            cashierView.Show();
            this.Close();
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            CashierView cashier = new CashierView();
            cashier.Show();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.ToString(), new Font("Time New Romans", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }
    }
}
