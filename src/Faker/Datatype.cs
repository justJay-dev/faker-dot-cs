
using System;
using System.Linq;
namespace Faker
{
	public class Datatype
	{

		/// <summary>
		/// returns a random float, between min(int|float) and max(int|float).
		/// </summary>
		public static float Float(float min, float max)
		{
			var random = new Random();
			var value = (random.NextDouble() * (max - min) + min);
			return (float)value;
		}

		/// <summary>
		/// returns a random integer, between min(int) and max(int).
		/// </summary>
		public static int Int(int min, int max)
		{
			var random = new Random();
			return random.Next(min, max);
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
		/// </summary>
		public static string String(int length)

		{
			var random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
		}
	}
}