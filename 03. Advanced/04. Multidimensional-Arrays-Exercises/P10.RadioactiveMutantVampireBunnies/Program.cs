using System.Drawing;

namespace P10.RadioactiveMutantVampireBunnies
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
			char[,] field = new char[rows, cols];

			int currentCol = 0;
			int currentRow = 0;

			for (int i = 0; i < rows; i++)
			{
				string fieldRow = Console.ReadLine();

				for (int j = 0; j < cols; j++)
				{
					field[i, j] = fieldRow[j];

					if (field[i, j] == 'P')
					{
						currentRow = i;
						currentCol = j;
						field[currentRow,currentCol]= '.';
					}
				}
			}

			string moves = Console.ReadLine();
			bool isDead = false;
			foreach (char move in moves)
			{
				int lastPlaceRow = currentRow;
				int lastPlaceCol = currentCol;

				CalculateMove(move, ref currentCol, rows, cols, ref currentRow);
				if (ExpandBunny(field, rows, cols, ref isDead)) break;

				if (currentRow>=0 && currentRow<rows && currentCol>=0 && currentCol<cols && field[currentRow, currentCol] == 'B')
				{
					isDead = true;
					break;
				}

				if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
				{
					PrintField(rows, cols, field);
					Console.WriteLine($"won: {lastPlaceRow} {lastPlaceCol}");
					return;
				}
			}

			PrintField(rows, cols, field);

			if (isDead)
			{
				Console.WriteLine($"dead: {currentRow} {currentCol}");

			}
			else
			{
				Console.WriteLine($"won: {currentRow} {currentCol}");
			}

		}

		private static void PrintField(int rows, int cols, char[,] field)
		{
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Console.Write($"{field[r, c]}");
				}

				Console.WriteLine();
			}
		}

		static void CalculateMove(char move, ref int currentCol, int rows, int cols, ref int currentRow)
		{
			switch (move)
			{
				case 'L':
					currentCol--;
					break;
				case 'R':
					currentCol++;
					break;
				case 'U':
					currentRow--;
					break;
				case 'D':
					currentRow++;
					break;
			}
		}

		private static bool ExpandBunny(char[,] field, int rows, int cols, ref bool isDead)
		{
			List<int[]> positionsToExpandTo = new List<int[]>();
			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (field[row, col] == 'B')
					{
						if (col - 1 >= 0)
						{
							if (field[row, col - 1] == 'P')
							{
								isDead = true;
								return true;
							}

							positionsToExpandTo.Add(new [] { row, col - 1 });
						}

						if (col + 1 < cols)
						{
							if (field[row, col + 1] == 'P')
							{
								isDead = true;
								return true;
							}

							positionsToExpandTo.Add(new [] { row, col + 1 });
						}

						if (row - 1 >= 0)
						{
							if (field[row - 1, col] == 'P')
							{
								isDead = true;
								return true;
							}

							positionsToExpandTo.Add(new []{ row - 1, col });
						}

						if (row + 1 < rows)
						{
							if (field[row + 1, col] == 'P')
							{
								isDead = true;
								return true;
							}

							positionsToExpandTo.Add(new [] { row + 1, col });
						}
					}
				}
			}

			foreach (var position in positionsToExpandTo)
			{
				int row = position[0];
				int col = position[1];
				field[row, col] = 'B';
			}
			return false;
		}
	}
}
