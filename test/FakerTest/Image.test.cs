using System;
using System.Collections.Generic;
using Xunit;
using Faker;

namespace FakerTest.Image
{
    public class ImageTest
    {
        [Fact]
        public void ImageUrlTest()
        {
            var url = Faker.Image.ImageUrl();
            Assert.True(url != null);
            Assert.StartsWith("http://lorempixel.com/", url);

            var httpsUrl = Faker.Image.ImageUrl(https: true);
            Assert.True(httpsUrl != null);
            Assert.StartsWith("https://lorempixel.com/", httpsUrl);

            var catsurl = Faker.Image.ImageUrl(category: "cats");
            Assert.True(catsurl != null);
            Assert.Contains("cats", catsurl);
        }

        [Fact]
        public void AvatarTest()
        {
            var url = Faker.Image.Avatar();
            Assert.True(url != null);
            Assert.StartsWith("https://s3.amazonaws.com/uifaces/faces/twitter/", url);
        }

        [Fact]
        public void AbstractTest()
        {
            var url = Faker.Image.Abstract();
            Assert.True(url != null);
            Assert.Contains("abstract", url);
        }

        [Fact]
        public void AnimalsTest()
        {
            var url = Faker.Image.Animals();
            Assert.True(url != null);
            Assert.Contains("animals", url);
        }

        [Fact]
        public void BusinessTest()
        {
            var url = Faker.Image.Business();
            Assert.True(url != null);
            Assert.Contains("business", url);
        }

        [Fact]
        public void CatsTest()
        {
            var url = Faker.Image.Cats();
            Assert.True(url != null);
            Assert.Contains("cats", url);
        }

        [Fact]
        public void CityTest()
        {
            var url = Faker.Image.City();
            Assert.True(url != null);
            Assert.Contains("city", url);
        }

        [Fact]
        public void FoodTest()
        {
            var url = Faker.Image.Food();
            Assert.True(url != null);
            Assert.Contains("food", url);
        }

        [Fact]
        public void NightlifeTest()
        {
            var url = Faker.Image.Nightlife();
            Assert.True(url != null);
            Assert.Contains("nightlife", url);
        }

        [Fact]
        public void FashionTest()
        {
            var url = Faker.Image.Fashion();
            Assert.True(url != null);
            Assert.Contains("fashion", url);
        }

        [Fact]
        public void PeopleTest()
        {
            var url = Faker.Image.People();
            Assert.True(url != null);
            Assert.Contains("people", url);
        }

        [Fact]
        public void NatureTest()
        {
            var url = Faker.Image.Nature();
            Assert.True(url != null);
            Assert.Contains("nature", url);
        }

        [Fact]
        public void SportsTest()
        {
            var url = Faker.Image.Sports();
            Assert.True(url != null);
            Assert.Contains("sports", url);
        }

        [Fact]
        public void TechnicsTest()
        {
            var url = Faker.Image.Technics();
            Assert.True(url != null);
            Assert.Contains("technics", url);
        }

        [Fact]
        public void TransportTest()
        {
            var url = Faker.Image.Transport();
            Assert.True(url != null);
            Assert.Contains("transport", url);
        }

        [Fact]
        public void ImageTagTest()
        {
            var url = Faker.Image.ImageTag();
            Assert.True(url != null);
            Assert.StartsWith("<img src=\"http://lorempixel.com/", url);
        }

        /*
        this is broken?
        [Fact]
        public void DataUriTest()
        {
            var url = Faker.Image.DataUri();
            Assert.True(url != null);
            Assert.StartsWith("data:image/png;base64,", url);
        }
        */
    }
}