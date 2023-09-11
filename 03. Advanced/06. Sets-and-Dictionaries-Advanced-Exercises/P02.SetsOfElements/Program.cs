namespace P02.SetsOfElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] lengths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			int firstLength = lengths[0];
			int secondLength = lengths[1];
			HashSet<int> firstSet = new HashSet<int>();
			HashSet<int> secondSet = new HashSet<int>();

			for (int i = 0; i < firstLength; i++)
			{
				firstSet.Add(int.Parse(Console.ReadLine()));
			}
			for (int i = 0; i < secondLength; i++)
			{
				secondSet.Add(int.Parse(Console.ReadLine()));
			}

			firstSet.IntersectWith(secondSet);
			Console.WriteLine(string.Join(' ',firstSet));
		}
	}
}