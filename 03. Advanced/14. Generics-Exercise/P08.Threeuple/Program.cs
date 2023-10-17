namespace P08.Threeuple
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] firstArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string town = string.Join(" ",firstArr[3..]);
			MyThreeuple<string, string,string> first = new MyThreeuple<string, string, string>(firstArr[0] +" "+ firstArr[1], firstArr[2], town);

			string[] secondArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			bool isDrunk = secondArr[2] == "drunk";
			MyThreeuple<string, int,bool> second = new MyThreeuple<string, int,bool>(secondArr[0], int.Parse(secondArr[1]), isDrunk);

			string[] thirdArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			MyThreeuple<string, double, string> third = new MyThreeuple<string, double, string>(thirdArr[0], double.Parse(thirdArr[1]), thirdArr[2]);

			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);
		}

	}
}