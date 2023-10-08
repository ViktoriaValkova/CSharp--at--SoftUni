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

			Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
		}
	}
}