namespace P02.DeliveryBoy
{
	internal class Program
	{
		static bool isLost = false;
		static bool pizzaFound = false;
		static bool pizzaDelivered = false;
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			(int rows, int cols) = (dimensions[0], dimensions[1]);

			int[,] matrix = new int[rows, cols];
			int[] startingPosition = new int[2];
			for (int i = 0; i < rows; i++)
			{
				string row = Console.ReadLine();

				for (int j = 0; j < row.Length; j++)
				{
					matrix[i, j] = row[j];
					if (row[j] == 'B')
					{
						startingPosition[0] = i;
						startingPosition[1] = j;
					}
				}

			}

			string direction = string.Empty;
			int currentRow = startingPosition[0];
			int currentCol = startingPosition[1];
			while (!isLost&& !pizzaDelivered)
			{
				direction = Console.ReadLine();
				MakeAMove(matrix, ref currentRow, ref currentCol, direction);
			}

			if (isLost)
			{
				matrix[startingPosition[0], startingPosition[1]] = ' ';
			}
			else
			{
				matrix[startingPosition[0], startingPosition[1]] = 'B';
			}


			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{(char)matrix[i, j]}");
				}

				Console.WriteLine();
			}

		}

		private static void MakeAMove(int[,] matrix, ref int currentRow, ref int currentCol, string direction)
		{
			int tempRow = currentRow;
			int tempCol = currentCol;
			switch (direction)
			{
				case "down":
					currentRow += 1;
					break;
				case "right":
					currentCol += 1;
					break;
				case "left":
					currentCol -= 1;
					break;
				case "up":
					currentRow -= 1;
					break;
			}

			if (!EvaluateMove(ref currentCol, ref currentRow, matrix))
			{
				currentCol = tempCol;
				currentRow = tempRow;
			}

		}

		private static bool EvaluateMove(ref int currentCol, ref int currentRow, int[,] matrix)
		{
			if (currentCol < 0 || currentCol >= matrix.GetLength(1) || currentRow < 0 ||
				currentRow >= matrix.GetLength(0))
			{
				Console.WriteLine("The delivery is late. Order is canceled.");
				isLost = true;
			}
			else if (matrix[currentRow, currentCol] == 'A')
			{
				if (pizzaFound)
				{
					Console.WriteLine("Pizza is delivered on time! Next order...");
					matrix[currentRow, currentCol] = 'P';
					pizzaDelivered = true;
				}

			}
			else if (matrix[currentRow, currentCol] == '-')
			{
				matrix[currentRow, currentCol] = '.';
			}
			else if (matrix[currentRow, currentCol] == 'P')

			{
				matrix[currentRow, currentCol] = 'R';
				pizzaFound = true;
				Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
			}
			else if (matrix[currentRow, currentCol] == '*')
			{
				return false;
			}

			return true; ;
		}
	}
}