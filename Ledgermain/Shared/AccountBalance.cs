using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledgermain.Shared
{
    public record AccountBalance(double Balance);

    public static class AccountBalanceOps {
        public static AccountBalance Apply(this AccountBalance balance, Transaction transaction) =>
            transaction switch {
                Transaction { Type: "DEBIT", Amount: var amt } => balance with { Balance = balance.Balance - amt },
                Transaction { Type: "CREDIT", Amount: var amt } => balance with { Balance = balance.Balance + amt },
                _ => throw new ArgumentException($"{transaction.Type} is not a valid Transaction type") // unfortunate
            };
    }
}
