namespace ABCBankSolution.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankingMenu menu = new BankingMenu();
            while (true)
            {
                if (!menu.StartupMenu())
                {
                    break;
                }
            }
        }
    }
}
