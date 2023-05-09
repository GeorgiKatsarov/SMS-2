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
    public partial class RemoveCashier : Form
    {
        public RemoveCashier()
        {
            InitializeComponent();
        }

        private void RemoveCashierBttn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.RunQuery($"DELETE FROM `cashiers` WHERE `cashiers`.`id` = {int.Parse(idTXTBOX.Text)}");
            this.Close();
        }
    }
}
