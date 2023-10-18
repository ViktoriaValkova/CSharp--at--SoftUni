namespace P02.Collection;
internal class Program
{
	static void Main(string[] args)
	{
		string[] startInput = Console.ReadLine().Split(" ").ToArray();
		ListyIterator<string> listy = new ListyIterator<string>();
		if (startInput.Length > 1)
		{
			string[] elements = startInput[1..];
			listy.List.AddRange(elements);
		}

		string input = string.Empty;

		while ((input = Console.ReadLine()) != "END")
		{
			switch (input)
			{
				case "HasNext":
					Console.WriteLine(listy.HasNext());
					break;
				case "Move":
					Console.WriteLine(listy.Move());
					break;
				case "Print":
					try
					{
					listy.Print();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
					break;
				case "PrintAll":
					listy.PrintAll();
					break;
			}
		}
	}
}