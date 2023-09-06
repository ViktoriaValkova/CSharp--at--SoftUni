namespace P10.Crossroads
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int greenSeconds = int.Parse(Console.ReadLine());
			int freeWinSeconds = int.Parse(Console.ReadLine());
			string input = string.Empty;
			Queue<string> cars = new Queue<string>();
			int countCrossed = 0;
			while ((input = Console.ReadLine()) != "END")
			{
				if (input == "green")
				{
					int currentGreen = greenSeconds;
					while (cars.Count > 0&& cars.Peek().Length < currentGreen )
					{
						currentGreen-=cars.Peek().Length;
						cars.Dequeue();
						countCrossed++;
					}
					if (cars.Count > 0 && cars.Peek().Length <= freeWinSeconds+currentGreen)
					{
						countCrossed++;
						cars.Dequeue();
					}
					else if (cars.Count >  0&& cars.Peek().Length > freeWinSeconds + currentGreen)
					{
						char crashIndex = cars.Peek()[freeWinSeconds+currentGreen];
						Console.WriteLine("A crash happened!");
						Console.WriteLine($"{cars.Peek()} was hit at {crashIndex}.");
						return;
					}


				}
				else
				{
					cars.Enqueue(input);
				}
			}

			Console.WriteLine("Everyone is safe.");
			Console.WriteLine($"{countCrossed} total cars passed the crossroads.");
		}
	}
}