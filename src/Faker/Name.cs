using System.Collections.Generic;
namespace Faker
{
	public enum GenderPresentations : int
	{
		MASC = 0,
		FEM = 1,
		ANY = 2,
	}
	public class Name
	{
		public static string FirstName(int presentation = (int)GenderPresentations.ANY)
		{
			var names = new Locales.Name();
			switch ((GenderPresentations)presentation)
			{
				case GenderPresentations.MASC:
					return Helpers.Randomize(names.MascFirstNames);
				case GenderPresentations.FEM:
					return Helpers.Randomize(names.FemFirstNames);
				default:
					return Helpers.Randomize(names.FirstNames);
			}

		}
		public static string LastName()
		{
			var names = new Locales.Name();
			return Helpers.Randomize(names.LastNames);
		}

		public static string FindName(string firstName = "ANY", string lastName = "ANY", int presentation = (int)GenderPresentations.ANY)
		{
			var names = new Locales.Name();
			var fName = firstName == "ANY" ? FirstName(presentation) : firstName;
			var lName = lastName == "ANY" ? LastName() : lastName;
			return fName + " " + lName;

		}
		public static string JobTitle()
		{
			var names = new Locales.Name.Titles();

			return Helpers.Randomize(names.Descriptors) + " " + Helpers.Randomize(names.Levels) + " " + Helpers.Randomize(names.Jobs);
		}
		public static string Prefix(int presentation = (int)GenderPresentations.ANY)
		{
			var names = new Locales.Name.Prefixes();
			switch ((GenderPresentations)presentation)
			{
				case GenderPresentations.MASC:
					return Helpers.Randomize(names.Masc);
				case GenderPresentations.FEM:
					return Helpers.Randomize(names.Fem);
				default:
					List<string> prefixes = new List<string>();
					prefixes.AddRange(names.Masc);
					prefixes.AddRange(names.Fem);
					return Helpers.Randomize(prefixes);
			}
		}
		public static string Suffix()
		{
			var names = new Locales.Name();
			return Helpers.Randomize(names.Suffixes);
		}

		public static string Title()
		{
			var names = new Locales.Name.Titles();
			return Helpers.Randomize(names.Descriptors) + " " + Helpers.Randomize(names.Levels) + " " + Helpers.Randomize(names.Jobs);
		}
		public static string JobDescriptor()
		{
			var names = new Locales.Name.Titles();
			return Helpers.Randomize(names.Descriptors);
		}
		public static string JobArea()
		{
			var names = new Locales.Name.Titles();
			return Helpers.Randomize(names.Levels);
		}
		public static string JobType()
		{
			var names = new Locales.Name.Titles();
			return Helpers.Randomize(names.Jobs);
		}

	}
}