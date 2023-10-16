namespace P05.GenericCountMethodStrings
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			Box<string> box = new Box<string>();

			for (int i = 0; i < count; i++)
			{
				string item = Console.ReadLine();
				box.Add(item);
			}

			var element = Console.ReadLine();

			int result = box.Count(element);
			Console.WriteLine(result);
		}

		

	}
}