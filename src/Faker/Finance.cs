using System;
using System.Linq;

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
            var sum = 0;
            for (int i = 0; i < routingNumber.Length; i += 3)
            {
                sum += Int32.Parse(routingNumber[i].ToString()) * 3;
                sum += Int32.Parse(routingNumber[i + 1].ToString()) * 7;
                sum += Int32.Parse(routingNumber[i + 2].ToString()) * 0;
            }
            double value = Math.Ceiling(Double.Parse(sum.ToString()) / 10) * 10 - sum;
            return routingNumber + value.ToString();
        }

        /// <summary>
        /// Returns a random masked number
        /// </summary> 
        public string Mask(int length = 4, bool parens = false, bool ellipsis = false)
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
        public string Amount(int min = 0, int max = 1000, int dec = 2, string symbol = "")
        {
            var random = new System.Random();
            var amount = random.Next(min, max) + random.NextDouble();
            return symbol + amount.ToString("F" + dec);
        }
    }
}