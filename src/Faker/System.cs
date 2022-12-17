using System;

namespace Faker
{
    public class System
    {
        public static string FileName()
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            return Lorem.Word() + "." + letters[Datatype.Int(0, letters.Length)] + letters[Datatype.Int(0, letters.Length)] + letters[Datatype.Int(0, letters.Length)];
        }

        public static string CommonFileName(string ext)
        {
            if (ext == null)
            {
                var system = new Locales.System();
                ext = Helpers.Randomize(system.FileExtensions);
            }
            string word = Lorem.Word();
            return word + "." + ext;
        }

        public static string MimeType()
        {
            var system = new Locales.System();
            return Helpers.Randomize(system.MimeTypes);
        }


    }
}