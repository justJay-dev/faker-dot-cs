
using System;
using Xunit;

using Faker;
//test the Faker.Commerce class
namespace FakerTest.Commerce
{
    public class CommerceTest
    {
        // Color
        [Fact]
        public void ColorTest()
        {
            var commerce = new Faker.Locales.Commerce();
            var color = Faker.Commerce.Color();
            Assert.True(color != null);
            Assert.True(Helpers.ContainsAny(color, commerce.Colors));
        }
        // Department
        [Fact]
        public void DepartmentTest()
        {
            var commerce = new Faker.Locales.Commerce();
            var department = Faker.Commerce.Department();
            Assert.True(department != null);
            Assert.True(Helpers.ContainsAny(department, commerce.Departments));
        }
        // ProductName
        [Fact]
        public void ProductNameTest()
        {
            var commerce = new Faker.Locales.Commerce.ProductNames();
            var productName = Faker.Commerce.ProductName();
            Assert.True(productName != null);
            Assert.True(Helpers.ContainsAny(productName, commerce.Adjectives));
            Assert.True(Helpers.ContainsAny(productName, commerce.Materials));
            Assert.True(Helpers.ContainsAny(productName, commerce.Products));
        }
        // Price
        [Fact]
        public void PriceTest()
        {
            var price = Faker.Commerce.Price(symbol: "$");
            Assert.True(price != null);
            Assert.True(price.Length > 0);
            var priceAsDouble = Convert.ToDouble(price.Substring(1));
            Assert.True(priceAsDouble >= 1);
            Assert.Contains('$', price);
        }
        // PriceWithMinAndMax
        [Fact]
        public void PriceWithMinAndMaxTest()
        {
            var price = Faker.Commerce.Price(1, 10, symbol: "$");
            //take the $ out of price and convert to double
            var priceAsDouble = Convert.ToDouble(price.Substring(1));
            Assert.True(priceAsDouble >= 1.00 && priceAsDouble <= 10.00);
        }
    }
}