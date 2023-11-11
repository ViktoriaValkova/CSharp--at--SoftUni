using P04.BorderControl.Models.Interfaces;

namespace P04.BorderControl.Models
{
	public class Citizen : IIdentifiable
	{
		private string name;
		private int age;

		public Citizen(string id, string name, int age)
		{
			Id = id;
			Name = name;
			Age = age;
		}
		public string Id { get;private set; }

		public int Age
		{
			get { return age; }
			set
			{
				age=value;
			}
		}

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
			}
		}
	}
}
