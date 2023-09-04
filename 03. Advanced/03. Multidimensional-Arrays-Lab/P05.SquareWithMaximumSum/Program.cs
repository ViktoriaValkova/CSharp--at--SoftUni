using System.Data;

namespace P05.SquareWithMaximumSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine()
				.Split(", ")
				.Select(int.Parse)
				.ToArray();

			(int rows, int cols) = (arr[0], arr[1]);
			int[,] matrix = new int[rows, cols];
			for (int r = 0; r < rows; r++)
			{
				int[] currentRow = Console.ReadLine()
					.Split(", ")
					.Select(int.Parse)
					.ToArray();

				for (int c = 0; c < cols; c++)
				{
					matrix[r, c] = currentRow[c];
				}
			}

			int maxSum = int.MinValue;
			int[] bestSquare = new int[4];
			for (int r = 0; r < rows - 1; r++)
			{
				for (int c = 0; c < cols - 1; c++)
				{
					int currentSum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];
					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						bestSquare[0] = matrix[r, c];
						bestSquare[1] = matrix[r, c + 1];
						bestSquare[2] = matrix[r + 1, c];
						bestSquare[3] = matrix[r + 1, c + 1];
					}
				}
			}

			Console.WriteLine($"{bestSquare[0]} {bestSquare[1]}");
			Console.WriteLine($"{bestSquare[2]} {bestSquare[3]}");
			Console.WriteLine(maxSum);
		}
	}
}