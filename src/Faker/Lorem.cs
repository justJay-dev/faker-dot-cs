using System;
using System.Collections.Generic;
namespace Faker
{
    //todo many methods incomplete.
    public class Lorem
    {
        public static string Word()
        {
            var lorem = new Locales.Lorem();
            return Helpers.Randomize(lorem.Words);
        }

        public static string Words(int num = 3)
        {
            var lorem = new Locales.Lorem();
            string result = "";
            Helpers.Repeat.Times(num, () => result += Helpers.Randomize(lorem.Words) + " ");
            return result.Trim();
        }

        public static string Sentence(int wordCount = 4)
        {
            string result = "";
            Helpers.Repeat.Times(wordCount, () => result += Word() + " ");
            return result.Trim() + ".";
        }

        public static string Sentences(int sentenceCount = 3, string seperator = " ")
        {
            string result = "";
            Helpers.Repeat.Times(sentenceCount, () => result += Sentence() + seperator);
            return result.Trim();
        }

        public static string Paragraph(int sentenceCount = 3)
        {
            string result = "";
            Helpers.Repeat.Times(sentenceCount, () => result += Sentence() + "");
            return result.Trim() + ".";
        }

        public static string Paragraphs(int paragraphCount = 3, string seperator = "\n \r")
        {
            string result = "";
            Helpers.Repeat.Times(paragraphCount, () => result += Paragraph() + seperator);
            return result.Trim();
        }

        public static string Slug(int wordCount = 3)
        {
            string result = "";
            Helpers.Repeat.Times(wordCount, () => result += Word() + "-");
            return result.Trim('-');
        }

        public static string Text()
        {
            int method = new System.Random().Next(0, 2);
            switch (method)
            {
                case 0:
                    return Paragraph();
                case 1:
                    return Paragraphs();
                default:
                    return Paragraph();
            }
        }

        public static string Lines(int lineCount = 3)
        {
            string result = "";
            Helpers.Repeat.Times(lineCount, () => result += Sentence() + "\r \n");
            return result.Trim();
        }

    }
}