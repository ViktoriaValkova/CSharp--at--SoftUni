﻿using System.Text;

namespace P06.SongsQueue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] songs = Console.ReadLine().Split(", ").ToArray();

			Queue<string> queue = new Queue<string>(songs);

			while (queue.Count > 0)
			{
				string[] cmdArg = Console.ReadLine().Split().ToArray();

				switch (cmdArg[0])
				{
					case "Play":
						queue.Dequeue();
						break;
					case "Add":
						string newSong = string.Join(' ', cmdArg.Skip(1));
					//	newSong = string.Join(' ', cmdArg[1..]);
						if (!queue.Contains(newSong))
						{
							queue.Enqueue(newSong);
						}
						else
						{
							Console.WriteLine($"{newSong} is already contained!");
						}
							break;
					case "Show":
						Console.WriteLine(string.Join(", ", queue));
						break;
				}
			}

			if (queue.Count == 0)
			{
				Console.WriteLine("No more songs!");
			}
		}
	}
}