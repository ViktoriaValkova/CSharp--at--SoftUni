namespace CarManufacturer
{
	public class Program
	{
		 static List<Car>cars = new List<Car>();
		static void Main(string[] args)
		{
			GetCars();

			string desiredType = Console.ReadLine();
			List<Car> desiredCars = new List<Car>();
			if (desiredType == "fragile")
			{
				desiredCars = Car.FragileCars(cars);
			}
			else
			{
				desiredCars = Car.FlammabaleCars(cars);
			}

			Console.WriteLine(string.Join(Environment.NewLine, desiredCars));
		}

		private static void GetCars()
		{
			int count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				string[] input = Console.ReadLine().Split().ToArray();

				Car car = new Car(input[0],int.Parse(input[2]), int.Parse(input[1]),int.Parse(input[3]),input[4], double.Parse(input[5]), int.Parse(input[6]),double.Parse(input[7]),int.Parse(input[8]), double.Parse(input[9]),int.Parse(input[10]), double.Parse(input[11]),int.Parse(input[12]));
				cars.Add(car);
			}
		}
	}
}