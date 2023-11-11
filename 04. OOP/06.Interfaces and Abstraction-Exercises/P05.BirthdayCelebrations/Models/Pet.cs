using P05.BirthdayCelebrations.Models.Interfaces;
using System.Xml.Linq;

namespace P05.BirthdayCelebrations.Models
{
	public class Pet : INameable, IBirthable
	{
		private string birthDate;
		private string name;

		public Pet(string name, string birthDate)
		{
			Name=name;
			Birthdate=birthDate;
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
