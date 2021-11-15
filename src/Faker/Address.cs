
namespace Faker
{
    public class Address
    {
        public static string CityName()
        {
            var address = new Locales.Address();
            return Helpers.Pick.RandomList(address.CityNames);
        }

    }
}