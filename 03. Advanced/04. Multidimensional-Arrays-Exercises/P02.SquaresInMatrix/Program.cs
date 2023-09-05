namespace P02.SquaresInMatrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			(int rows, int cols) = (dimensions[0], dimensions[1]);
			string[,] matrix = new string[rows, cols];

			for (int r = 0; r < rows; r++)
			{
				string[] currentRows = Console.ReadLine()
					.Split()
					.ToArray();
				for (int c = 0; c < cols; c++)
				{
					matrix[r, c] = currentRows[c];
				}
			}

			int sqCnt = 0;

			for (int r = 0; r < rows - 1; r++)
			{
				for (int c = 0; c < cols - 1; c++)
				{
					if (matrix[r, c] == matrix[r + 1, c] && matrix[r, c] == matrix[r, c + 1] &&
						matrix[r, c] == matrix[r + 1, c + 1])
					{
						sqCnt++;
					}
				}
			}

			Console.WriteLine(sqCnt);
		}
	}
}