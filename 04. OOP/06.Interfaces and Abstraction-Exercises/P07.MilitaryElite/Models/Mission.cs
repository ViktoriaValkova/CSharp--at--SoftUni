using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P07.MilitaryElite.Models.Enum;
using P07.MilitaryElite.Models.Interfaces;

namespace P07.MilitaryElite.Models
{
	public class Mission : IMission
	{
		public string CodeName { get; set; }

		public State State { get; set; }
		public Mission(string codeName, State state)
		{
			CodeName = codeName;
			State = state;
		}

		public void CompleteMission()
		{
			State = State.Finished;
		}

		public override string ToString()
		{
			return $"Code Name: {CodeName} State: {State}";
		}
	}
}
