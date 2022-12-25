using System;
using System.Collections.Generic;
using Xunit;
using Faker;

namespace FakerTest.Name
{
    public class NameTest
    {
        [Fact]
        public void FirstNameTest()
        {
            var names = new Faker.Locales.Name();
            var firstName = Faker.Name.FirstName();
            Assert.True(firstName != null);

            var mascName = Faker.Name.FirstName(0);
            Assert.True(mascName != null);
            Assert.True(Faker.Helpers.ContainsAny(mascName, names.MascFirstNames));

            var femName = Faker.Name.FirstName(1);
            Assert.True(femName != null);
            Assert.True(Faker.Helpers.ContainsAny(femName, names.FemFirstNames));

        }

        [Fact]
        public void LastNameTest()
        {
            var names = new Faker.Locales.Name();
            var lastName = Faker.Name.LastName();
            Assert.True(lastName != null);
            Assert.True(Faker.Helpers.ContainsAny(lastName, names.LastNames));
        }

        [Fact]
        public void FindNameTest()
        {
            var names = new Faker.Locales.Name();
            var firstName = Faker.Name.FirstName();
            var lastName = Faker.Name.LastName();
            var fullName = Faker.Name.FindName();
            Assert.True(fullName != null);
            Assert.True(Faker.Helpers.ContainsAny(fullName, names.FirstNames));
            Assert.True(Faker.Helpers.ContainsAny(fullName, names.LastNames));

            var fullName2 = Faker.Name.FindName(firstName, lastName);
            Assert.True(fullName2 != null);
            Assert.True(Faker.Helpers.ContainsAny(fullName2, names.FirstNames));
            Assert.True(Faker.Helpers.ContainsAny(fullName2, names.LastNames));
        }

        [Fact]
        public void JobTitleTest()
        {
            var names = new Faker.Locales.Name.Titles();
            var jobTitle = Faker.Name.JobTitle();
            Assert.True(jobTitle != null);
            Assert.True(Faker.Helpers.ContainsAny(jobTitle, names.Descriptors));
            Assert.True(Faker.Helpers.ContainsAny(jobTitle, names.Levels));
            Assert.True(Faker.Helpers.ContainsAny(jobTitle, names.Jobs));
        }

        [Fact]
        public void PrefixTest()
        {
            var names = new Faker.Locales.Name.Prefixes();
            var prefix = Faker.Name.Prefix();
            Assert.True(prefix != null);
            Assert.True((Faker.Helpers.ContainsAny(prefix, names.Masc) || Faker.Helpers.ContainsAny(prefix, names.Fem)));

            var mascPrefix = Faker.Name.Prefix(0);
            Assert.True(mascPrefix != null);
            Assert.True(Faker.Helpers.ContainsAny(mascPrefix, names.Masc));

            var femPrefix = Faker.Name.Prefix(1);
            Assert.True(femPrefix != null);
            Assert.True(Faker.Helpers.ContainsAny(femPrefix, names.Fem));
        }

        [Fact]
        public void SuffixTest()
        {
            var names = new Faker.Locales.Name();
            var suffix = Faker.Name.Suffix();
            Assert.True(suffix != null);
            Assert.True(Faker.Helpers.ContainsAny(suffix, names.Suffixes));
        }

        [Fact]
        public void TitleTest()
        {
            var names = new Faker.Locales.Name.Titles();
            var title = Faker.Name.Title();
            Assert.True(title != null);
            Assert.True(Faker.Helpers.ContainsAny(title, names.Descriptors));
            Assert.True(Faker.Helpers.ContainsAny(title, names.Levels));
            Assert.True(Faker.Helpers.ContainsAny(title, names.Jobs));
        }

        [Fact]
        public void JobDescriptorTest()
        {
            var names = new Faker.Locales.Name.Titles();
            var jobDescriptor = Faker.Name.JobDescriptor();
            Assert.True(jobDescriptor != null);
            Assert.True(Faker.Helpers.ContainsAny(jobDescriptor, names.Descriptors));
        }

        [Fact]
        public void JobAreaTest()
        {
            var names = new Faker.Locales.Name.Titles();
            var jobArea = Faker.Name.JobArea();
            Assert.True(jobArea != null);
            Assert.True(Faker.Helpers.ContainsAny(jobArea, names.Levels));
        }

        [Fact]
        public void JobTypeTest()
        {
            var names = new Faker.Locales.Name.Titles();
            var jobType = Faker.Name.JobType();
            Assert.True(jobType != null);
            Assert.True(Faker.Helpers.ContainsAny(jobType, names.Jobs));
        }

    }

}


