using System;
using System.Collections.Generic;
using Xunit;
using Faker;

namespace FakerTest.Internet
{
    public class InternetTest
    {
        [Fact]
        public void AvatarTest()
        {
            var avatar = Faker.Internet.Avatar();
            Assert.True(avatar != null);
            Assert.StartsWith("https://s3.amazonaws", avatar);
        }

        [Fact]
        public void EmailTest()
        {
            var email = Faker.Internet.Email();
            Assert.True(email != null);
            Assert.Contains("@", email);
        }

        [Fact]
        public void ExampleEmailTest()
        {
            var email = Faker.Internet.ExampleEmail();
            Assert.True(email != null);
            Assert.Contains("@", email);
        }

        [Fact]
        public void UserNameTest()
        {
            var username = Faker.Internet.UserName();
            Assert.True(username != null);
            Assert.True(username.Contains("_") || username.Contains("-"));
        }

        [Fact]
        public void DomainNameTest()
        {
            var domain = Faker.Internet.DomainName();
            Assert.True(domain != null);
            Assert.Contains(".", domain);
        }

        [Fact]
        public void DomainWordTest()
        {
            var domain = Faker.Internet.DomainWord();
            Assert.True(domain != null);
        }

        [Fact]
        public void DomainSuffixTest()
        {
            var domain = Faker.Internet.DomainSuffix();
            Assert.True(domain != null);
            Assert.Contains(".", domain);
        }

        [Fact]
        public void IpTest()
        {
            var ip = Faker.Internet.IP();
            Assert.True(ip != null);
            Assert.Contains(".", ip);
        }

        [Fact]
        public void IPv6Test()
        {
            var ip = Faker.Internet.IPv6();
            Assert.True(ip != null);
            Assert.Contains(":", ip);
        }

        [Fact]
        public void MacTest()
        {
            var mac = Faker.Internet.Mac();
            Assert.True(mac != null);
            Assert.Contains(":", mac);
        }

        [Fact]
        public void PasswordTest()
        {
            var password = Faker.Internet.Password();
            Assert.True(password != null);
            Assert.True(password.Length >= 8);
        }

        [Fact]
        public void ColorTest()
        {
            var color = Faker.Internet.Color();
            Assert.True(color != null);
            Assert.StartsWith("#", color);
        }
    }
}
