using P01.GenericBoxOfString;

namespace P02.GenericBoxOfInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				int item = int.Parse(Console.ReadLine());
				var currentBox = new Box<int>(item);
				Console.WriteLine(currentBox.ToString());
			}
		}
	}
}