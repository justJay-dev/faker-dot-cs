using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
namespace Faker
{
    public class Finance
    {

        public static int Account(int length = 8)
        {
            var random = new Random();
            const string chars = "0123456789";
            return Int32.Parse(new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()));
        }

        public static string AccountName()
        {
            var finance = new Locales.Finance();
            return Helpers.Randomize(finance.AccountTypes) + " Account";
        }
    }
}