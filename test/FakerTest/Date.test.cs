using System;
using Xunit;
using Faker;

namespace FakerTest.Date
{
    public class DateTest
    {
        [Fact]
        public void PastTest()
        {
            var past = Faker.Date.Past();
            Assert.True(past != DateTime.Today);
            var pastWithYear = Faker.Date.Past(maxYears: 20);
            Assert.True(pastWithYear.Year <= DateTime.Today.Year);
            var pastWithRefDate = Faker.Date.Past(refDate: "11/13/2008");
            Assert.True(pastWithRefDate.Year <= 2008);

        }
        [Fact]
        public void FutureTest()
        {
            var future = Faker.Date.Future();
            Assert.True(future != DateTime.Today);
            var futureWithYear = Faker.Date.Future(maxYears: 20);
            Assert.True(futureWithYear.Year >= DateTime.Today.Year);
            var futureWithRefDate = Faker.Date.Future(refDate: "11/13/2008");
            Assert.True(futureWithRefDate.Year >= 2008);

        }

        // TODO: These are only kind of weak tests jws 12/16/2022 -- in route to dallas
        [Fact]
        public void RecentTest()
        {
            var recent = Faker.Date.Recent();
            Assert.True(recent != DateTime.Today);
            Assert.True(recent < DateTime.Today);
        }

        [Fact]
        public void SoonTest()
        {
            var soon = Faker.Date.Soon();
            Assert.True(soon != DateTime.Today);
            Assert.True(soon > DateTime.Today);
        }

        [Fact]
        public void BetweenTest()
        {
            var from = "11/13/2008";
            var to = "11/19/2008";
            var betweenResult = Faker.Date.Between(from: from, to: to);
            Assert.True(betweenResult < DateTime.Parse(to));
            Assert.True(betweenResult > DateTime.Parse(from));
        }

        [Fact]
        public void MonthTest()
        {
            var date = new Faker.Locales.Date.Months();
            var month = Faker.Date.Month();
            Assert.True(Faker.Helpers.ContainsAny(month, date.Wide));

            var monthAbbr = Faker.Date.Month(true);
            Assert.True(Faker.Helpers.ContainsAny(monthAbbr, date.Abbr));

        }

        [Fact]
        public void WeekdayTest()
        {
            var date = new Faker.Locales.Date.Weekdays();
            var day = Faker.Date.Weekday();
            Assert.True(Faker.Helpers.ContainsAny(day, date.Wide));

            var dayAbbr = Faker.Date.Weekday(true);
            Assert.True(Faker.Helpers.ContainsAny(dayAbbr, date.Abbr));
        }

    }

}