using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Enum;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
	{
		public Corps Corps { get; set; }

		public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) : base(
			firstName, lastName, id, salary)
		{
			Corps=corps;
		}

		public override string ToString()
		{
			return base.ToString()+ $"\nCorps: {Corps}";
		}
	}
}
