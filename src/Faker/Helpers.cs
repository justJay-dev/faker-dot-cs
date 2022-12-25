using System;
using System.Collections.Generic;
using System.Linq;
namespace Faker

{
    public class Helpers
    {
        private class Pick
        {
            /// <summary>
            /// select a value at random from a given list 
            /// </summary>
            public static dynamic RandomList(dynamic list)
            {

                var random = new System.Random();
                return list[random.Next(list.Count)];
            }
            /// <summary>
            /// select an element at random from a given array 
            /// </summary>
            public static dynamic RandomArray(dynamic array)
            {

                var random = new System.Random();
                return array[random.Next(0, array.Length)];
            }
        }

        /// <summary>
        /// select a value at random from a given list or array
        /// </summary>
        public static dynamic Randomize(object listOrArray)
        {
            if (listOrArray.GetType().IsArray)
            {
                return Pick.RandomArray(listOrArray);
            }
            else
            {
                return Pick.RandomList(listOrArray);
            }
        }
        public class Repeat
        {        /// <summary>
                 /// Repeat a given function(action) (count) amount of times
                 /// </summary>
            public static void Times(int count, Action action)
            {
                for (int i = 0; i < count; i++)
                {
                    action();
                }
            }
        }

        /// <summary>
        /// Replaces a given symbol with a random number for each occurence
        /// ###-### -> 123-456
        /// BUG: This just repeats the first number in the string
        /// </summary>
        public static string ReplaceSymbolWithNumber(string value, string symbol = "#")
        {
            var random = new System.Random();
            const string chars = "0123456789";
            return value.Replace(symbol, new string(Enumerable.Repeat(chars, 1).Select(s => s[random.Next(s.Length)]).ToArray()));
        }


        public static bool ContainsAny(string s, List<string> substrings)
        {
            if (string.IsNullOrEmpty(s) || substrings == null)
                return false;

            return substrings.Any(substring => s.Contains(substring, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}