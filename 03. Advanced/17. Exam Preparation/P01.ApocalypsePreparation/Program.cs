namespace P01.ApocalypsePreparation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> textiles = new Queue<int>(Console.ReadLine().Split(" ").Select(x => int.Parse(x)));
			Stack<int> meds = new Stack<int>(Console.ReadLine().Split(" ").Select(x => int.Parse(x)));
			Dictionary<string, int> items = new Dictionary<string, int>();
			while (textiles.Count > 0 && meds.Count > 0)
			{
				int currTextile = textiles.Dequeue();
				int currentMed = meds.Pop();

				if (currTextile + currentMed == 30)
				{
					if (!items.ContainsKey("Patch"))
					{
						items["Patch"] = 0;
					}

					items["Patch"]++;
				}
				else if (currTextile + currentMed == 40)
				{
					if (!items.ContainsKey("Bandage"))
					{
						items["Bandage"] = 0;
					}

					items["Bandage"]++;
				}
				else if (currTextile + currentMed == 100)
				{
					if (!items.ContainsKey("MedKit"))
					{
						items["MedKit"] = 0;
					}

					items["MedKit"]++;
				}
				else if (currTextile + currentMed > 100)
				{
					if (!items.ContainsKey("MedKit"))
					{
						items["MedKit"] = 0;
					}

					items["MedKit"]++;
					int nextItem = meds.Pop();
					nextItem += currTextile + currentMed - 100;
					meds.Push(nextItem);
				}
				else
				{
					currentMed += 10;
					meds.Push(currentMed);
				}
			}

			if (textiles.Count == 0 && meds.Count == 0)
			{
				Console.WriteLine("Textiles and medicaments are both empty.");
			}
			else if (meds.Count == 0)
			{
				Console.WriteLine("Medicaments are empty.");
			}
			else
			{
				Console.WriteLine("Textiles are empty.");
			}


			var sortedDict = items.OrderByDescending(i => i.Value).ThenBy(i => i.Key);

			foreach (var item in sortedDict)
			{
				Console.WriteLine($"{item.Key} - {item.Value}");
			}

			if (meds.Count > 0)
			{
				Console.WriteLine($"Medicaments left: {string.Join(", ", meds)}");
			}

			if (textiles.Count > 0)
			{
				Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
			}
	}
	}
}