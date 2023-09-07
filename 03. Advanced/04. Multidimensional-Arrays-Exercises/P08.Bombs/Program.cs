using System.Numerics;

namespace P08.Bombs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());

			int[,] matrix = new int[size, size];

			for (int r = 0; r < size; r++)
			{
				int[] line = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int c = 0; c < size; c++)
				{
					matrix[r, c] = line[c];
				}
			}

			string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

			foreach (string bomb in bombs)
			{
				int[] currentBomb = bomb.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				ReduceValue(matrix, currentBomb, size);

			}

			int countAlive = 0;
			int sumALive = 0;
			foreach (int num in matrix)
			{
				if (num > 0)
				{
					countAlive++;
					sumALive += num;
				}
			}

			Console.WriteLine($"Alive cells: {countAlive}");
			Console.WriteLine($"Sum: {sumALive}");


			for (int r = 0; r < size; r++)
			{
				for (int c = 0; c < size; c++)
				{
					Console.Write($"{matrix[r, c]} ");
				}

				Console.WriteLine();
			}
		}

		static void ReduceValue(int[,] matrix, int[] currentBomb, int size)
		{
			int currentRow = currentBomb[0];
			int currentCol = currentBomb[1];

			int currentBombValue = matrix[currentRow, currentCol];
			if (matrix[currentRow, currentCol] <= 0)
			{
				return;
			}
			if (currentRow - 1 >= 0 && currentCol - 1 >= 0)
			{
				if (matrix[currentRow - 1, currentCol - 1] > 0)
				{
					matrix[currentRow - 1, currentCol - 1] -= currentBombValue;
				}
			}
			if (currentCol - 1 >= 0)
			{
				if (matrix[currentRow, currentCol - 1] > 0)
				{
					matrix[currentRow, currentCol - 1] -= currentBombValue;
				}
			}
			if (currentRow + 1 < size && currentCol - 1 >= 0)
			{
				if (matrix[currentRow + 1, currentCol - 1] > 0)
				{
					matrix[currentRow + 1, currentCol - 1] -= currentBombValue;
				}
			}
			if (currentRow + 1 < size)
			{
				if (matrix[currentRow + 1, currentCol] > 0)
				{
					matrix[currentRow + 1, currentCol] -= currentBombValue;
				}
			}
			if (currentRow + 1 < size && currentCol + 1 < size)
			{
				if (matrix[currentRow + 1, currentCol + 1] > 0)
				{
					matrix[currentRow + 1, currentCol + 1] -= currentBombValue;
				}
			}
			if (currentCol + 1 < size)
			{
				if (matrix[currentRow, currentCol + 1] > 0)
				{
					matrix[currentRow, currentCol + 1] -= currentBombValue;
				}
			}
			if (currentRow - 1 >= 0 && currentCol + 1 < size)
			{
				if (matrix[currentRow - 1, currentCol + 1] > 0)
				{
					matrix[currentRow - 1, currentCol + 1] -= currentBombValue;
				}
			}
			if (currentRow - 1 >= 0)
			{
				if (matrix[currentRow - 1, currentCol] > 0)
				{
					matrix[currentRow - 1, currentCol] -= currentBombValue;
				}
			}

			matrix[currentRow, currentCol] = 0;

		}
	}
}