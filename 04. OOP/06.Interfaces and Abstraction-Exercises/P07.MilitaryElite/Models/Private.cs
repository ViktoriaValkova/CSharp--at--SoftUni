using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.MilitaryElite.Models
{
	public class Private : Soldier, IPrivate
	{
		public decimal Salary { get; set; }

		public Private(string firstName, string lastName, string id, decimal salary) : base(firstName,lastName, id)
		{
			Salary=salary;
		}

		public override string ToString()
		{
			return base.ToString() + $" Salary: {Salary:f2}"; 
		}
	}
}
