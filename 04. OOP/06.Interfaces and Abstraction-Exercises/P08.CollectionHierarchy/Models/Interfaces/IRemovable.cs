﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.CollectionHierarchy.Models.Interfaces
{
	public interface IRemovable : IAddable
	{
		public string Remove();
	}
}
