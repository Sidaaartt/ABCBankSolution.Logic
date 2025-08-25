using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBankSolution.Logic.Models
{
    public static class BankAccountDbContext
    {
        public static readonly List<BankAccount> BankAccounts;

        static BankAccountDbContext()
        {
            BankAccounts = InitializeBankAccounts();
        }

        private static List<BankAccount> InitializeBankAccounts()
        {
            return
            [
                new("john.smith@example.com", "P@ssw0rd2025!", 5487.92m),
                new("emma.wilson@example.com", "Secur3P@ss!", 12750.45m),
                new("michael.brown@example.com", "C0mpl3x#2025", 3298.67m),
                new("sarah.davis@example.com", "Str0ngP@ss25", 8965.33m),
                new("robert.johnson@example.com", "B@nk2025Acc!", 15420.18m),
                new("lisa.anderson@example.com", "P@ssw0rd123!", 7623.50m),
                new("david.miller@example.com", "Sec#reP@ss25", 4298.75m),
                new("jennifer.taylor@example.com", "T@ylor2025!", 9876.44m),
                new("william.white@example.com", "Wh!teP@ss25", 6543.21m),
                new("patricia.martin@example.com", "M@rt!n2025", 11234.56m),
                new("james.thompson@example.com", "Th0mps0n#25", 3567.89m),
                new("elizabeth.clark@example.com", "Cl@rk2025!", 8901.23m),
                new("richard.hall@example.com", "H@llP@ss25", 7654.32m),
                new("susan.lee@example.com", "L33P@ss2025", 4321.98m),
                new("thomas.wright@example.com", "Wr!ght2025#", 9876.54m),
                new("mary.scott@example.com", "Sc0ttP@ss!", 6789.01m),
                new("charles.green@example.com", "Gr33nP@ss25", 5432.10m),
                new("margaret.baker@example.com", "B@ker2025!", 10987.65m),
                new("joseph.adams@example.com", "Ad@ms#P@ss", 3210.45m),
                new("barbara.king@example.com", "K!ngd0m2025", 8765.43m),
                new("christopher.hill@example.com", "H!llT0p2025", 6543.21m),
                new("karen.evans@example.com", "Ev@ns2025!", 12345.67m),
                new("daniel.cooper@example.com", "C00perP@ss!", 7890.12m),
                new("nancy.morgan@example.com", "M0rg@n2025", 4567.89m),
                new("kevin.phillips@example.com", "Ph!ll!ps25", 9012.34m)
            ];
        }
    }
}
