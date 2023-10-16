
namespace P06.GenericCountMethodDoubles
{
	public class Box<T> where T : IComparable<T>
	{
		public Box () 
		{
			this.Items = new List<T>();
		}

		private List<T> Items;

		public void Add(T item)
		{
			this.Items.Add(item);
		}

		public int Count(T element)
		{
			int counter = 0;
			foreach (var item in Items)
			{
				if (item.CompareTo(element) > 0)
				{
					counter++;
				}
			}
			return counter;
		}
	}
}
