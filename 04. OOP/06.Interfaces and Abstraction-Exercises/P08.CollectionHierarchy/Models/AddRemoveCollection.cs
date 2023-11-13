
using P08.CollectionHierarchy.Models.Interfaces;

namespace P08.CollectionHierarchy.Models
{
	public class AddRemoveCollection : IRemovable
	{
		private List<string> items;

		private const int AddIndex = 0;
		public AddRemoveCollection()
		{
			items = new List<string>(100);
		}

		public int AddToCollection(string item)
		{
			items.Insert(AddIndex, item);
			return AddIndex;
		}
		public string Remove()
		{
			int index = items.Count - 1;
			string item = items[index];
			items.RemoveAt(index);
			return item;
		}
	}
}
