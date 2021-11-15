namespace Faker
{

    public class Hacker
    {
        public static string Abbreviation()
        {
            var hacker = new Locales.Hacker();
            return Helpers.Randomize(hacker.Abbreviations);
        }
        public static string Adjective()
        {
            var hacker = new Locales.Hacker();
            return Helpers.Randomize(hacker.Adjectives);
        }
        public static string IngVerb()
        {
            var hacker = new Locales.Hacker();
            return Helpers.Randomize(hacker.IngVerbs);
        }
        public static string Noun()
        {
            var hacker = new Locales.Hacker();
            return Helpers.Randomize(hacker.Nouns);
        }
        public static string Verb()
        {
            var hacker = new Locales.Hacker();
            return Helpers.Randomize(hacker.Verbs);
        }
        //TODO this should randomize each instance of the mustache.
        public static string Phrase()
        {
            var hacker = new Locales.Hacker();
            var originalPhrase = Helpers.Randomize(hacker.Phrases);
            return originalPhrase
            .Replace("{{abbreviation}}", Helpers.Randomize(hacker.Abbreviations))
            .Replace("{{adjective}}", Helpers.Randomize(hacker.Adjectives))
            .Replace("{{ingverb}}", Helpers.Randomize(hacker.IngVerbs))
            .Replace("{{noun}}", Helpers.Randomize(hacker.Nouns))
            .Replace("{{verb}}", Helpers.Randomize(hacker.Verbs));
        }

    }
}