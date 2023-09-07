using System.Numerics;

namespace P09.Miner
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			string[] moves = Console.ReadLine().Split();

			string[,] field = new string[size, size];

			int startRow = 0, startCol = 0;
			int totalCoals = 0;

			for (int i = 0; i < size; i++)
			{
				string [] fieldRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

				for (int j = 0; j < size; j++)
				{
					field[i, j] = fieldRow[j];

					if (field[i, j] == "s")
					{
						startRow = i;
						startCol = j;
					}
					else if (fieldRow[j] == "c")
					{
						totalCoals++;
					}
				}
			}

			int coalCnt = 0;
			int currentRow = startRow;
			int currentCol = startCol;

			foreach (string move in moves)
			{
				CalculateMove(move, ref currentCol, size, ref currentRow);

				if (EvaluateNewPosition(field, currentRow, currentCol, ref coalCnt, ref totalCoals)) return;

				if (totalCoals == 0)
				{
					Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
					return;
				}
			}

			Console.WriteLine($"{totalCoals} coals left. ({currentRow}, {currentCol})");
		}

		static bool EvaluateNewPosition(string[,] field, int currentRow, int currentCol, ref int coalCnt,
		   ref int totalCoals)
		{
			switch (field[currentRow, currentCol])
			{
				case "e":
					Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
					return true;
				case "c":
					coalCnt++;
					totalCoals--;
					field[currentRow, currentCol] = "*";
					break;
			}

			return false;
		}

		static void CalculateMove(string move, ref int currentCol, int size, ref int currentRow)
		{
			switch (move)
			{
				case "left":
					if (currentCol - 1 >= 0)
					{
						currentCol--;
					}

					break;
				case "right":
					if (currentCol + 1 < size)
					{
						currentCol++;
					}

					break;
				case "up":
					if (currentRow - 1 >= 0)
					{
						currentRow--;
					}

					break;
				case "down":
					if (currentRow + 1 < size)
					{
						currentRow++;
					}

					break;
			}
		}
	}
}