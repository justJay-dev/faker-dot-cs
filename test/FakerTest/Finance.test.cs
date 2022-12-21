using System;
using Xunit;
using Faker;

namespace FakerTest.Finance
{
    public class FinanceTest
    {
        [Fact]
        public void AccountTest()
        {
            var account = Faker.Finance.Account();
            Assert.True(account.ToString().Length == 8);
            var accountWithLength = Faker.Finance.Account(10);
            Assert.True(accountWithLength.ToString().Length == 10);
        }

        [Fact]
        public void AccountNameTest()
        {
            var accountName = Faker.Finance.AccountName();
            Assert.True(accountName.Length > 0);
            Assert.Contains("Account", accountName);
        }
    }
}