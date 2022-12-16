
namespace Faker
{
    public class Address
    {
        public static string CityName()
        {
            var address = new Locales.Address();
            return Helpers.Randomize(address.CityNames);
        }
        public static string CityPrefix()
        {
            var address = new Locales.Address();
            return Helpers.Randomize(address.CityPrefixes);
        }
        public static string CitySuffix()
        {
            var address = new Locales.Address();
            return Helpers.Randomize(address.CitySuffixes);
        }

        public static string StreetName()
        {
            var address = new Locales.Address();
            return Name.FirstName() + Helpers.Randomize(address.StreetSuffixes);
        }

        /*TODO
                public static string StreetPrefix()
                {
                    var address = new Locales.Address();
                    return Helpers.Randomize(address.StreetPrefix);
                }
        */
        public static string StreetSuffix()
        {
            var address = new Locales.Address();
            return Helpers.Randomize(address.StreetSuffixes);
        }
        public static string SecondaryAddress()
        {
            var address = new Locales.Address();
            return Helpers.Randomize(address.SecondaryAddresss) + Datatype.Int(1, 999).ToString();
        }
        public static string StreetAddress(bool useFullAddress = false)
        {
            var address = new Locales.Address();
            if (useFullAddress)
            {
                return Datatype.Int(100, 999).ToString() + " " + StreetName() + " " + SecondaryAddress();
            }
            else
            {
                return Datatype.Int(100, 999).ToString() + " " + StreetName();
            }

        }

    }

}