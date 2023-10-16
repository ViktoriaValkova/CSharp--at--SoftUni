namespace P07.Tuple
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] firstArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			MyTuple<string, string> first = new MyTuple<string, string>(firstArr[0] +" "+ firstArr[1], firstArr[2]);
			string[] secondArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			MyTuple<string, int> second = new MyTuple<string, int>(secondArr[0], int.Parse(secondArr[1]));
			string[] thirdArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			MyTuple<int, double> third = new MyTuple<int, double>(int.Parse(thirdArr[0]), double.Parse(thirdArr[1]));

			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);
		}
	}
}