namespace P01.MonsterExtermination
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> armors = new Queue<int>(Console.ReadLine()
				.Split(",", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse));

			Stack<int> strikes = new Stack<int>(Console.ReadLine()
				.Split(",", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse));

			int killedCnt = 0;

			while (armors.Count>0 && strikes.Count>0)
			{
				if (strikes.Peek() >= armors.Peek())
				{
					killedCnt++;
					int impact = armors.Dequeue();
					int newStrike = strikes.Pop() - impact;
					if (newStrike == 0)
					{
						continue;
					}

					if (strikes.Count > 0)
					{

					 newStrike += strikes.Pop();
					}
					strikes.Push(newStrike);
				}
				else
				{
					int monsterArmor = armors.Dequeue() - strikes.Pop();
					armors.Enqueue(monsterArmor);
				}
			}

			if (armors.Count == 0)
			{
				Console.WriteLine("All monsters have been killed!");
			} 
			if (strikes.Count  == 0)
			{
				Console.WriteLine("The soldier has been defeated.");
			}

			Console.WriteLine($"Total monsters killed: {killedCnt}");
		}
	}
}