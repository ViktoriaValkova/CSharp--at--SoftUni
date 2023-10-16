

namespace P03.GenericSwapMethodStrings
{
	public class Box<T>
	{
		public Box (T value)
		{
			this.Item=value;
			this.ListBoxes = new List<Box<T>>();
		}

		private T Item;

		public override string ToString()
		{
			return	this.Item.GetType() + ": " + this.Item;
		}

		public List<Box<T>> ListBoxes { get; private set; }

	}
}
