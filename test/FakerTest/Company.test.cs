using System;
using Xunit;
using Faker;
// test the Faker.Company class

namespace FakerTest.Company
{
    public class CompanyTest
    {
        // Suffixs
        [Fact]
        public void SuffixsTest()
        {
            var company = new Faker.Locales.Company();
            var suffix = Faker.Company.Suffixes();
            Assert.True(suffix != null);
            Assert.True(suffix.Length == company.Suffixes.Count);
        }
        // Single Suffix
        [Fact]
        public void CompanySuffixTest()
        {
            var company = new Faker.Locales.Company();
            var suffix = Faker.Company.CompanySuffix();
            Assert.True(suffix != null);
            Assert.True(Faker.Helpers.ContainsAny(suffix, company.Suffixes));
        }
        // Name
        [Fact]
        public void NameTest()
        {
            var company = new Faker.Locales.Company();
            var name = new Faker.Locales.Name();
            var nameDefault = Faker.Company.CompanyName();
            Assert.True(nameDefault != null);
            Assert.True(Faker.Helpers.ContainsAny(nameDefault, company.Suffixes));
            Assert.DoesNotContain("-", nameDefault);
            //    Assert.True(!nameDefault.Contains(","));
            Assert.Contains(" ", nameDefault);
            var name1 = Faker.Company.CompanyName(1);
            Assert.True(name1 != null);
            Assert.True(Faker.Helpers.ContainsAny(name1, name.LastNames));
            Assert.Contains("-", name1);
            var name2 = Faker.Company.CompanyName(2);
            Assert.True(name2 != null);
            Assert.True(Faker.Helpers.ContainsAny(name2, name.LastNames));
            Assert.Contains(",", name2);


        }
        // CatchPhrase
        [Fact]
        public void CatchPhraseAdjectiveTest()
        {
            var company = new Faker.Locales.Company();
            var adjective = Faker.Company.CatchPhraseAdjective();
            Assert.True(adjective != null);
            Assert.True(Faker.Helpers.ContainsAny(adjective, company.Adjectives));
        }

        [Fact]
        public void CatchPhraseNounTest()
        {
            var company = new Faker.Locales.Company();
            var noun = Faker.Company.CatchPhraseNoun();
            Assert.True(noun != null);
            Assert.True(Faker.Helpers.ContainsAny(noun, company.Nouns));
        }
        [Fact]
        public void CatchPhraseDescriptor()
        {
            var company = new Faker.Locales.Company();
            var descriptor = Faker.Company.CatchPhraseDescriptor();
            Assert.True(descriptor != null);
            Assert.True(Faker.Helpers.ContainsAny(descriptor, company.Descriptors));
        }


        [Fact]
        public void CatchPhraseTest()
        {
            var company = new Faker.Locales.Company();
            var catchPhrase = Faker.Company.CatchPhrase();
            Assert.True(catchPhrase != null);
            Assert.True(Faker.Helpers.ContainsAny(catchPhrase, company.Adjectives));
            Assert.True(Faker.Helpers.ContainsAny(catchPhrase, company.Nouns));
            Assert.True(Faker.Helpers.ContainsAny(catchPhrase, company.Descriptors));
        }
        // Bs
        [Fact]
        public void BsAdjectiveTest()
        {
            var company = new Faker.Locales.Company();
            var adjective = Faker.Company.BSAdjective();
            Assert.True(adjective != null);
            Assert.True(Faker.Helpers.ContainsAny(adjective, company.BSAdjectives));

        }

        [Fact]
        public void BsNounTest()
        {
            var company = new Faker.Locales.Company();
            var noun = Faker.Company.BSNoun();
            Assert.True(noun != null);
            Assert.True(Faker.Helpers.ContainsAny(noun, company.BSNouns));
        }

        [Fact]
        public void BsVerbTest()
        {
            var company = new Faker.Locales.Company();
            var verb = Faker.Company.BSVerbs();
            Assert.True(verb != null);
            Assert.True(Faker.Helpers.ContainsAny(verb, company.BSVerbs));
            //test the alias
            var alias = Faker.Company.BSBuzz();
            Assert.True(verb != null);
            Assert.True(Faker.Helpers.ContainsAny(alias, company.BSVerbs));

        }

        [Fact]
        public void BsTest()
        {
            var company = new Faker.Locales.Company();
            var bs = Faker.Company.BS();
            Assert.True(bs != null);
            Assert.Contains(" ", bs);
            Assert.True(Faker.Helpers.ContainsAny(bs, company.BSAdjectives));
            Assert.True(Faker.Helpers.ContainsAny(bs, company.BSNouns));
            Assert.True(Faker.Helpers.ContainsAny(bs, company.BSVerbs));

        }

    }

}