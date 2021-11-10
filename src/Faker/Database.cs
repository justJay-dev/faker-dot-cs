namespace Faker
{
	public class Database
	{
		public static string Column()
		{
			var database = new Locales.Database();
			return Helpers.Pick.RandomList(database.Columns);
		}

		public static string Type()
		{

			var database = new Locales.Database();
			return Helpers.Pick.RandomList(database.Types);
		}
		public static string Collation()
		{

			var database = new Locales.Database();
			return Helpers.Pick.RandomList(database.Collations);
		}
		public static string Engine()
		{

			var database = new Locales.Database();
			return Helpers.Pick.RandomList(database.Engines);
		}
	}
}