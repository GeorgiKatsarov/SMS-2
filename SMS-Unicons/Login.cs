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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CashierBttn_Click(object sender, EventArgs e)
        {
        }

        private void adminBttn_Click(object sender, EventArgs e)
        {
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void adminBttn_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Database database = new Database();
                if (database.AdminCheckIn(nameTextBox.Text, passwordTextBox.Text) == true)
                {
                    AdminView childForm = new AdminView();
                    childForm.Show();
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
            else
            {
                MessageBox.Show("Fill the information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            passwordTextBox.Text = "";
            nameTextBox.Text = "";
        }

        private void CashierBttn_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Database database = new Database();
                if (database.CashierCheckIn(nameTextBox.Text, passwordTextBox.Text) == true)
                {
                    CashierView childForm = new CashierView();
                    childForm.Show();
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
            else
            {
                MessageBox.Show("Fill the information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            passwordTextBox.Text = "";
            nameTextBox.Text = "";
        }
    }
}
