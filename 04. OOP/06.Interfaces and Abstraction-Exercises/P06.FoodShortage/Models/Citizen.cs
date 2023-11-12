using P04.BorderControl.Models.Interfaces;
using P05.BirthdayCelebrations.Models.Interfaces;
using P06.FoodShortage.Models.Interfaces;

namespace P04.BorderControl.Models
{
	public class Citizen : IIdentifiable, IAge, IBuyer
	{
		private string name;
		private int age;
		private string birthDate;

		public Citizen( string name, int age,string id, string birthdate)
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

		public int Food { get; private set; }

		public int BuyFood()
		{
			this.Food += 10;
			return 10;
		}
	}
}
