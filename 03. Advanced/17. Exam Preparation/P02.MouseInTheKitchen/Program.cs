using System.Numerics;

namespace P02.MouseInTheKitchen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split(",", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			(int rows, int cols) = (dimensions[0], dimensions[1]);
			int[,] matrix = new int[rows, cols];
			int[] startingPosition = new int[2];
			int cheeseCount = 0;
			for (int i = 0; i < rows; i++)
			{
				string row = Console.ReadLine();

				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = row[j];

					if (row[j] == 'M')
					{
						startingPosition[0] = i;
						startingPosition[1] = j;
						matrix[i, j] = '*';
					}

					if (row[j] == 'C')
					{
						cheeseCount++;
					}
				}
			}

			string input = string.Empty;
			int currentRow = startingPosition[0];
			int currentCol = startingPosition[1];

			bool isOutside = false;
			bool isTrapped = false;
			bool metWall = false;
			while ((input = Console.ReadLine()) != "danger")
			{
				int tempRow = currentRow;
				int tempCol = currentCol;
				switch (input)
				{
					case "up":
						currentRow--;
						break;
					case "down":
						currentRow++;
						break;
					case "left":
						currentCol--;
						break;
					case "right":
						currentCol++;
						break;
				}

				if (!ValidateRowColValue(currentRow, currentCol, rows, cols))
				{
					currentRow = tempRow;
					currentCol = tempCol;
					isOutside = true;
					break;
				}

				EvaluateMove(currentRow, currentCol, matrix, ref cheeseCount, ref isTrapped, ref metWall);
				if (cheeseCount == 0)
				{
					break;
				}

				if (metWall)
				{
					currentRow = tempRow;
					currentCol = tempCol;
					metWall = false;
				}

				if (isTrapped)
				{
					break;
				}
			}

			matrix[currentRow, currentCol] = 'M';
			if (isTrapped)
			{
				Console.WriteLine("Mouse is trapped!");
			}
			else if (isOutside)
			{
				Console.WriteLine("No more cheese for tonight!");
			}
			else if (cheeseCount == 0)
			{
				Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");

			}
			else if (cheeseCount > 0)
			{
				Console.WriteLine("Mouse will come back later!");
			}




			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write((char)matrix[i, j]);
				}

				Console.WriteLine();
			}
		}

		static void EvaluateMove(int currentRow, int currentCol, int[,] matrix, ref int cheeseCount, ref bool isTrapped, ref bool metWall)
		{
			switch (matrix[currentRow, currentCol])
			{
				case 'C':
					matrix[currentRow, currentCol] = '*';
					cheeseCount--;
					break;
				case '@':
					metWall = true;
					break;
				case 'T':
					isTrapped = true;
					break;

			}
		}

		static bool ValidateRowColValue(int currentRow, int currentCol, int rows, int cols)
		{
			return currentRow >= 0 && currentCol >= 0 && currentCol < cols && currentRow < rows;
		}
	}
}