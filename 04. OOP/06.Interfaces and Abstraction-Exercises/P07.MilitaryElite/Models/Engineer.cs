using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Enum;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public class Engineer :SpecialisedSoldier, IEngineer
	{
		public List<Repair> Repairs
		{
			get;
			set;
		}

		public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps, params Repair[] repairs) : base(
			id, firstName, lastName, salary, corps)
		{
			Repairs = new List<Repair>(repairs);
		}

		public override string ToString()
		{
			string addText = "\nRepairs:";
			if (Repairs.Count != 0)
			{
				addText += $"\n  {string.Join("\n  ", Repairs)}";
			}

			return base.ToString() + addText;
		}
	}
}
