namespace P02.SumMatrixColumns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] parameters = Console.ReadLine()
				.Split(", ")
				.Select(int.Parse)
				.ToArray();

			int rows = parameters[0];
			int cols = parameters[1];
			int sum = 0;
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

			int[] columnsSum = new int[cols];
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					columnsSum[c] +=matrix[r, c];
				}
			}
			Console.WriteLine(string.Join("\n",columnsSum));
		}
	}
}