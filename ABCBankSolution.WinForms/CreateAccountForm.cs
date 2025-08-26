
using ABCBankSolution.Logic.Services;
using System;
using System.Windows.Forms;

namespace SampleBankWinForms
{
    public partial class CreateAccountForm : Form
    {
        private readonly BankService bankService = new BankService();

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string balanceText = txtInitialBalance.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(balanceText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(balanceText, out var initialBalance) || initialBalance < 0)
            {
                MessageBox.Show("Please enter a valid initial balance.");
                return;
            }

            bool success = bankService.CreateAccount(email, password, initialBalance);

            if (success)
            {
                MessageBox.Show("Account created successfully!");
                new LoginForm().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account creation failed. Email may already exist.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
