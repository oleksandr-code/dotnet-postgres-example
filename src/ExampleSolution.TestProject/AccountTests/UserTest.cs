using System.Collections.Generic;
using System.Linq;
using ExampleSolution.Db.Models;
using FluentAssertions;
using Xunit;

namespace ExampleSolution.TestProject.AccountTests
{
    public class AccountTest : DatabaseTest
    {
        public AccountTest(DatabaseFixture databaseFixture)
            : base(databaseFixture)
        {
        }

        [Fact]
        public void Users_NotEmpty()
        {
            List<Account> accounts = DbContext.Account.ToList();

            accounts.Should().NotBeNullOrEmpty();
        }
    }
}