using FluentAssertions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Ledgermain.Shared.Test;

public class GivenAnAccountBalance {

    private readonly AccountBalance accountBalance;

    public GivenAnAccountBalance() {
        this.accountBalance = new AccountBalance(100); 
    }

    [Fact]
    public void WhenApplyingACredit() {

        var transaction = new Transaction("CREDIT", 10);

        var result = this.accountBalance.Apply(transaction);

        result.Balance.Should().Be(110);
    }

    [Fact]
    public void WhenApplyingADebit() {

        var transaction = new Transaction("DEBIT", 10);

        var result = accountBalance.Apply(transaction);

        result.Balance.Should().Be(90);
    }
}
