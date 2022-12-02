using System;
using System.Collections.Generic;
namespace Faker.Locales
{
	public partial class Database
	{
		public List<string> Engines = new List<string>
		{
			"InnoDB",
			"MyISAM",
			"MEMORY",
			"CSV",
			"BLACKHOLE",
			"ARCHIVE"
		};
	}
}