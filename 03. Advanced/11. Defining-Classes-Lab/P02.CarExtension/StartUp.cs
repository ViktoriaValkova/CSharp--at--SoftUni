namespace CarManufacturer
{
	 public class StartUp
	{
		static void Main()
		{
			Car car = new Car();
			car.Make = "BMW";
			car.Model = "C6";
			car.Year = 2015;
			car.FuelQuantity = 200;
			car.FuelConsumption = 0.07;

			car.Drive(6000);
			Console.WriteLine(car.WhoAmI());
		}
	}
}