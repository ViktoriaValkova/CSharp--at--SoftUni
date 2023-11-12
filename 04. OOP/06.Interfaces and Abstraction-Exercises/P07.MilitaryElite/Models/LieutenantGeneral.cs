using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.MilitaryElite.Models
{
	public class LieutenantGeneral : Private, ILieuenantGeneral
	{
		public List<Private> Privates
		{
			get;
			private set;
		}

		public LieutenantGeneral(string firstName, string lastName, string id, decimal salary,
			params Private[] privates) : base(firstName, lastName, id, salary)
		{
			Privates= new List<Private>(privates);
		}

		public override string ToString()
		{
			return base.ToString() + $"\nPrivates: {string.Join("\n  ", Privates)}";
		}
	}
}
