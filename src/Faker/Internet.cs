
namespace Faker
{
    public class Internet
    {
        public static string Avatar()
        {
            var internet = new Locales.Internet();
            return "https://s3.amazonaws.com/uifaces/faces/twitter/" + Helpers.Randomize(internet.AvatarUris);
        }

        public static string Email(string firstName = "ANY", string lastName = "ANY", string provider = "ANY")
        {
            var internet = new Locales.Internet.Email();
            string fName = firstName == "ANY" ? Name.FirstName() : firstName;
            string lName = lastName == "ANY" ? Name.LastName() : lastName;
            string theProvider = provider == "ANY" ? Helpers.Randomize(internet.Free) : provider;
            return fName + "_" + lName + "@" + theProvider;
        }

        public static string ExampleEmail(string firstName = "ANY", string lastName = "ANY", string provider = "ANY")
        {
            var internet = new Locales.Internet.Email();
            return Email(firstName, lastName, Helpers.Randomize(internet.Example));
        }

        public static string UserName(string firstName = "ANY", string lastName = "ANY")
        {
            string fName = firstName == "ANY" ? Name.FirstName() : firstName;
            string lName = lastName == "ANY" ? Name.LastName() : lastName;
            string divider = Datatype.Boolean() ? "-" : "_";
            return fName + divider + lName + Datatype.Int(1, 100).ToString();
        }

        public static string Protocol()
        {
            bool coinToss = Datatype.Boolean();
            return coinToss ? "http" : "https";
        }

        public static string DomainSuffix()
        {
            var internet = new Locales.Internet();
            return Helpers.Randomize(internet.DomainSuffixes);

        }

        public static string DomainName()
        {
            return Lorem.Word() + DomainSuffix();
        }

        public static string DomainWord()
        {
            return Lorem.Word();
        }

        //TODO
        /*
        *ip
        *ipv6
        *userAGent
        *color
        *mac
        *password


        */


    }
}