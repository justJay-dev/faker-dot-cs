
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

        public static string Url()
        {
            return Protocol() + "://" + DomainName();
        }


        public static string DomainName()
        {
            return Lorem.Word() + DomainSuffix();
        }

        public static string DomainSuffix()
        {
            var internet = new Locales.Internet();
            return "." + Helpers.Randomize(internet.DomainSuffixes);

        }

        public static string DomainWord()
        {
            return Lorem.Word();
        }


        public static string IP()
        {
            return Datatype.Int(0, 255).ToString() + "." + Datatype.Int(0, 255).ToString() + "." + Datatype.Int(0, 255).ToString() + "." + Datatype.Int(0, 255).ToString();
        }

        public static string IPv6()
        {
            return Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4) + ":" + Datatype.Hexadecimal(4);
        }

        /*
        public static string UserAgent()
        {
            // generates a random user agent string based on https://github.com/jmealo/random-ua.js/blob/master/random_ua.js
            var internet = new Locales.Internet();
            var os = Helpers.Randomize(internet.OperatingSystems);
            var browser = Helpers.Randomize(internet.Browsers);
            var version = Helpers.Randomize(internet.BrowserVersions[browser]);


        }
        */

        public static string Color()
        {
            return "#" + Datatype.Hexadecimal(6);
        }

        public static string Mac()
        {
            return Datatype.Hexadecimal(2) + ":" + Datatype.Hexadecimal(2) + ":" + Datatype.Hexadecimal(2) + ":" + Datatype.Hexadecimal(2) + ":" + Datatype.Hexadecimal(2) + ":" + Datatype.Hexadecimal(2);
        }

        //TODO: add support for  regex
        public static string Password(int minLength = 8, int maxLength = 16, bool memorable = false, string regex = null, string prefix = null)
        {

            string password = Lorem.Word();
            regex = regex ?? @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)";
            if (!string.IsNullOrEmpty(prefix))
            {
                password = prefix + password;
            }
            if (memorable)
            {
                password = password + Company.BSVerbs();
                //length stuff
                if (password.Length < minLength)
                {
                    password = password + Company.BSVerbs();
                }
                if (password.Length > maxLength)
                {
                    password = password.Substring(0, maxLength);
                }
                /* todo
                if (regex != null)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(password, regex))
                    {
                        password = password + Company.BSVerbs();
                    }

                }
                */
                return password;

            }
            else
            {
                password = password + Lorem.Word();
                if (password.Length < minLength)
                {
                    password = password + Lorem.Word();
                }
                if (password.Length > maxLength)
                {
                    password = password.Substring(0, maxLength);
                }

                return password;
            }

        }




    }
}