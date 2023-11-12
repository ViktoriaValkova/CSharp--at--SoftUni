using P07.MilitaryElite.Models.Enum;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public class Commando : SpecialisedSoldier, ICommando 
	{
		public List<Mission> Missions { get; set; }

		public Commando(string id, string firstName, string lastName, decimal salary, Corps corps,
			params Mission[] missions) : base(id, firstName, lastName, salary, corps)
		{
			Missions = new List<Mission>(missions);
		}

		public override string ToString()
		{
			string addText = "\nMissions:";
			if (Missions.Count != 0)
			{
				addText += $"\n  {string.Join("\n  ", Missions)}";
			}

			return base.ToString() + addText;
		}

		
	}
}
