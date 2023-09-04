namespace P03.PrimaryDiagonal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[,] matrix = new int[size, size];
			int sum = 0;
			for (int r = 0; r < size; r++)
			{
				int[] currentRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
				for (int c = 0; c < size; c++)
				{
					matrix[r,c] = currentRow[c];

					if (r == c)
					{
						sum += currentRow[c];
					}
				}
			}
			Console.WriteLine(sum);
		}
	}
}