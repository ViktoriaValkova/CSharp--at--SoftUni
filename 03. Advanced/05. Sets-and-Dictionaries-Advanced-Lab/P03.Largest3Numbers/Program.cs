namespace P03.Largest3Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

			var orderedNums = nums.OrderByDescending(num => num).Take(3); 

			Console.WriteLine(string.Join(" ",orderedNums));
		}
	}
}