namespace Faker
{
    public class Database
    {
        public static string Column()
        {
            var database = new Locales.Database();
            return Helpers.Randomize(database.Columns);
        }

        public static string Type()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Types);
        }
        public static string Collation()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Collations);
        }
        public static string Engine()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Engines);
        }
    }
}