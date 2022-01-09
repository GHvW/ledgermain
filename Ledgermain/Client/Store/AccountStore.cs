using Ledgermain.Shared;

using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Ledgermain.Client.Store;

public static class AccountStore {

    public static IObservable<AccountBalance> Create(
        this IObservable<Transaction> transactions, 
        AccountBalance initialBalance) =>
            transactions.Scan(initialBalance, AccountBalanceOps.Apply);
}
