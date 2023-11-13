using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P08.CollectionHierarchy.Models.Interfaces;

namespace P08.CollectionHierarchy.Models
{
	public class AddCollection : IAddable
	{
		private List<string> myCollection;

		public AddCollection()
		{
			myCollection = new List<string>(100);
		}
		public int AddToCollection(string item)
		{
			myCollection.Insert(0,item);
			return myCollection.Count-1;
		}
	}
}
