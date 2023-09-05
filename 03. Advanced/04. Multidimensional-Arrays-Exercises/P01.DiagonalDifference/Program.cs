namespace P01.DiagonalDifference
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());

			int[,] matrix = new int[size,size];
			int sumPrimary = 0;
			int sumSecondary = 0;
			for (int r = 0; r < size; r++)
			{
				int[] currentRow = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();

				for (int c = 0; c < size; c++)
				{
					matrix[r,c] = currentRow[c];

					if (r == c)
					{
						sumPrimary += currentRow[c]; 
					}
					if (c == size - 1 - r)
					{
						sumSecondary+=currentRow[c];
					}
				}

			}

			Console.WriteLine(Math.Abs(sumPrimary-sumSecondary));
		}
	}
}