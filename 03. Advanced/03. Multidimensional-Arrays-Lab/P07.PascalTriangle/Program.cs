namespace P07.PascalTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());

			int[][] triangle = new int[rows][];
			for (int r = 0; r < rows; r++)
			{
				triangle[r] = new int[r+1];
				triangle[r][0] = 1;
				triangle[r][r] = 1;
				for (int c = 1; c < r; c++)
				{
					triangle[r][c] = triangle[r - 1][c - 1] + triangle[r - 1][c];
				}
			}

			foreach (int[] row in triangle)
			{
				Console.WriteLine(string.Join(' ', row));
			}
               
		}
	}
}