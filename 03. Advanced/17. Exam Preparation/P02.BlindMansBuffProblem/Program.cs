namespace P02.BlindMansBuffProblem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();

			(int rows, int cols) = (dimensions[0], dimensions[1]);

			string[,] field = new string[rows, cols];
			int currentRow =0, currentCol=0;
			int peopleCount = 0;
			for (int i = 0; i < rows; i++)
			{
				string[] currentLine = Console.ReadLine().Split(" ").ToArray();

				for (int j = 0; j < cols; j++)
				{
					field[i,j] = currentLine[j];

					if (currentLine[j] == "B")
					{
						currentCol = j;
						currentRow = i;
					}
					else if (currentLine[j] == "P")
					{
						peopleCount++;
					}
				}
			}

			string input = string.Empty;
			int movesCount = 0;
			int touchedOponents = 0;
			while ((input = Console.ReadLine()) != "Finish")
			{
				int tempRow = currentRow;
				int tempCol = currentCol;
				switch (input)
				{
					case "up":
						currentRow--; break;
					case "down":
						currentRow++; break;
					case "right":
						currentCol++;
						break;
					case "left":
						currentCol--;
						break;
				}

				if (!isValid(currentRow, currentCol, field))
				{
					currentRow = tempRow;
					currentCol = tempCol;
					continue;
				}

				switch (field[currentRow,currentCol])
				{
					case "O":
						currentRow = tempRow;
						currentCol = tempCol;
						continue;
					case "P":
						touchedOponents++;
						field[currentRow, currentCol] = "-";
						break;
				}

				movesCount++;

				if (touchedOponents == peopleCount)
				{
					break;
				}
			}

			Console.WriteLine("Game over!");
			Console.WriteLine($"Touched opponents: {touchedOponents} Moves made: {movesCount}");
		}

		 static bool isValid(int currentRow, int currentCol, string[,] field)
		{
			if (currentCol < 0 || currentCol >= field.GetLength(0) || currentRow < 0 || currentRow >= field.GetLength(1))
			{
				return false;
			}

			return true;
		}
	}
}