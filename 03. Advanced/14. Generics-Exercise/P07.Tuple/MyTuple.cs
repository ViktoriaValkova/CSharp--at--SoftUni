

namespace P07.Tuple
{
	internal class MyTuple <T,D>
	{
		public MyTuple(T item1, D item2)
		{
			this.item1 = item1; 
			this.item2 = item2;
		}

		private T item1;
		private D item2;

		public T Item1
		{
			get { return this.item1; } 
			set { this.item1 = value; }
		}

		public D Item2
		{
			get { return this.item2; }
			set { this.item2 = value; }
		}

		public override string ToString()
		{
			return $"{this.Item1} -> {this.Item2}"; 
		}

	}
}
