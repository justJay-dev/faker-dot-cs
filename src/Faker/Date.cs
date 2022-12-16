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
        public static DateTime Future(int maxYears = 1, string refDate = "MM/DD/YYYY")
        {
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            int randMonth = Datatype.Int(startHere.Month, 12);
            int randDay = Datatype.Int(startHere.Day + 1, DateTime.DaysInMonth(startHere.Year, randMonth));
            int randYear = Datatype.Int(startHere.Year, startHere.Year + maxYears);
            return DateTime.Parse(randMonth + "/" + randDay + "/" + randYear);
        }

        public static DateTime Recent(int days = 15, string refDate = "MM/DD/YYYY")
        {
            int random = Datatype.Int(1, days);
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            return startHere.AddDays(random * -1);

        }
        public static DateTime Soon(int days = 15, string refDate = "MM/DD/YYYY")
        {
            int random = Datatype.Int(1, days);
            DateTime startHere = refDate == "MM/DD/YYYY" ? DateTime.Today : DateTime.Parse(refDate);
            return startHere.AddDays(random);
        }


        //todo SUMMARY THESE. "MM/DD/YYYY"
        public static DateTime Between(string from, string to)
        {
            var random = new Random();
            DateTime start = DateTime.Parse(from);
            DateTime end = DateTime.Parse(to);
            //TODO: BUG HERE, it can in theory return the start of end date
            //This whole function is weird. Refactor me.
            var range = Convert.ToInt32(end.Subtract(start).TotalDays);
            return start.AddDays(random.Next(range));
        }

        public static string Month(bool abbr = false)
        {
            var date = new Locales.Date.Months();
            if (abbr)
            {
                return Helpers.Randomize(date.Abbr);
            }
            return Helpers.Randomize(date.Wide);
        }
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
