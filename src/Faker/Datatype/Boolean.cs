namespace Faker.Datatype
{
	public static class Boolean
	{
		/// <summary>
		/// returns a random boolean, True, or False.
		/// </summary>
		public static bool Next()
		{
			var index = Int.Next(0, 2);
			return index != 0;
		}
	}
}
