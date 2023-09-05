namespace P05.SnakeMoves
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			(int rows, int cols) = (dimensions[0], dimensions[1]);

			int[,] matrix = new int[rows, cols];

			string snake = Console.ReadLine();
			string current = snake;

			for (int r = 0; r < rows; r++)
			{
				if (r % 2 == 0)
				{
					for (int c= 0; c < cols; c++)
					{
						matrix[r, c] = current[0];
						current = current.Remove(0, 1);
						if (current.Length <= c)
						{
							current += snake;
						}
					}
                continue;
				}

				for (int c=cols-1; c >= 0; c--)
				{
					matrix[r, c] = current[0];
					current = current.Remove(0, 1);
					if (current.Length <=c)
					{
						current += snake;
					}
				}

			}

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Console.Write((char)matrix[r,c]);
				}

				Console.WriteLine();
               
			}
               
		}

	}
}
