
namespace P07.PredicateForNames
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine()); 

			Predicate<int> lessThan = x => x<=n;

			string[] names = Console.ReadLine()
				.Split()
				.Where(x => lessThan(x.Length))
				.ToArray();

			Console.WriteLine(string.Join(Environment.NewLine, names));
		}
	}
}