namespace P06.Supermarket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = string. Empty;
			Queue<string> queue = new Queue<string>();
			while ((input = Console.ReadLine()) != "End")
			{
				if (input == "Paid")
				{
					Console.WriteLine(string.Join("\n", queue ));
					queue.Clear();
				}
				else
				{
					queue.Enqueue(input);
				}
			}

			Console.WriteLine($"{queue.Count} people remaining.");
		}
	}
}