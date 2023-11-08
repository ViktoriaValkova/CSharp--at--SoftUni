using System;
namespace PersonsInfo
{
	public class Team
	{
		private string name;
		private List<Person> firstTeam;
		private List<Person> reserveTeam;

		public Team(string name)
		{
			this.name = name;
			FirstTeam = new List<Person>();
			ReserveTeam = new List<Person>();
		}

		public List<Person> FirstTeam {get;}
		public List<Person> ReserveTeam {get; }

		public void AddPlayer(Person person)
		{
			if (person.Age < 40)
			{
				this.FirstTeam.Add(person);
				return;
			}

			this.ReserveTeam.Add(person);
		}

    }
}

