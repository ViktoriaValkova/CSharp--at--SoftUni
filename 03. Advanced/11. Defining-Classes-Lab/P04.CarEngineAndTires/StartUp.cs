
namespace CarManufacturer
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			Tire[] tires = new Tire[4]
			{
				new Tire(1, 2.5),
				new Tire(1, 2.4),
				new Tire(2, 2.55),
				new Tire(2, 2.4)
			};

			Engine engine = new Engine(560, 5000);

			Car car = new Car("Benz", "C200", 2020, 100, 10, engine, tires);

			Console.WriteLine(car.WhoAmI());
		}
	}
}