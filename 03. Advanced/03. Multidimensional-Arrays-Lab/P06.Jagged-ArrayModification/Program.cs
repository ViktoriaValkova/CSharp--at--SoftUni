namespace P06.Jagged_ArrayModification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int[][] arr = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				int[] currentRow = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();
				arr[i] = currentRow;
				
			}

			string input = string.Empty;
			while ((input = Console.ReadLine()) != "END")
			{
				string[] cmdArg = input.Split();
				string cmd = cmdArg[0];
				int rowValue = int.Parse(cmdArg[1]);
				int colValue = int.Parse(cmdArg[2]);
				int value  = int.Parse(cmdArg[3]);

				if (cmd == "Subtract")
				{
					value = -value;
				}

				if (rowValue >= 0 && rowValue <= rows - 1 && colValue >= 0 && colValue < arr[rowValue].Length)
				{
					arr[rowValue][colValue] += value;
				}
				else
				{
					Console.WriteLine("Invalid coordinates");
				}
			}

			for (int i = 0; i < rows; i++)
			{
				for (int c = 0; c < arr[i].Length; c++)
				{
					Console.Write(arr[i][c]);
					Console.Write(" ");
				}

				Console.WriteLine();
			}
               
		}
	}
}