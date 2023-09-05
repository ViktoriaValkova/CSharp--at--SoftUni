namespace P06.JaggedArrayManipulator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());

			int[][] jagged = new int[rows][];

			for (int r = 0; r < rows; r++)
			{
				int[] currentRow = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();

				jagged[r] = currentRow;

				for (int c = 0; c < currentRow.Length; c++)
				{
					jagged[r][c] = currentRow[c];
				}
			}

			MultiplyOrDivideElements(rows, jagged);

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "End")
			{
				string[] cmdArg = input.Split();

				string command = cmdArg[0];
				int rowValue = int.Parse(cmdArg[1]);
				int colValue = int.Parse(cmdArg[2]);
				int value = int.Parse(cmdArg[3]);

				if (command == "Subtract")
				{
					value = -value;
				}

				if (rowValue < 0 || rowValue >= jagged.Length || colValue < 0 || colValue >= jagged[rowValue].Length)
				{
					continue;
				}

				jagged[rowValue][colValue] += value; 
			}

			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine(string.Join(' ', jagged[i]));
			}
               

		}

		private static void MultiplyOrDivideElements(int rows, int[][] jagged)
		{
			for (int r = 0; r < rows - 1; r++)
			{
				if (jagged[r].Length == jagged[r + 1].Length)
				{
					for (int i = 0; i < jagged[r].Length; i++)
					{
						jagged[r][i] *= 2;
						jagged[r + 1][i] *= 2;
					}
				}
				else
				{
					for (int i = 0; i < jagged[r].Length; i++)
					{
						jagged[r][i] /= 2;
					}
					for (int i = 0; i < jagged[r+1].Length; i++)
					{
						jagged[r + 1][i] /= 2;
					}
				}
			}
		}
	}
}