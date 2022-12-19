using System;
namespace Faker
{
    public class Date
    {
        /// <summary>
        /// Returns a random date in the past
        /// </summary>
        public static DateTime Past(int maxYears = 1, string refDate = "MM/DD/YYYY")
        {
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            int randMonth = Datatype.Int(1, 12);
            int randDay = Datatype.Int(1, DateTime.DaysInMonth(startHere.Year, randMonth));
            int randYear = Datatype.Int(startHere.Year - maxYears, startHere.Year);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);
        }
        /// <summary>
        /// Returns a random date in the future
        /// </summary>
        public static DateTime Future(int maxYears = 1, string refDate = "MM/DD/YYYY")
        {
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            int randMonth = Datatype.Int(startHere.Month, 12);
            int randDay = Datatype.Int(startHere.Day + 1, DateTime.DaysInMonth(startHere.Year, randMonth));
            int randYear = Datatype.Int(startHere.Year, startHere.Year + maxYears);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);
        }

        /// <summary>
        /// Returns a random date in the recent past
        /// </summary>
        public static DateTime Recent(int days = 15, string refDate = "MM/DD/YYYY")
        {
            int random = Datatype.Int(1, days);
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            return startHere.AddDays(random * -1);

        }
        /// <summary>
        /// Returns a random date in the near future
        /// </summary>
        public static DateTime Soon(int days = 15, string refDate = "MM/DD/YYYY")
        {
            int random = Datatype.Int(1, days);
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            return startHere.AddDays(random);
        }


        /// <summary>
        /// Returns a random date between two dates
        /// </summary>
        public static DateTime Between(string from, string to)
        {
            DateTime start = DateTime.Parse(from);
            DateTime end = DateTime.Parse(to);
            int randMonth = Datatype.Int(start.Month, end.Month);
            int randDay = Datatype.Int(start.Day, DateTime.DaysInMonth(start.Year, randMonth));
            int randYear = Datatype.Int(start.Year, end.Year);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);


        }

        /// <summary>
        /// Returns a random month
        /// If Abbr is true, returns the abbreviated month name
        /// </summary>
        public static string Month(bool abbr = false)
        {
            var date = new Locales.Date.Months();
            if (abbr)
            {
                return Helpers.Randomize(date.Abbr);
            }
            return Helpers.Randomize(date.Wide);
        }
        /// <summary>
        /// Returns a random weekday
        /// If Abbr is true, returns the abbreviated weekday name
        /// </summary>
        public static string Weekday(bool abbr = false)
        {
            var date = new Locales.Date.Weekdays();
            if (abbr)
            {
                return Helpers.Randomize(date.Abbr);
            }
            return Helpers.Randomize(date.Wide);
        }

        //TODO: Support EU style dates IE DD/MM/YYYY

    }
}
