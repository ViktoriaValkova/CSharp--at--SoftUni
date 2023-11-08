namespace P01.ClassBoxData
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			try
			{
				Box box = new Box(length, width, height);
				double volume = width * height * length;
				double surface = 2 * (height * width + width * length + height * length);
				double lateral = 2 * height * (length + width);
				Console.WriteLine($"Surface Area - {surface:f2}");
				Console.WriteLine($"Lateral Surface Area - {lateral:f2}");
				Console.WriteLine($"Volume - {volume:f2}");
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}