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

        [Fact]
        public void RoutingNumberTest()
        {
            var routingNumber = Faker.Finance.RoutingNumber();
            Assert.True(routingNumber.Length == 9);
        }

        [Fact]
        public void MaskTest()
        {
            var mask = Faker.Finance.Mask();
            Assert.True(mask.Length == 4);
            var maskWithLength = Faker.Finance.Mask(10);
            Assert.True(maskWithLength.Length == 10);
            var maskWithParens = Faker.Finance.Mask(10, true);
            Assert.True(maskWithParens.Length == 12);
            Assert.Contains("(", maskWithParens);
            Assert.Contains(")", maskWithParens);
            var maskWithEllipsis = Faker.Finance.Mask(10, false, true);
            Assert.True(maskWithEllipsis.Length == 13);
            Assert.Contains("...", maskWithEllipsis);
        }

        [Fact]
        public void AmountTest()
        {
            var amount = Double.Parse(Faker.Finance.Amount());
            Assert.True(amount > 0);
            var amountWithMin = Double.Parse(Faker.Finance.Amount(100));
            Assert.True(amountWithMin > 100);
            var amountWithMinAndMax = Double.Parse(Faker.Finance.Amount(100, 200));
            Assert.True(amountWithMinAndMax > 100);
            Assert.True(amountWithMinAndMax < 200);

            var amountWithSymbolTest = Faker.Finance.Amount(symbol: "$");
            Assert.True(amountWithSymbolTest.Length > 0);
            Assert.Contains("$", amountWithSymbolTest);
        }

        [Fact]
        public void CreditCardNumberTest()
        {
            var creditCard = Faker.Finance.CreditCardNumber();
            Assert.True(creditCard.Length == 19);
            //assert ends with L
            Assert.EndsWith("L", creditCard);
            var americanExpress = Faker.Finance.CreditCardNumber("american_express");
            //assert starts with 37 or 34
            Assert.True(americanExpress.StartsWith("37") || americanExpress.StartsWith("34"));
            var dinersClub = Faker.Finance.CreditCardNumber("diners_club");
            //assert starts with 30 or 36 or 38
            Assert.True(dinersClub.StartsWith("30") || dinersClub.StartsWith("36") || dinersClub.StartsWith("38"));
            var discover = Faker.Finance.CreditCardNumber("discover");
            //assert starts with 6011 or 65
            Assert.True(discover.StartsWith("6011") || discover.StartsWith("65"));
            var instapayment = Faker.Finance.CreditCardNumber("instapayment");
            //assert starts with 63
            Assert.True(instapayment.StartsWith("63"));
            var jcb = Faker.Finance.CreditCardNumber("jcb");
            //assert starts with 35
            Assert.True(jcb.StartsWith("35"));
            var laser = Faker.Finance.CreditCardNumber("laser");
            //assert starts with 6304 or 6706 or 6771 or 6709
            Assert.True(laser.StartsWith("6304") || laser.StartsWith("6706") || laser.StartsWith("6771") || laser.StartsWith("6709"));
            var maestro = Faker.Finance.CreditCardNumber("maestro");
            //assert starts with 50, 56, 57, 58, 60, 62, 67
            Assert.True(maestro.StartsWith("50") || maestro.StartsWith("56") || maestro.StartsWith("57") || maestro.StartsWith("58") || maestro.StartsWith("60") || maestro.StartsWith("62") || maestro.StartsWith("67"));
            var mastercard = Faker.Finance.CreditCardNumber("mastercard");
            //assert starts with 6771-89 or 5,
            Assert.True(mastercard.StartsWith("6771-89") || mastercard.StartsWith("5"));
            var solo = Faker.Finance.CreditCardNumber("solo");
            //assert starts with 6334 or 6767
            Assert.True(solo.StartsWith("6334") || solo.StartsWith("6767"));
            var switch_ = Faker.Finance.CreditCardNumber("switch");
            //assert starts with 6759
            Assert.True(switch_.StartsWith("6759"));
            var visa = Faker.Finance.CreditCardNumber("visa");
            //assert starts with 4
            Assert.True(visa.StartsWith("4"));

        }

        [Fact]
        public void TransactionTypeTest()
        {
            var transactionType = Faker.Finance.TransactionType();
            Assert.True(transactionType.Length > 0);
            //assert contains any of the following
            Assert.Contains(transactionType, new string[] { "deposit", "withdrawal", "payment", "transfer", "invoice" });
        }


        [Fact]
        public void BitcoinAddressTest()
        {
            var bitcoinAddress = Faker.Finance.BitcoinAddress();
            Assert.True(bitcoinAddress.Length == 34);
        }

        [Fact]
        public void EthereumAddressTest()
        {
            var ethereumAddress = Faker.Finance.EthereumAddress();
            Assert.True(ethereumAddress.Length == 40);
        }

        [Fact]
        public void LitecoinAddressTest()
        {
            var litecoinAddress = Faker.Finance.LitecoinAddress();
            Assert.True(litecoinAddress.Length == 34);
        }


    }
}