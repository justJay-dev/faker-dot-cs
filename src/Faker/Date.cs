using System;
namespace Faker
{
    public class Date
    {
        public static DateTime Past(int maxYears = 1, string refDate = "MM/DD/YYYY")
        {
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            int randMonth = Datatype.Int(1, 12);
            int randDay = Datatype.Int(1, DateTime.DaysInMonth(startHere.Year, randMonth));
            int randYear = Datatype.Int(startHere.Year - maxYears, startHere.Year);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);
        }
        //this isnt super ideal, but technically works.
        public static DateTime Future(int years = 1, string refDate = "MM/DD/YYYY")
        {
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            int randMonth = Datatype.Int(startHere.Month, 12);
            int randDay = Datatype.Int(startHere.Day, DateTime.DaysInMonth(startHere.Year, randMonth));
            int randYear = Datatype.Int(startHere.Year, startHere.Year + years);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);
        }


        //you are here, dates are hard.
        public static DateTime Between(string from, string to)
        {
            var random = new Random();
            DateTime start = DateTime.Parse(from);
            DateTime end = DateTime.Parse(to);
            var range = Convert.ToInt32(end.Subtract(start).TotalDays);
            return start.AddDays(random.Next(range));
        }
        public static string Month(bool abbr = false)
        {
            var date = new Locales.Date.Months();
            if (abbr)
            {
                return Helpers.Pick.RandomList(date.Abbr);
            }
            return Helpers.Pick.RandomList(date.Wide);
        }
        public static string Weekday(bool abbr = false)
        {
            var date = new Locales.Date.Weekdays();
            if (abbr)
            {
                return Helpers.Pick.RandomList(date.Abbr);
            }
            return Helpers.Pick.RandomList(date.Wide);
        }

    }
}
