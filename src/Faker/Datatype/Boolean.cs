namespace Datatype
{
	public static class Boolean
	{
		public static bool Next()
		{
			var index = Int.Next(0, 2);
			return index != 0;
		}
	}
}
