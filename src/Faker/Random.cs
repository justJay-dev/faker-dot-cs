using System;
using System.Collections.Generic;
using System.Linq;
namespace Faker
{
    public class Random
    {

        public static dynamic ListElement<T>(T[] list)
        {
            return Helpers.Randomize(list);
        }

        public static dynamic ArrayElement<T>(T[] array)
        {
            return Helpers.Randomize(array);
        }

        public static dynamic ObjectElement<T>(T obj)
        {
            var random = new System.Random();
            var properties = obj.GetType().GetProperties();
            var property = properties[random.Next(properties.Length)];
            return property.GetValue(obj, null);
        }

        public static dynamic Number(int min = 0, int max = 99999, float precision = 1)
        {
            var random = new System.Random();
            return Math.Round(random.Next(min, max) * precision, 2);
        }

        public static string Uuid()
        {
            return Faker.Datatype.Uuid();
        }

        public static bool Boolean()
        {
            return Faker.Datatype.Boolean();
        }

        public static string Word()
        {
            return Faker.Lorem.Word();
        }

        public static string Words(int count = 3)
        {
            return Faker.Lorem.Words(count);
        }

        public static string Image()
        {
            return Faker.Image.RandomImage();
        }

        public static string Locale()
        {
            var locales = new Locales.Locale();
            return Helpers.Randomize(locales);
        }

        public static string AlphaNumeric(int count = 1)
        {
            return Faker.Datatype.String(count);
        }
    }
}