using System;

namespace Faker.Datatype
{
	public static class Int
	{
		/// <summary>
		/// returns a random integer, between min(int) and max(int).
		/// </summary>
		public static int Next(int min, int max)
		{
			var random = new Random();
			return random.Next(min, max);
		}
	}
	public static class Float
	{
		/// <summary>
		/// returns a random float, between min(int|float) and max(int|float).
		/// </summary>
		public static float Next(float min, float max)
		{
			var random = new Random();
			var value = (random.NextDouble() * (max - min) + min);
			return (float)value;
		}
	}
}