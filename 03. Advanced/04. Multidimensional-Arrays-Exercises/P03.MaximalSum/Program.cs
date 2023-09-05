namespace P03.MaximalSum
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

			for (int r = 0; r < rows; r++)
			{
				int[] currentRow = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();
				for (int c = 0; c < cols; c++)
				{
					matrix[r,c] = currentRow[c];
				}
			}

			int bestSum = int.MinValue;
			int bestRow = 0;
			int bestCol = 0;

			for (int r = 0; r < rows-2; r++)
			{
				for (int c = 0; c < cols-2; c++)
				{
					int currentSum= matrix[r,c]+ matrix[r, c+1]+ matrix[r, c+2]
					                + matrix[r+1, c]+ matrix[r+1, c+1]+ matrix[r+1, c+2]
					                + matrix[r+2, c]+ matrix[r+2, c+1]+ matrix[r + 2, c+2];

					if (currentSum > bestSum)
					{
						bestSum=currentSum;
						bestRow=r;
						bestCol=c;
					}
				}
			}

			Console.WriteLine($"Sum: {bestSum}");
			for (int i = bestRow; i < bestRow+3; i++)
			{
				for (int j = bestCol; j < bestCol+3; j++)
				{
					Console.Write($"{matrix[i,j]}");
					Console.Write(" ");
				}

				Console.WriteLine();
               
			}
               
		}
	}
}