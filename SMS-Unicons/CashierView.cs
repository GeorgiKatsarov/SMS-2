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
            dataGridView1.DataSource = db.GetTable("SELECT * FROM products");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

        }

        

        private void CashierView_Load_1(object sender, EventArgs e)
        {
            Database db = new Database();
            dataGridView1.DataSource = db.GetTable("SELECT id, name, price FROM products");
            dataTable.Columns.Add("IDProduct", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(int));
            dataGridView2.DataSource = dataTable;
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
                products.Add(product);
                DataRow newRow = dataTable.NewRow();
                newRow["IDProduct"] = product.Id;
                newRow["Quantity"] = product.Quantity;
                newRow["Price"] = product.Price;

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
            Database database = new Database();
            decimal total = new decimal();
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("Thank you for shoping with us");
            receipt.AppendLine("------------------------------");
            database.RunQuery($"INSERT INTO `sales` (`id`, `numberOfProducts`, `time`) VALUES (NULL, '{products.Count}', CURRENT_TIMESTAMP)");
            foreach (var item in products)
            {
                total += item.Price * item.Quantity;
                receipt.AppendLine($"{item.Id} -- {item.Name} -- {item.Quantity} -- {item.Price}");
                database.RunQuery($"INSERT INTO `soldproducts` (`idSale`, `idProduct`, `quantity`) VALUES ('{database.GetId1(products.Count)}', '{item.Id}', '{item.Quantity}')");
            }

            receipt.AppendLine($"Your total is {total:f2}BGN");
            MessageBox.Show(receipt.ToString());

            products.Clear();
            CashierView cashierView = new CashierView();
            cashierView.Show();
            this.Close();
        }

    }
}
