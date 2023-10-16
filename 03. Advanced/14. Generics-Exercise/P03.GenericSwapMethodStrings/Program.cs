
namespace P03.GenericSwapMethodStrings
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			List<Box<string>> list = new List<Box<string>>();

			for (int i = 0; i < count; i++)
			{
				string item = Console.ReadLine();
				var currentBox = new Box<string>(item);
				list.Add(currentBox);
			}

			int[] indexes = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			Swap(list, indexes[0], indexes[1]);
			Console.WriteLine(string.Join(Environment.NewLine, list));
		}

		 static void Swap<T>(List<T> list, int first, int second)
		{
			(list[first], list[second]) = (list[second], list[first]);
		}
	}
}