
using System;
using System.Linq;
using System.Collections.Generic;

namespace Faker
{

	public class Hacker
	{
		public static string Abbreviation()
		{
			var hacker = new Locales.Hacker();
			return Helpers.Pick.RandomList(hacker.Abbreviations);
		}
		public static string Adjective()
		{
			var hacker = new Locales.Hacker();
			return Helpers.Pick.RandomList(hacker.Adjectives);
		}
		public static string IngVerb()
		{
			var hacker = new Locales.Hacker();
			return Helpers.Pick.RandomList(hacker.IngVerbs);
		}
		public static string Noun()
		{
			var hacker = new Locales.Hacker();
			return Helpers.Pick.RandomList(hacker.Nouns);
		}
		public static string Verb()
		{
			var hacker = new Locales.Hacker();
			return Helpers.Pick.RandomList(hacker.Verbs);
		}
		public static string Phrase()
		{
			var hacker = new Locales.Hacker();
			var originalPhrase = Helpers.Pick.RandomList(hacker.Phrases);
			return originalPhrase
			.Replace("{{abbreviation}}", Helpers.Pick.RandomList(hacker.Abbreviations))
			.Replace("{{adjective}}", Helpers.Pick.RandomList(hacker.Adjectives))
			.Replace("{{ingverb}}", Helpers.Pick.RandomList(hacker.IngVerbs))
			.Replace("{{noun}}", Helpers.Pick.RandomList(hacker.Nouns))
			.Replace("{{verb}}", Helpers.Pick.RandomList(hacker.Verbs));
		}

	}
}