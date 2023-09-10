namespace P04.EvenTimes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			Dictionary<int,int> countByNum = new Dictionary<int,int>();

			for (int i = 0; i < count; i++)
			{
				int currentNum = int.Parse(Console.ReadLine());

				if (!countByNum.ContainsKey(currentNum))
				{
					countByNum.Add(currentNum, 0);
				}
				countByNum[currentNum]++;
			}

			foreach (var kvp in countByNum)
			{
				if (kvp.Value % 2 == 0)
				{
					Console.WriteLine(kvp.Key);
				}
			}
		}
	}
}