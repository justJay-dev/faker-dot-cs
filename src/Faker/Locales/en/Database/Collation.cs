using System;
using System.Collections.Generic;
namespace Faker.Locales
{
	public partial class Database
	{
		public List<string> Collations = new List<string>
		{
			"utf8_unicode_ci",
			"utf8_general_ci",
			"utf8_bin",
			"ascii_bin",
			"ascii_general_ci",
			"cp1250_bin",
			"cp1250_general_ci"
		};
	}
}