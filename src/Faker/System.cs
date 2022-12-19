using System;
using System.Collections.Generic;

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

        public static string CommonMimeType()
        {
            List<string> CommonMimeTypes = new List<string>()
        {
            "application/pdf",
            "audio/mpeg",
            "audio/wav",
            "image/png",
            "image/jpeg",
            "image/gif",
            "video/mp4",
            "video/mpeg",
            "text/html"
        };
            return Helpers.Randomize(CommonMimeTypes);
        }

        public static string FileType()
        {
            List<string> FileTypes = new List<string>()
        {
            "video",
            "audio",
            "image",
            "text",
            "application"
        };
            return Helpers.Randomize(FileTypes);
        }

        public static string DirectoryPath()
        {
            return "/" + Lorem.Word() + "/" + Lorem.Word() + "/" + Lorem.Word() + "/";
        }

        public static string SimVersion()
        {
            return Datatype.Int(2) + "." + Datatype.Int(2) + "." + Datatype.Int(2);
        }
    }

}