using System;
using Xunit;

using Faker;
//test the Faker.Address class
namespace FakerTest.Address
{
    public class AddressTest
    {
        // CityName
        [Fact]
        public void CityNameTest()
        {
            var address = new Faker.Locales.Address();
            var cityName = Faker.Address.CityName();
            Assert.True(cityName != null);
            Assert.True(Helpers.ContainsAny(cityName, address.CityNames));
        }
        // CityPrefix
        [Fact]
        public void CityPrefixTest()
        {
            var address = new Faker.Locales.Address();
            var cityPrefix = Faker.Address.CityPrefix();
            Assert.True(cityPrefix != null);
            Assert.True(Helpers.ContainsAny(cityPrefix, address.CityPrefixes));
        }
        // CitySuffix
        [Fact]
        public void CitySuffixTest()
        {
            var address = new Faker.Locales.Address();
            var citySuffix = Faker.Address.CitySuffix();
            Assert.True(citySuffix != null);
            Assert.True(Helpers.ContainsAny(citySuffix, address.CitySuffixes));
        }
        // StreetName
        [Fact]
        public void StreetNameTest()
        {
            var address = new Faker.Locales.Address();
            var streetName = Faker.Address.StreetName();
            Assert.True(streetName != null);
            Assert.True(Helpers.ContainsAny(streetName, address.StreetSuffixes));
        }

        // StreetSuffix
        [Fact]
        public void StreetSuffixTest()
        {
            var address = new Faker.Locales.Address();
            var streetSuffix = Faker.Address.StreetSuffix();
            Assert.True(streetSuffix != null);
            Assert.True(Helpers.ContainsAny(streetSuffix, address.StreetSuffixes));
        }

        // SecondaryAddress
        [Fact]
        public void SecondaryAddressTest()
        {
            var address = new Faker.Locales.Address();
            var secondaryAddress = Faker.Address.SecondaryAddress();
            Assert.True(secondaryAddress != null);
            Assert.True(Helpers.ContainsAny(secondaryAddress, address.SecondaryAddresss));
        }

        // StreetAddress
        // TODO: These are really REALLY weak tests. 
        [Fact]
        public void StreetAddressTest()
        {
            var address = new Faker.Locales.Address();
            var streetAddress = Faker.Address.StreetAddress(false);
            Assert.True(streetAddress != null);
        }

        // StreetAddressFullTest
        [Fact]
        public void StreetAddressFullTest()
        {
            var address = new Faker.Locales.Address();
            var streetAddress = Faker.Address.StreetAddress(true);
            Assert.True(streetAddress != null);
        }




    }
}


