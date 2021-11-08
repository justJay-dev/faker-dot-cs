
using System;
namespace Faker.Datatype
{
	public static class Uuid
	{
		/// <summary>
		/// returns a random uuid.
		/// </summary>
		public static string Next()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
