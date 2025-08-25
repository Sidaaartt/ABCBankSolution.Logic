
using ABCBankSolution.Logic.Services;
using System;

namespace ABCBankSolution.ConsoleApp
{
    public class BankingMenu
    {
        private UserService userService = new UserService();
        private BankService accountService = new BankService();

        public void ShowBankingMenu(string username)
        {
            while (true)
            {
                Console.WriteLine("Banking Menu:");
                Console.WriteLine("1. View Account Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ViewAccountBalance(username);
                        break;
                    case "2":
                        DepositMoney(username);
                        break;
                    case "3":
                        WithdrawMoney(username);
                        break;
                    case "4":
                        Console.WriteLine("Exiting the banking menu.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void ViewAccountBalance(string userName)
        {
            var balance = accountService.GetBalance(userName);
            Console.WriteLine($"Balance: {balance}");
        }

        private void DepositMoney(string username)
        {
            Console.Write("Enter amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                accountService.Deposit(username, amount);
                var balance = accountService.GetBalance(username);
                Console.WriteLine($"Deposited {amount}.\nNew balance is {balance}.");
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        private void WithdrawMoney(string username)
        {
            var balance = accountService.GetBalance(username);

            Console.Write("Enter amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 && amount <= balance)
            {
                accountService.Withdraw(username, amount);
                balance = accountService.GetBalance(username);
                Console.WriteLine($"Withdrew {amount}.\nNew balance is {balance}.");
            }
            else
            {
                Console.WriteLine("Invalid amount entered or insufficient funds.");
            }
        }

        public bool StartupMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Create Account");
            Console.WriteLine("3. Exit");
            Console.Write("Choose to Proceed: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter your Username: ");
                var username = Console.ReadLine();
                Console.Write("Enter your Password: ");
                var password = Console.ReadLine();
                if (this.userService.ValidateUser(username, password))
                {
                    Console.WriteLine($"Welcome, {username}!");
                    ShowBankingMenu(username);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Try again.");
                    return true;
                }
            }
            else if (input == "2")
            {
                Console.Write("Enter your Email: ");
                var email = Console.ReadLine();
                Console.Write("Enter your Password: ");
                var password = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal initialBalance))
                {
                    bool created = accountService.CreateAccount(email, password, initialBalance);
                    if (created)
                    {
                        Console.WriteLine("Account created successfully. You can now log in.");
                    }
                    else
                    {
                        Console.WriteLine("Account creation failed. Email may already exist or input is invalid.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid balance entered.");
                }
                return true;
            }
            else if (input == "3")
            {
                Console.WriteLine("Visit Again");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid choice, Choose 1, 2 or 3");
                return true;
            }
        }
    }
}
