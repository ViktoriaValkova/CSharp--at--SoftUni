namespace P06.GenericCountMethodDoubles
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			Box<double> box = new Box<double>();

			for (int i = 0; i < count; i++)
			{
				double item = double.Parse(Console.ReadLine());
				box.Add(item);
			}

			double element = double.Parse(Console.ReadLine());

			int result = box.Count(element);
			Console.WriteLine(result);
		}

		

	}
}