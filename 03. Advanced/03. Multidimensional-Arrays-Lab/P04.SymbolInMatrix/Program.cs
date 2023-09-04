namespace P04.SymbolInMatrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			char[,] matrix = new char[count,count]; 
			for (int i = 0; i < count; i++)
			{
				string input = Console.ReadLine();
				for (int j = 0; j < input.Length; j++)
				{
					matrix[i,j] = input[j];
				}
			}

			char symbol = char.Parse(Console.ReadLine());

			for (int r = 0; r < count; r++)
			{
				for (int c = 0; c < count; c++)
				{
					if (matrix[r, c] == symbol)
					{
						Console.WriteLine($"({r}, {c})");
						return;
					}
				}
			}

			Console.WriteLine($"{symbol} does not occur in the matrix");
		}
	}
}