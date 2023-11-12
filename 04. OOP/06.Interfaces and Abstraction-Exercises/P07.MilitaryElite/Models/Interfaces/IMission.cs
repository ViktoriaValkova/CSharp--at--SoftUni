using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Enum;

namespace P07.MilitaryElite.Models.Interfaces
{
	public interface IMission
	{
		public string CodeName { get; }
		public State State { get; }

		public void CompleteMission();
	}
}
