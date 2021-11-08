using System;

namespace Datatype
{
	public static class Int
	{
		public static dynamic Next(int min, int max)
		{
			var rnd = new Random();
			return rnd.Next(min, max);
		}
	}
}