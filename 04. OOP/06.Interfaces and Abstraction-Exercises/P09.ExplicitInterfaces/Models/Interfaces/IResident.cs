using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.ExplicitInterfaces.Models.Interfaces
{
	public interface IResident
	{
		string Name { get; }
		string Country { get; }

	public string GetName();
	}
}
