
using ABCBankSolution.Logic.Services;
using System;
using System.Windows.Forms;

namespace SampleBankWinForms
{
    public partial class BankingMenuForm : Form
    {
        private readonly string userEmail;
        private readonly BankService bankService = new BankService();

        public BankingMenuForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            MessageBox.Show($"Welcome, {email}!");
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            var balance = bankService.GetBalance(userEmail);
            if (balance != null)
            {
                MessageBox.Show("Your current balance is ₹" + balance);
            }
            else
            {
                MessageBox.Show("Balance not available.");
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out var amount))
            {
                if (bankService.Deposit(userEmail, amount))
                    MessageBox.Show($"₹{amount} deposited successfully.");
                else
                    MessageBox.Show("Deposit failed. Please check the amount.");
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out var amount))
            {
                if (bankService.Withdraw(userEmail, amount))
                    MessageBox.Show($"₹{amount} withdrawn successfully.");
                else
                    MessageBox.Show("Withdrawal failed. Check balance or amount.");
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
