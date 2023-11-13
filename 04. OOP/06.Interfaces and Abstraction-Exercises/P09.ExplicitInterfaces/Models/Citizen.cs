using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P09.ExplicitInterfaces.Models.Interfaces;

namespace P09.ExplicitInterfaces.Models
{
	public class Citizen :IResident, IPerson
	{
		public string Name { get; }
		public int Age { get; }

		public Citizen(string name, string country, int age)
		{
			Name = name;
			Age = age;
			Country = country;
		}

		string IPerson.GetName()
		{
			return Name;
		}

		public string Country { get; }
		 string IResident.GetName()
		{
			return $"Mr/Ms/Mrs {Name}";
		}
	}
}
