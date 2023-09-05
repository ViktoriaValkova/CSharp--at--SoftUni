namespace P04.MatrixShuffling
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
			string[,] matrix = new string[rows, cols];

			for (int r = 0; r < rows; r ++)
			{
				string[] currentRow = Console.ReadLine()
					.Split()
					.ToArray();

				for (int c = 0; c < cols; c++)
				{
					matrix[r,c] = currentRow[c];
				}
			}

			string cmd = string.Empty;

			while ((cmd = Console.ReadLine()) != "END")
			{
				string[] cmdArg = cmd.Split();

				if (cmdArg.Length != 5 || !cmdArg.Contains("swap"))
				{
					Console.WriteLine("Invalid input!");
					continue;
				}

				int rowOne = int.Parse(cmdArg[1]);
				int colOne = int.Parse(cmdArg[2]);
				int rowTwo = int.Parse(cmdArg[3]);
				int colTwo = int.Parse(cmdArg[4]);

				if (rowOne<0  || rowOne>rows || rowTwo<0 || rowTwo>rows
					|| colOne<0 || colOne>cols || colTwo<0 || colTwo> cols)
				{
					Console.WriteLine("Invalid input!");
					continue;
				}

				string temp = matrix[rowOne,colOne];
				matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
				matrix[rowTwo, colTwo] = temp;

				for (int r = 0; r < rows; r++)
				{
					for (int c = 0; c < cols; c++)
					{
						Console.Write($"{matrix[r,c]} ");
					}

					Console.WriteLine();
				}
			}

		}
	}
}