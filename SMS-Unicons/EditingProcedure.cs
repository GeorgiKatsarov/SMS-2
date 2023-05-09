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
    public partial class EditingProcedure : Form
    {
        public bool delivery;
        public bool sale;
        public bool scrapping;
        Database database = new Database();
        public EditingProcedure()
        {
            InitializeComponent();
            
        }

        private void EditingProcedure_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delivery)
            {
                database.RunQuery($"UPDATE deliveredproducts SET quantity= {int.Parse(quantityTXTBOX.Text)} WHERE id = {int.Parse(idTXTBOX.Text)}");
            }
            else if (sale)
            {
                database.RunQuery($"UPDATE soldproducts SET quantity= {int.Parse(quantityTXTBOX.Text)} WHERE id = {int.Parse(idTXTBOX.Text)}");
            }
            else if (scrapping)
            {
                database.RunQuery($"UPDATE scrappedproducts SET quantity= {int.Parse(quantityTXTBOX.Text)} WHERE id = {int.Parse(idTXTBOX.Text)}");
            }
            this.Close();
        }

        private void quantityTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
