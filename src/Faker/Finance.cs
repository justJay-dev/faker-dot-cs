using System;
using System.Linq;
using System.Collections.Generic;

namespace Faker
{
    public class Finance
    {

        /// <summary>
        /// Returns a random account number as an integer, default length of 8
        /// </summary>
        public static int Account(int length = 8)
        {
            var random = new System.Random();
            const string chars = "0123456789";
            return Int32.Parse(new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()));
        }

        /// <summary>
        /// Returns a random account name as a string
        /// "Checking Account", "Savings Account", "Money Market Account", "Credit Card Account", "Loan Account"
        /// </summary>
        public static string AccountName()
        {
            var finance = new Locales.Finance();
            return Helpers.Randomize(finance.AccountTypes) + " Account";
        }

        /// <summary>
        /// Returns a randomly generated routing number
        /// </summary>
        public static string RoutingNumber()
        {
            var random = new System.Random();
            const string chars = "0123456789";
            var routingNumber = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            int sum = 0;
            for (int i = 0; i < routingNumber.Length; i++)
            {
                // Multiply each digit by the corresponding weight
                int weight = (i % 2 == 0) ? 3 : 7;
                sum += Int32.Parse(routingNumber[i].ToString()) * weight;
            }

            // Calculate the check digit by taking the remainder of the sum divided by 10 and subtracting it from 10
            int checkDigit = 10 - (sum % 10);
            if (checkDigit == 10) checkDigit = 0;

            // Append the check digit to the routing number
            return routingNumber += checkDigit.ToString();
        }

        /// <summary>
        /// Returns a random masked number
        /// </summary> 
        public static string Mask(int length = 4, bool parens = false, bool ellipsis = false)
        {
            var random = new System.Random();
            const string chars = "0123456789";
            var mask = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            if (parens)
            {
                mask = "(" + mask + ")";
            }
            if (ellipsis)
            {
                mask = mask + "...";
            }
            return mask;
        }

        /// <summary>
        /// Returns a random amount as a string
        /// </summary>
        public static string Amount(int min = 0, int max = 1000, int dec = 2, string symbol = "")
        {
            var random = new System.Random();
            var amount = random.Next(min, max) + random.NextDouble();
            return symbol + amount.ToString("F" + dec);
        }

        /// <summary>
        /// Returns a random transaction type
        /// "deposit", "withdrawal", "payment", "transfer", "invoice"
        /// </summary>
        public static string TransactionType()
        {
            var finance = new Locales.Finance();
            return Helpers.Randomize(finance.TransactionType);
        }

        /// <summary>
        /// Returns a random currency code
        /// </summary>
        /* todo
        public static string CurrencyCode()
        {
            var finance = new Locales.Finance();
            Dictionary<string, dynamic> selected = Helpers.Randomize(finance.Currency);
            return selected.code;

        }
        */

        /// <summary>
        /// Returns a random bitcoin address
        /// </summary>
        public static string BitcoinAddress()
        {
            var random = new System.Random();
            const string chars = "0123456789abcdef";
            return new string(Enumerable.Repeat(chars, 34).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Returns a random credit card number
        /// </summary>

        //TODO this is still broken.
        public static string CreditCardNumber(string provider = "any")
        {
            var finance = new Locales.Finance();
            var random = new System.Random();
            var creditCard = new Locales.Finance.CreditCard();
            var selected = "";
            switch (provider)
            {

                case "american_express":
                    selected = Helpers.Randomize(creditCard.AmericanExpress);
                    break;
                case "diners_club":
                    selected = Helpers.Randomize(creditCard.DinersClub);
                    break;
                case "discover":
                    selected = Helpers.Randomize(creditCard.Discover);
                    break;
                case "instapayment":
                    selected = Helpers.Randomize(creditCard.Instapayment);
                    break;
                case "jcb":
                    string jcb = Helpers.Randomize(creditCard.JCB);
                    //if [3-8] exists in jcb, replace with a random number between 3 and 8
                    if (jcb.IndexOf("[3-8]") > -1)
                    {
                        jcb = jcb.Replace("[3-8]", random.Next(3, 8).ToString());
                    }
                    selected = jcb;
                    break;
                case "laser":
                    selected = Helpers.Randomize(creditCard.Laser);
                    break;
                case "maestro":
                    selected = Helpers.Randomize(creditCard.Maestro);
                    break;
                case "mastercard":
                    string mastercard = Helpers.Randomize(creditCard.MasterCard);
                    // if [1-5] exists in mastercard, replace with a random number between 1 and 5
                    if (mastercard.IndexOf("[1-5]") > -1)
                    {
                        mastercard = mastercard.Replace("[1-5]", random.Next(1, 5).ToString());
                    }
                    break;
                case "solo":
                    selected = Helpers.Randomize(creditCard.Solo);
                    break;
                case "switch":
                    selected = Helpers.Randomize(creditCard.Switch);
                    break;
                case "visa":
                    selected = Helpers.Randomize(creditCard.Visa);
                    break;
                default:
                    selected = Helpers.Randomize(creditCard.Visa);
                    break;
            }
            return Helpers.ReplaceSymbolWithNumber(selected);


        }

        /// <summary>
        /// Returns a random ethereum address
        /// </summary>
        public static string EthereumAddress()
        {
            var random = new System.Random();
            const string chars = "0123456789abcdef";
            return new string(Enumerable.Repeat(chars, 40).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Returns a random litecoin address
        /// </summary>
        public static string LitecoinAddress()
        {
            var random = new System.Random();
            const string chars = "0123456789abcdef";
            return new string(Enumerable.Repeat(chars, 34).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Returns a random iban
        /// </summary>
        public static string Iban(bool formatted = false)
        {
            var random = new System.Random();
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var iban = new string(Enumerable.Repeat(chars, 16).Select(s => s[random.Next(s.Length)]).ToArray());
            if (formatted)
            {
                iban = iban.Insert(4, " ");
                iban = iban.Insert(9, " ");
                iban = iban.Insert(14, " ");
            }
            return iban;
        }

        /// <summary>
        /// Returns a random bic
        /// </summary>
        public static string Bic()
        {
            var random = new System.Random();
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());

        }
    }
}