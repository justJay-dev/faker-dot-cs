using System;
using Xunit;

using Faker;

namespace FakerTest.Database
{
    public class DatabaseTest
    {
        [Fact]
        public void ColumnTest()
        {
            var database = new Faker.Locales.Database();
            var column = Faker.Database.Column();
            Assert.True(column != null);
            Assert.True(Faker.Helpers.ContainsAny(column, database.Columns));

        }
        [Fact]
        public void TypeTest()
        {
            var database = new Faker.Locales.Database();
            var type = Faker.Database.Type();
            Assert.True(type != null);
            Assert.True(Faker.Helpers.ContainsAny(type, database.Types));
        }

        [Fact]
        public void CollationTest()
        {
            var database = new Faker.Locales.Database();
            var collation = Faker.Database.Collation();
            Assert.True(collation != null);
            Assert.True(Faker.Helpers.ContainsAny(collation, database.Collations));
        }

        [Fact]
        public void EngineTest()
        {
            var database = new Faker.Locales.Database();
            var engine = Faker.Database.Engine();
            Assert.True(engine != null);
            Assert.True(Faker.Helpers.ContainsAny(engine, database.Engines));

        }



    }
}