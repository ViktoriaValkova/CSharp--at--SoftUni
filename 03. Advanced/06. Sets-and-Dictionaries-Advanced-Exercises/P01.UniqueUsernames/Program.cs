namespace P01.UniqueUsernames
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> names = new HashSet<string>();
			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				names.Add(Console.ReadLine());
			}
			names.ToList().ForEach(x => Console.WriteLine(x));
		}
	}
}