

namespace P08.Threeuple
{
	internal class MyThreeuple <T,D,F>
	{
		public MyThreeuple(T item1, D item2, F item3)
		{
			this.item1 = item1; 
			this.item2 = item2;
			this.item3 = item3;
		}

		private T item1;
		private D item2;
		private F item3;

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

		public F Item3
		{
			get { return this.item3; }
			set { this.item3 = value; }
		}

		public override string ToString()
		{
			return $"{this.Item1} -> {this.Item2} -> {this.Item3}"; 
		}

	}
}
