using P02.Cars;

namespace Cars
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			ICar seat = new Seat("Leon", "Grey");
			ICar tesla = new Tesla("Model 3", "Red", 2);

			Console.WriteLine(seat.ToString());
			Console.WriteLine(seat.Start());
			Console.WriteLine(tesla.ToString());

		}
	}
}