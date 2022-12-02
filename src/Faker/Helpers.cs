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

                var random = new Random();
                return list[random.Next(list.Count)];
            }
            /// <summary>
            /// select an element at random from a given array 
            /// </summary>
            public static dynamic RandomArray(dynamic array)
            {

                var random = new Random();
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

        //todo this is absolute wrong, but working enough for UG.
        public static string ReplaceSymbolWithNumber(string value, string symbol = "#")
        {
            var random = new Random();
            const string numChars = "123456789";
            string replaced = new string(Enumerable.Repeat(numChars, 1).Select(s => s[random.Next(s.Length)]).ToArray());
            string[] split = value.Split(symbol);
            return value.Replace(symbol, replaced);
        }


        public static bool ContainsAny(string s, List<string> substrings)
        {
            if (string.IsNullOrEmpty(s) || substrings == null)
                return false;

            return substrings.Any(substring => s.Contains(substring, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}