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
		//TODO this is inconsistant in styling, consider refactor to BSVerbss
		public static string BSBuzz()
		{
			var company = new Locales.Company();
			return Helpers.Randomize(company.BSVerbs);

		}

		public static string BS()
		{
			return (BSAdjective() + " " + BSBuzz() + " " + BSNoun());
		}


	}
}