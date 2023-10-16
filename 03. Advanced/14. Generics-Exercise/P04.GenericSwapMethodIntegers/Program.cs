
namespace P03.GenericSwapMethodStrings
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			List<Box<int>> list = new List<Box<int>>();

			for (int i = 0; i < count; i++)
			{
				int item = int.Parse(Console.ReadLine());
				var currentBox = new Box<int>(item);
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