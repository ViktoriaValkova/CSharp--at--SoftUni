namespace P03.PeriodicTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			HashSet<string> elements = new HashSet<string>();

			for (int i = 0; i < count; i++)
			{
				string[] inputElements = Console.ReadLine().Split().ToArray();

				foreach (var element in inputElements)
				{
					elements.Add(element);
				}
			}

			Console.WriteLine(string.Join(" ", elements.OrderBy(e=>e)));
		}
	}
}