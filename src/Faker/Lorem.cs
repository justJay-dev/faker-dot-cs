
namespace Faker
{
    //todo many methods incomplete.
    public class Lorem
    {
        public static string Word()
        {
            var lorem = new Locales.Lorem();
            return Helpers.Randomize(lorem.Words);
        }

    }
}