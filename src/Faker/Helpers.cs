using System;
using System.Collections.Generic;
namespace Faker

{
	public class Helpers
	{
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
		public class Pick
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

	}
}