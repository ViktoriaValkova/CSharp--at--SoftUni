﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.MilitaryElite.Models.Interfaces
{
	public interface IEngineer
	{
		public List<Repair> Repairs { get; }
	}
}
