

namespace P01.GenericBoxOfString
{
	public class Box<T>
	{
		public Box (T value)
		{
			this.Item=value;
		}

		private T Item;

		public override string ToString()
		{
			return	this.Item.GetType() + ": " + this.Item;
		}
	}
}
