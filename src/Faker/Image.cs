using System;
using System.Collections.Generic;
using System.IO;
namespace Faker
{
    public class Image
    {
        public static List<string> Categories = new List<string> { "abstract", "animals", "business", "cats", "city", "food", "nightlife", "fashion", "people", "nature", "sports", "technics", "transport" };
        public static string RandomImage(int width = 640, int height = 480, bool randomize = true)
        {
            return ImageUrl(width: width, height: height, randomize: randomize);
        }
        public static string ImageUrl(int width = 640, int height = 480, bool grayscale = false, bool https = false, bool randomize = true, string category = null)
        {
            var url = "http://lorempixel.com/";
            if (https)
            {
                url = "https://lorempixel.com/";
            }
            if (grayscale)
            {
                url += "g/";
            }
            url += width.ToString() + "/" + height.ToString();
            if (category != null && Categories.Contains(category))
            {
                url += "/" + category;
            }
            if (randomize)
            {
                url += "?" + Datatype.Int(1, 1000).ToString();
            }
            return url;
        }

        public static string Avatar(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            var internet = new Locales.Internet();
            return "https://s3.amazonaws.com/uifaces/faces/twitter/" + Helpers.Randomize(internet.AvatarUris);
        }

        public static string Abstract(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "abstract");
        }

        public static string Animals(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "animals");
        }

        public static string Business(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "business");
        }

        public static string Cats(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "cats");
        }

        public static string City(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "city");
        }

        public static string Food(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "food");
        }

        public static string Nightlife(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "nightlife");
        }

        public static string Fashion(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "fashion");
        }

        public static string People(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "people");
        }

        public static string Nature(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "nature");
        }

        public static string Sports(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "sports");
        }

        public static string Technics(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "technics");
        }

        public static string Transport(int width = 640, int height = 480, bool grayscale = false, bool https = false)
        {
            return ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: false, category: "transport");
        }

        public static string ImageTag(int width = 640, int height = 480, bool grayscale = false, bool https = false, bool randomize = true, string category = null)
        {
            return "<img src=\"" + ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: randomize, category: category) + "\" />";
        }

        public static string DataUri(int width = 640, int height = 480, bool grayscale = false, bool https = false, bool randomize = true, string category = null)
        {
            var image = ImageUrl(width: width, height: height, grayscale: grayscale, https: https, randomize: randomize, category: category);
            var bytes = File.ReadAllBytes(image);
            var b64String = Convert.ToBase64String(bytes);
            var uri = "data:image/png;base64," + b64String;
            return uri;
        }



    }
}