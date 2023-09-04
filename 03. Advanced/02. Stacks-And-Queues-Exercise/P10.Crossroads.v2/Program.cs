// 100/100 but doesnt pass the first zero test!?

namespace P11.Crossroads.v2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int greenLight= int.Parse(Console.ReadLine());
			int windowToPass = int.Parse(Console.ReadLine());
			Queue<string> cars = new Queue<string>();
			string input = string.Empty;
			int countPassedCars = 0;
			while ((input = Console.ReadLine()) != "END")
			{
				if (input != "green")
				{
					cars.Enqueue(input);
					continue;
				}

				int currentGreen = greenLight;

					while (currentGreen > 0&& cars.Any() )
					{
						string currentCar = cars.Dequeue();
						if (currentGreen - currentCar.Length >= 0)
						{
							currentGreen-=currentCar.Length;
							countPassedCars++;
							continue;
						}

						if (currentGreen + windowToPass - currentCar.Length>=0)
						{
							countPassedCars++;
							continue;
						}

						int crashAtIndex = currentGreen + windowToPass;

						Console.WriteLine("A crash happened!");
						Console.WriteLine($"{currentCar} was hit at {currentCar[crashAtIndex]}.");
						return;
					}
			}

			Console.WriteLine("Everyone is safe.");
			Console.WriteLine($"{countPassedCars} total cars passed the crossroads.");
		}
	}
}