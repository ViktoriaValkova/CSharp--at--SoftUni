using P04.BorderControl.Models.Interfaces;
using P05.BirthdayCelebrations.Models.Interfaces;

namespace P04.BorderControl.Models
{
	public class Citizen : IIdentifiable, INameable, IBirthable 
	{
		private string name;
		private int age;
		private string birthDate;

		public Citizen(string id, string name, int age, string birthdate)
		{
			Id = id;
			Name = name;
			Age = age;
			Birthdate = birthdate;
		}
		public string Id { get;private set; }

		public int Age
		{
			get { return age; }
			private set
			{
				age=value;
			}
		}

		public string Name
		{
			get { return name; }
			 private set
			{
				name = value;
			}
		}

		public string Birthdate
		{
			get { return birthDate; }
			private set
			{
				birthDate = value;
			}
		}
	}
}
