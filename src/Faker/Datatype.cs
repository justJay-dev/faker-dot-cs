
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
namespace Faker
{
    public class Datatype
    {

        /// <summary>
        /// returns a random integer, between min(int) and max(int).
        /// default min 1, max 2147483647
        /// </summary>
        public static int Int(int min = 1, int max = 2147483647)
        {
            var random = new Random();
            return random.Next(min, max);
        }
        /// <summary>
        /// returns a random double, between min(int|double) and max(int|double).
        /// went with double here because it's closer to what a javascript float is.
        /// default min 0.1, max 2147483647.9
        /// </summary>
        public static double Double(double min = 0.1, double max = 2147483647.9)
        {
            var random = new Random();
            var value = (random.NextDouble() * (max - min) + min);
            return (double)value;
        }


        /// <summary>
        /// returns a random boolean, True, or False.
        /// </summary>
        public static bool Boolean()
        {
            var index = Int(0, 2);
            return index != 0;
        }

        /// <summary>
        /// returns a randomly generated uuid in string format 
        /// </summary>
        public static string Uuid()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// returns a string of random alphanumerics, for a given length
        /// default length is 5
        /// </summary>
        public static string String(int length = 5)

        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        /// <summary>
        /// returns a random array of a given type, for a given length
        /// default type is string, default length is 5
        /// </summary> 
        public static Array Array(string type = "string", int length = 5)
        {
            List<dynamic> results = new List<dynamic> { };
            switch (type)
            {
                case "string":
                    Helpers.Repeat.Times(length, () => results.Add(String((Int(1, 69)))));
                    break;
                case "int":
                    Helpers.Repeat.Times(length, () => results.Add((Int(1, 69))));
                    break;
                case "boolean":
                    Helpers.Repeat.Times(length, () => results.Add((Boolean())));
                    break;
                case "object":
                    //uhg
                    Helpers.Repeat.Times(length, () => results.Add(Object()));
                    break;
                case "array":
                    //can this be self referential?
                    Helpers.Repeat.Times(length, () => results.Add(Array()));
                    break;

            }
            return results.ToArray();
        }

        /// <summary>
		/// returns a random object, with a given number of properties
		/// default number of properties is 5
		/// </summary>
        public static Object Object(int length = 5, string type = "string")
        {
            var hacker = new Locales.Hacker();
            //you are here, and you are lost.
            List<string> choices = new List<string>{
                "number",
                "string",
                "boolean",
                "array",
                "object"
            };
            var coinToss = Boolean();
            List<dynamic> results = new List<dynamic>() { };
            switch (type)
            {
                case "string":
                    Helpers.Repeat.Times(length, () => results.Add(Hacker.Noun() + ":" + (coinToss ? Hacker.IngVerb() : Hacker.Phrase())));
                    break;
                case "number":
                    Helpers.Repeat.Times(length, () => results.Add(Hacker.Abbreviation() + ":" + (coinToss ? Int() : Double()).ToString()));
                    break;
                case "boolean":
                    Helpers.Repeat.Times(length, () => results.Add(Hacker.IngVerb() + ":" + (Boolean().ToString())));
                    break;


            }
            return JsonSerializer.Serialize(results);

        }
        /// <summary>
        /// returns a randomly generates json object, with a given number of properties
        /// default number of properties is 7
        /// </summary>

        public static dynamic Json(int length = 7)
        {
            List<string> choices = new List<string>{
                "number",
                "string",
                "boolean",
                "array",
                "object"
            };

            // returns randomly generated json, a key for each value, and a value for each key for the given length
            // default length is 7
            var random = new Random();
            var results = new Dictionary<string, dynamic>();
            Helpers.Repeat.Times(length, () =>
            {
                var choice = choices[random.Next(choices.Count)];
                switch (choice)
                {
                    case "number":
                        results.Add(Hacker.Abbreviation(), Int());
                        break;
                    case "string":
                        results.Add(Hacker.Verb(), Hacker.Phrase());
                        break;
                    case "boolean":
                        results.Add(Hacker.IngVerb(), Boolean());
                        break;
                    case "array":
                        results.Add(Hacker.Phrase(), Array());
                        break;
                    case "object":
                        results.Add(Hacker.Adjective(), Object());
                        break;
                }
            });
            return JsonSerializer.Serialize(results);
        }
    }
}