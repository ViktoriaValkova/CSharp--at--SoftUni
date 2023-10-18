

using System.Collections;
using System.Xml.Linq;

namespace P03.Stack
{
	public class MyStack<T> : IEnumerable<T>
	{
		private List<T> _list;

		public MyStack()
		{
			this._list = new List<T>();
		}
		public List<T> CustomList { get { return _list; } }
		public IEnumerator<T> GetEnumerator()
		{
			for (int i = CustomList.Count-1; i >= 0; i--)
			{
				yield return CustomList[i];
			}
               
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public void Pop()
		{
			if (this.CustomList.Count >0)
			{
				this.CustomList.RemoveAt(this.CustomList.Count-1);
			}
			else
			{
				throw new InvalidOperationException("No elements");
			}
		}

		public void Push(params T [] items)
		{
			this.CustomList.AddRange(items);
		}
	}
}
