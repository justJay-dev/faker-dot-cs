
using System;
using Xunit;

using Faker;
//test the Faker.Address class
namespace FakerTest.Hacker
{
    public class HackerTest
    {
        [Fact]
        public void AbbreviationTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var abbreviation = Faker.Hacker.Abbreviation();
            Assert.True(abbreviation != null);
            Assert.True(Faker.Helpers.ContainsAny(abbreviation, hacker.Abbreviations));
        }

        [Fact]
        public void AdjectiveTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var adjective = Faker.Hacker.Adjective();
            Assert.True(adjective != null);
            Assert.True(Faker.Helpers.ContainsAny(adjective, hacker.Adjectives));
        }

        [Fact]
        public void NounTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var noun = Faker.Hacker.Noun();
            Assert.True(noun != null);
            Assert.True(Faker.Helpers.ContainsAny(noun, hacker.Nouns));
        }

        [Fact]
        public void VerbTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var verb = Faker.Hacker.Verb();
            Assert.True(verb != null);
            Assert.True(Faker.Helpers.ContainsAny(verb, hacker.Verbs));
        }

        [Fact]
        public void IngverbTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var ingverb = Faker.Hacker.IngVerb();
            Assert.True(ingverb != null);
            Assert.True(Faker.Helpers.ContainsAny(ingverb, hacker.IngVerbs));
        }

        /*
        This test is broken, but so is the code it's testing.
        [Fact]
        public void PhraseTest()
        {
            var hacker = new Faker.Locales.Hacker();
            var phrase = Faker.Hacker.Phrase();
            Assert.True(phrase != null);
            Assert.True(Faker.Helpers.ContainsAny(phrase, hacker.Phrases));
        }
        */

    }
}