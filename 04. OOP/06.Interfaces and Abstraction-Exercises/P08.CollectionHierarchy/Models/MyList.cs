using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P08.CollectionHierarchy.Models.Interfaces;

namespace P08.CollectionHierarchy.Models
{
	public class MyList : IMyList
	{
		private List<string> items;
		private const int RemoveIndex = 0;
		private const int AddIndex = 0;
		public MyList()
		{
			items= new List<String>(100);
		}

		public int Used => items.Count;

		public string Remove()
		{
			string item = items[RemoveIndex];
			 items.RemoveAt(RemoveIndex);
			 return item;
		}

		public int AddToCollection(string item)
		{
			items.Insert(AddIndex, item);
			return AddIndex;
		}
	}
}
