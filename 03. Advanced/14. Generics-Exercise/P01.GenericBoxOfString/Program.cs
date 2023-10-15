namespace P01.GenericBoxOfString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count= int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				var item = Console.ReadLine();
				var currentBox = new Box<string>(item);
				Console.WriteLine(currentBox.ToString());
			}
               
		}
	}
}