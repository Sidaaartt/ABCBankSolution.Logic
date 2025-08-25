
using ABCBankSolution.Logic.Models;
using System.Linq;

namespace ABCBankSolution.Logic.Services
{
    public class BankService
    {
        public BankAccount GetBankAccount(string email)
        {
            return BankAccountDbContext.BankAccounts
                .FirstOrDefault(a => a.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase));
        }

        public decimal? GetBalance(string email)
        {
            
            return GetBankAccount(email)?.Balance;
        }

        public bool Deposit(string email, decimal amount)
        {
            var account = GetBankAccount(email);
            if (account != null && amount > 0)
            {
                account.Balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(string email, decimal amount)
        {
            var account = GetBankAccount(email);
            if (account != null && amount > 0 && account.Balance >= amount)
            {
                account.Balance -= amount;
                return true;
            }
            return false;
        }

        public bool CreateAccount(string email, string password, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return false;

            if (BankAccountDbContext.BankAccounts.Any(a => a.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase)))
                return false;

            BankAccountDbContext.BankAccounts.Add(new BankAccount(email, password, initialBalance));
            return true;
        }
    }
}
