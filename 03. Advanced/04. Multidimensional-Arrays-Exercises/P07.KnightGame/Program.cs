using System.Numerics;

namespace P07.KnightGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int boardSize = int.Parse(Console.ReadLine());

			char[,] board = new char[boardSize, boardSize];

			for (int r = 0; r < boardSize; r++)
			{
				string currentRow = Console.ReadLine();

				for (int c = 0; c < boardSize; c++)
				{
					board[r, c] = currentRow[c];
				}
			}

			if (boardSize <= 2)
			{
				Console.WriteLine(0);
				return;
			}

			int knogthsCnt = 0;
			while (true)
			{

				int bestCount = 0;
				int bestRow = 0;
				int bestCol = 0;
				for (int r = 0; r < boardSize; r++)
				{
					for (int c = 0; c < boardSize; c++)
					{
						if (board[r, c] == 'K')
						{
				int countToRemove = 0;

							if (r + 2 < boardSize && c - 1 >= 0)
							{
								if (board[r + 2, c - 1] == 'K')
								{
									countToRemove++;
								}
							}
							if (r + 2 < boardSize && c + 1 < boardSize)
							{
								if (board[r + 2, c + 1] == 'K')
								{
									countToRemove++;
								}
							}
							if (r - 2 >= 0 && c - 1 >= 0)
							{
								if (board[r - 2, c - 1] == 'K')
								{
									countToRemove++;
								}
							}
							if (r - 2 >= 0 && c + 1 < boardSize)
							{
								if (board[r - 2, c + 1] == 'K')
								{
									countToRemove++;
								}
							}
							if (r + 1 < boardSize && c + 2 < boardSize)
							{
								if (board[r + 1, c + 2] == 'K')
								{
									countToRemove++;
								}
							}
							if (r + 1 < boardSize && c - 2 >= 0)
							{
								if (board[r + 1, c - 2] == 'K')
								{
									countToRemove++;
								}
							}
							if (r - 1 >= 0 && c - 2 >= 0)
							{
								if (board[r - 1, c - 2] == 'K')
								{
									countToRemove++;
								}
							}
							if (r - 1 >= 0 && c + 2 < boardSize)
							{
								if (board[r - 1, c + 2] == 'K')
								{
									countToRemove++;
								}
							}

							if (bestCount < countToRemove)
							{
								bestCount = countToRemove;
								bestCol = c;
								bestRow = r;
							}

						}
					}
				}

				if (bestCount == 0)
				{
					break;
				}
				else
				{
					board[bestRow, bestCol] = '0';
					knogthsCnt++;
				}
			}

			Console.WriteLine(knogthsCnt);
		}
	}
}