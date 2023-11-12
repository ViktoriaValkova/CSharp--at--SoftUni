

using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public abstract class Soldier : ISoldier
	{
		public string Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		protected Soldier(string firstName, string lastName, string id)
		{
			FirstName=firstName;
			LastName=lastName; 
			Id=id;
		}

		public override string ToString()
		{
			return $"Name: {FirstName} {LastName} Id: {Id}";
		}
	}

}
