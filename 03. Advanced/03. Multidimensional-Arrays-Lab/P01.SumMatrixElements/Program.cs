namespace P01.SumMatrixElements
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

			int[,] matrix = new int[rows, cols];
			int sum = 0; 
			for (int r = 0; r < rows; r++)
			{
				int[] currentRow = Console.ReadLine()
					.Split(", ")
					.Select(int.Parse)
					.ToArray();

				for (int c = 0; c < cols; c++)
				{
					matrix[r,c] = currentRow[c];
				}

				sum += currentRow.Sum();
			}

			Console.WriteLine(rows);
			Console.WriteLine(cols);
			Console.WriteLine(sum);
		}
	}
}