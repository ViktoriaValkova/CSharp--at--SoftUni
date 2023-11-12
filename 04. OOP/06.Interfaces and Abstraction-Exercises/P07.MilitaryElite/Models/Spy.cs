using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public class Spy : Soldier, ISpy
	{
		public int CodeNumber { get; private set; }

		public Spy(string id, string firstName, string lastName, int codeNumber) : base(firstName, lastName, id)
		{
			CodeNumber = codeNumber;
		}

		public override string ToString()
		{
			return base.ToString()+$"\nCode Number: {CodeNumber}";
		}
	}
}
