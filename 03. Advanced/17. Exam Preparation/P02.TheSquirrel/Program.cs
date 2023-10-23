namespace P02.TheSquirrel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int length = int.Parse(Console.ReadLine());
			string[] moves = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

			char[,] field = new char[length,length];
			int squirelRow = 0;
			int squirelCol = 0;
			int hazelnutCount = 0;
			for (int i = 0; i < length; i++)
			{
				string currentRow  = Console.ReadLine();

				for (int j = 0; j < currentRow.Length; j++)
				{
					field[i,j] = currentRow[j];
					if (currentRow[j] == 's')
					{
						squirelRow = i;
						squirelCol = j;
					}
				}
			}

			bool steppedOnTrap = false;
			bool outOfField = false;
			foreach (string move in moves)
			{
				switch (move)
				{
					case "left":
						squirelCol--;
						break;
					case "right":
						squirelCol++;
						break;
					case "up":
						squirelRow--;
						break;
					case "down":
						squirelRow++;
						break; 
				}

				if (!isValidPosition(squirelRow, squirelCol, length))
				{
					Console.WriteLine("The squirrel is out of the field.");
					outOfField = true;
					break;
				}

				if (field[squirelRow, squirelCol] == 'h')
				{
					hazelnutCount++;
					field[squirelRow, squirelCol] = '*';
					if (hazelnutCount == 3)
					{
						Console.WriteLine("Good job! You have collected all hazelnuts!");
						break;
					}
				}

				else if (field[squirelRow, squirelCol] == 't')
				{
					Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
					steppedOnTrap = true;
					break;
				}
			}

			if (hazelnutCount < 3 && !steppedOnTrap && !outOfField)
			{
				Console.WriteLine("There are more hazelnuts to collect.");
			}

			Console.WriteLine($"Hazelnuts collected: {hazelnutCount}");
		}

		 public static bool isValidPosition(int row, int col, int length)
		{
			if (row<0 || col<0 || row >=length || col >=length) return false;
			return true;
		}

		 
	}
}