using System.Text;
using System.Xml.Schema;

namespace WordCount
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	public class WordCount
	{
		static void Main()
		{
			string wordPath = @"..\..\..\Files\words.txt";
			string textPath = @"..\..\..\Files\text.txt";
			string outputPath = @"..\..\..\Files\output.txt";

			CalculateWordCounts(wordPath, textPath, outputPath);
		}

		public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
		{
			using (StreamReader text = new StreamReader(textFilePath, Encoding.UTF8))
			{
				using (StreamReader words = new StreamReader(wordsFilePath))
				{
					using (StreamWriter output = new StreamWriter(outputFilePath))
					{
						Dictionary<string, int> wordsByCount = new Dictionary<string, int>();
						string lineFromText = string.Empty;
						string[] wordsSep = words.ReadToEnd().Split(' ');

						while ((lineFromText = text.ReadLine()) != null)
						{
							foreach (var word in wordsSep)
							{
								if (lineFromText.ToLower().Contains(word))
								{
									if (!wordsByCount.ContainsKey(word))
									{
										wordsByCount[word] = 0;
									}

									wordsByCount[word]++;
								}
							}
						}

						foreach (var kvp in wordsByCount.OrderByDescending(x => x.Value))
						{
							output.WriteLine($"{kvp.Key} - {kvp.Value}");
						}
					}
				}
			}
		}
	}
}