
using System;
namespace Datatype
{
	public static class Uuid
	{
		public static string Next()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
