using System;
using System.Collections.Generic;
namespace Faker
{
    public class Company
    {
        public static Array Suffixes()
        {
            var company = new Locales.Company();
            return company.Suffixes.ToArray();
        }
        public static string CompanySuffix()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.Suffixes);
        }

        public static string CompanyName(int formatIndex = 0)
        {
            var company = new Locales.Company();
            var names = new Locales.Name();
            switch (formatIndex)
            {
                case 1:
                    return Name.LastName() + " - " + Name.LastName();
                case 2:
                    return Name.LastName() + ", " + Name.LastName() + " and " + Name.LastName();
                default:
                    return Name.LastName() + " " + CompanySuffix();

            }
        }

        public static string CatchPhraseAdjective()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.Adjectives);
        }
        public static string CatchPhraseDescriptor()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.Descriptors);
        }
        public static string CatchPhraseNoun()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.Nouns);
        }

        public static string CatchPhrase()
        {
            return (CatchPhraseAdjective() + " " + CatchPhraseDescriptor() + " " + CatchPhraseNoun());

        }

        public static string BSAdjective()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.BSAdjectives);

        }
        public static string BSNoun()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.BSNouns);

        }
        //TODO this is inconsistant in styling, consider refactor to BSVerbs

        public static string BSVerbs()
        {
            var company = new Locales.Company();
            return Helpers.Randomize(company.BSVerbs);
        }
        // jws Left this in to not break any downstream users, this is an alias ATM. 12/16/2022
        public static string BSBuzz()
        {
            return BSVerbs();

        }


        public static string BS()
        {
            return (BSAdjective() + " " + BSVerbs() + " " + BSNoun());
        }


    }
}