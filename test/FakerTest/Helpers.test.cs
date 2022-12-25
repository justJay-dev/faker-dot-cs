using System;
using System.Collections.Generic;
using Xunit;
using Faker;

namespace FakerTest.Helpers
{
    public class HelpersTest
    {
        [Fact]
        public void ContainsAnyTest()
        {
            var testString = "test";
            var testArray = new List<string> { "test", "test2" };
            Assert.True(Faker.Helpers.ContainsAny(testString, testArray));
        }

        [Fact]
        public void RandomizeTest()
        {
            var testArray = new string[] { "test", "test2" };
            var testList = new List<string> { "test", "test2" };
            Assert.True(Faker.Helpers.Randomize(testArray) != null);
            Assert.True(Faker.Helpers.Randomize(testList) != null);
        }

        [Fact]
        public void ReplaceSymbolWithNumberTest()
        {
            var testString = "###";
            var testString2 = "1##Z";
            Assert.True(Faker.Helpers.ReplaceSymbolWithNumber(testString) != null);
            Assert.DoesNotContain("#", Faker.Helpers.ReplaceSymbolWithNumber(testString));
            Assert.True(Faker.Helpers.ReplaceSymbolWithNumber(testString2) != null);
            Assert.DoesNotContain("#", Faker.Helpers.ReplaceSymbolWithNumber(testString2));
            Assert.StartsWith("1", Faker.Helpers.ReplaceSymbolWithNumber(testString2));
            Assert.EndsWith("Z", Faker.Helpers.ReplaceSymbolWithNumber(testString2));
        }

    }
}