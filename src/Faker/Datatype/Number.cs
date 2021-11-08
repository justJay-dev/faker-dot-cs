using System;

namespace Datatype
{
	public static class Int
	{
		public static int Next(int min, int max)
		{
			var random = new Random();
			return random.Next(min, max);
		}
	}
	public static class Float
	{
		public static float Next(float min, float max)
		{
			var random = new Random();
			var value = (random.NextDouble() * (max - min) + min);
			return (float)value;
		}
	}
}