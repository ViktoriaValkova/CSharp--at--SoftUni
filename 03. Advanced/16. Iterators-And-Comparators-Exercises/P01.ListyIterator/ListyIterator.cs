

namespace P01.ListyIterator
{
	public class ListyIterator<T>
	{
		private List<T> _list;
		private int _index = 0;
		public ListyIterator()
		{
			this._list = new List<T>();
		}
		public List<T> List { get { return _list; } }
		public bool Move()
		{
			if (_index < _list.Count-1)
			{
				this._index++;
				return true;
			}
			return false;
		}

		public bool HasNext()
		{
			if (this._index < _list.Count-1)
			{
				return true;
			}
			return false;
		}

		public void Print()
		{
			if (this._list.Count > 0)
			{
			Console.WriteLine(this._list[this._index]);
			}
			else
			{
				throw new Exception("Invalid Operation!"); 
			}
		}

	}
}
