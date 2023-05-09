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
    public partial class DeliveryChange : Form
    {
        List<Scrapping> scrappings = new List<Scrapping>();
        DataTable first = new DataTable();
        Database database = new Database(); 
        public DeliveryChange()
        {
            InitializeComponent();
        }

        private void visualiseBttn_Click(object sender, EventArgs e)
        {
            if (idTXTBOX.Text != "")
            {
                first = database.GetTable($"select id, idProduct, quantity from deliveredproducts where idDelivery = {idTXTBOX.Text} ");
                dataGridView1.DataSource = first;
            }
            noteTXTBOX.Text = database.GetString($"Select note from deliveries where id = {idTXTBOX.Text}");
            providerTXTBOX.Text = database.GetString($"Select provider from deliveries where id = {idTXTBOX.Text}");
            receiverTXTBOX.Text = database.GetString($"Select receiver from deliveries where id = {idTXTBOX.Text}");
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            database = new Database();
            database.RunQuery($"UPDATE deliveries SET note='{noteTXTBOX.Text}'WHERE id = {idTXTBOX.Text}");
            database = new Database();
            database.RunQuery($"UPDATE deliveries SET receiver='{receiverTXTBOX.Text}'WHERE id = {idTXTBOX.Text}");
            database = new Database();
            database.RunQuery($"UPDATE deliveries SET provider='{providerTXTBOX.Text}'WHERE id = {idTXTBOX.Text}");
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
                database.RunQuery($"UPDATE deliveredproducts SET idProduct={item.IdProduct},quantity={item.Quantity} WHERE id = {item.IdScrapping}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
