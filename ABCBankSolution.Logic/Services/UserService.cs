
using ABCBankSolution.Logic.Models;
using System.Linq;

namespace ABCBankSolution.Logic.Services
{
    public class UserService
    {
        public bool ValidateUser(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false; // Invalid input
            }
            return BankAccountDbContext.BankAccounts.Any(account =>
                 account.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                 account.Password == password);      
        }
    }
}
