using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public class Repair : IRepair
	{
		public string PartName { get; set; }

		public int HoursWorked { get; set; }

		public Repair(string partName, int hours)
		{
			PartName = partName;
			HoursWorked = hours;
		}

		public override string ToString()
		{
			return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
		}
	}
}
