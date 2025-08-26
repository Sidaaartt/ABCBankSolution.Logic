using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCBankSolution.Logic.Services;


namespace SampleBankWinForms
{
    public partial class LoginForm : Form
    {

        private UserService userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            if (userService.ValidateUser(email, password))
            {
                MessageBox.Show("Login successful!");
                var bankingMenu = new BankingMenuForm(email);
                bankingMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {


            var createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();

        }
    }
}
