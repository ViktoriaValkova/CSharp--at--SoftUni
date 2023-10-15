
using System.Reflection.Metadata.Ecma335;

namespace BoxOfT
{
	public  class Box<T>
	{
		public Box()
		{
			this.Items = new List<T>();
		}

		private List<T> Items { get; set; }

		public void Add(T item)
		{
			this.Items.Add(item);
		}

		public T Remove()
		{
			var removed = this.Items[this.Items.Count - 1];
				this.Items.RemoveAt(this.Items.Count - 1);
				return removed;
		}

		public int Count
		{
			get => this.Items.Count;
		}
	}
}
