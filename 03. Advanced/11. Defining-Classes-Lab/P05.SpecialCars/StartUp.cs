namespace CarManufacturer
{
	internal class StartUp
	{
		static List<Tire[]> tiresCollection = new List<Tire[]>();
		static List<Engine> engineCollection = new List<Engine>();
		static List<Car> carCollection = new List<Car>();
		static void Main(string[] args)
		{
			getTires();
			getEngines();
			getCars();

			var specialCars = carCollection.Where(c => c.Year >= 2017 && c.Engine.HorsePower > 330
			&& (c.SumTirePressure(c.Tires) > 9 && c.SumTirePressure(c.Tires) < 10)).ToList();

			foreach (Car car in specialCars)
			{
				car.Drive(20);
				Console.WriteLine(car.WhoAmI());
			}
		}

		private static void getTires()
		{
			string input = string.Empty;

			while ((input = Console.ReadLine()) != "No more tires")
			{
				double[] tireInfo = input
					.Split()
					.Select(double.Parse)
					.ToArray();

				Tire[] tires = new Tire[]
				{
					new Tire((int)tireInfo[0], tireInfo[1]),
					new Tire((int)tireInfo[2], tireInfo[3]),
					new Tire((int)tireInfo[4], tireInfo[5]),
					new Tire((int)tireInfo[6], tireInfo[7]),
				};


				tiresCollection.Add(tires);
			}
		}
		private static void getEngines()
		{
			string input = string.Empty;
			while ((input = Console.ReadLine()) != "Engines done")
			{
				double[] engineInfo = input
					.Split()
					.Select(double.Parse)
					.ToArray();

				Engine newEngine = new Engine((int)engineInfo[0], engineInfo[1]);
				engineCollection.Add(newEngine);
			}
		}
		private static void getCars()
		{
			string input = string.Empty;
			while ((input = Console.ReadLine()) != "Show special")
			{
				string[] info = input
					.Split()
					.ToArray();
				string make = info[0];
				string model = info[1];
				int year = int.Parse(info[2]);
				double fuelQnt = double.Parse(info[3]);
				double fuelConsumption = double.Parse(info[4]);
				int engineIndex = int.Parse(info[5]);
				int tiresIndex = int.Parse(info[5]);


				Car newCar = new Car(make, model, year, fuelQnt, fuelConsumption, engineCollection[engineIndex], tiresCollection[tiresIndex]);

				carCollection.Add(newCar);
			}
		}
	}
}