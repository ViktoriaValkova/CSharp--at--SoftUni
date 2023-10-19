namespace P01.TempleOfDoom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> tools = new Queue<int>(Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x)));
			
			Stack<int> substances = new Stack<int>(Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x)));

			List<int> challenges = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x))
				.ToList();

			while (substances.Count>0 && tools.Count>0 && challenges.Count>0)
			{
				int currentTool = tools.Dequeue();
				int currentSubstance = substances.Pop();
				int result = currentTool * currentSubstance;
				if (challenges.Contains(result))
				{
					challenges.Remove(result);
					continue;
				}

				currentTool ++;
				tools.Enqueue(currentTool);
				currentSubstance -- ;
				if (currentSubstance > 0)
				{
					substances.Push(currentSubstance);
				}

			}

			 if (!challenges.Any())
			{
				Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
			}
			else if (!substances.Any()|| !tools.Any())
			{
				Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
			}


			if (tools.Any())
			{
				Console.WriteLine($"Tools: {string.Join(", ",tools)}");
			}
			if (substances.Any())
			{
				Console.WriteLine($"Substances: {string.Join(", ", substances)}");
			}
			if (challenges.Any())
			{
				Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
			}
		}
	}
}