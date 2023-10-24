namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> programmerTime = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

			Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)));

			Dictionary<string, int> duckiesByCount = new Dictionary<string, int>();
			duckiesByCount["Dart Vader"] = 0;
			duckiesByCount["Thor"] = 0;
			duckiesByCount["Big Blue"] = 0;
			duckiesByCount["Small yellow"] = 0;

			while (programmerTime.Count > 0 || tasks.Count > 0)
			{
				int currentTask = tasks.Pop();
				int currentTime = programmerTime.Dequeue();

				int result = currentTime * currentTask;

				if (result >= 0 && result <= 60)
				{
					duckiesByCount["Dart Vader"]++;
				}
				else if (result >= 61 && result <= 120)
				{
					duckiesByCount["Thor"]++;
				}
				else if (result >= 121 && result <= 180)
				{
					duckiesByCount["Big Blue"]++;
				}
				else if (result >= 181 && result <= 240)
				{
					duckiesByCount["Small yellow"]++;
				}
				else
				{
					currentTask -= 2;
					tasks.Push(currentTask);
					programmerTime.Enqueue(currentTime);
				}

			}

			Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
			Console.WriteLine($"Darth Vader Ducky: {duckiesByCount["Dart Vader"]}\n" +
			                  $"Thor Ducky: {duckiesByCount["Thor"]}\n" +
			                  $"Big Blue Rubber Ducky: {duckiesByCount["Big Blue"]}\n" +
			                  $"Small Yellow Rubber Ducky: {duckiesByCount["Small yellow"]}\n");
		}
	
	}
}