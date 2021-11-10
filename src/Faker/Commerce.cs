using System;
namespace Faker
{
	public class Commerce
	{
		public static string Color()
		{
			var commerce = new Locales.Commerce();
			return Helpers.Pick.RandomList(commerce.Colors);
		}
		public static string Department()
		{
			var commerce = new Locales.Commerce();
			return Helpers.Pick.RandomList(commerce.Departments);
		}
		public static string ProductAdjective()
		{
			var commerce = new Locales.Commerce.ProductNames();
			return Helpers.Pick.RandomList(commerce.Adjectives);
		}
		public static string ProductMaterial()
		{
			var commerce = new Locales.Commerce.ProductNames();
			return Helpers.Pick.RandomList(commerce.Materials);
		}
		public static string Product()
		{
			var commerce = new Locales.Commerce.ProductNames();
			return Helpers.Pick.RandomList(commerce.Products);
		}
		public static string ProductName()
		{
			var commerce = new Locales.Commerce.ProductNames();
			return (ProductAdjective() + " " + ProductMaterial() + " " + Product());
		}

		public static string Price(double min = 1, double max = 1000, int dec = 2, string symbol = "")
		{
			var theAmount = (decimal)Datatype.Double(min, max);
			return (symbol + (Decimal.Round(theAmount, dec).ToString()));

		}


	}
}