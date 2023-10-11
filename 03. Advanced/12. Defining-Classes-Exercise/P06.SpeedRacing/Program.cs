namespace CarCollection
{
	public class Program
	{
		static	List<Car> cars = new List<Car>();
		static void Main(string[] args)
		{

			getCars();

			string input;

			while ((input = Console.ReadLine()) != "End")
			{
				string[] driveInfo = input.Split(); 

				string model = driveInfo[1];
				double km = double.Parse(driveInfo[2]);

				var thisCar = cars.Where(c=> c.Model == model).FirstOrDefault();
				thisCar.Drive(km);
			}
			Console.WriteLine(string.Join(Environment.NewLine, cars));
		}

		private static void getCars()
		{
			int count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				string[] info = Console.ReadLine().Split();
				Car car = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));

				cars.Add(car);
			}
		}
	}
}