namespace Faker
{
    public class Database
    {
        /// <summary>
        /// Returns a random column name as a string
        /// </summary>
        public static string Column()
        {
            var database = new Locales.Database();
            return Helpers.Randomize(database.Columns);
        }

        /// <summary>
        /// Returns a random column type as a string
        /// </summary>
        public static string Type()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Types);
        }
        /// <summary>
        /// Returns a random collation value as a string
        /// </summary>
        public static string Collation()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Collations);
        }
        /// <summary>
        /// Returns a random engine value as a string
        /// </summary>
        public static string Engine()
        {

            var database = new Locales.Database();
            return Helpers.Randomize(database.Engines);
        }
    }
}