using System;
using System.Collections.Generic;
namespace Faker
{
    public class Phone
    {
        public static string PhoneNumber(string format = "(###) ###-####")
        {
            return Helpers.ReplaceSymbolWithNumber(format, "#");
        }

        public static string PhoneNumberFormat(int index = 0)
        {
            var phone = new Locales.Phone();
            string format = phone.PhoneFormats[index];
            return Helpers.ReplaceSymbolWithNumber(format, "#");
        }

        public static string PhoneFormats()
        {
            var phone = new Locales.Phone();
            return Helpers.Randomize(phone.PhoneFormats);
        }
    }
}