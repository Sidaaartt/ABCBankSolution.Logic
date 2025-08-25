using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBankSolution.Logic.Models
{
    public class BankAccount
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    
    public BankAccount(string email, string password, decimal balance)
        {
            Email = email;
            Password = password;
            Balance = balance;
        }
    }
}
