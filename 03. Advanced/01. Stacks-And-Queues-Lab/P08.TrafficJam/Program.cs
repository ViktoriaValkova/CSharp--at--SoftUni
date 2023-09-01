namespace P08.TrafficJam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countPassing = int.Parse(Console.ReadLine());
			string input = string.Empty;
			Queue<string> cars = new Queue<string>();
			int totalPassed = 0;
			while ((input = Console.ReadLine()) != "end")
			{
				if (input == "green")
				{
					for (int i = 0; i < countPassing; i++)
					{
						if (cars.Count > 0)
						{
							Console.WriteLine($"{cars.Dequeue()} passed!");
							totalPassed++;
						}
					}
				}
				else
				{
					cars.Enqueue(input);
				}
			}

			Console.WriteLine($"{totalPassed} cars passed the crossroads.");
		}
	}
}