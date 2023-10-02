namespace P01.SortEvenNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split(", ")
				.Select(x=>int.Parse(x))
				.Where(x => x%2 ==0)
				.OrderBy(x=>x)
				.ToArray();

			Console.Write(string.Join(", ", numbers));
		}
	}
}