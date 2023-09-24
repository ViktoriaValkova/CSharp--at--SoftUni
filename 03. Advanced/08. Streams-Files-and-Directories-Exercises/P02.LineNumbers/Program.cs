using System.Diagnostics.Metrics;
using System.Text;

namespace LineNumbers
{
	using System;

	public class LineNumbers
	{
		static void Main()
		{
			string inputFilePath = @"..\..\..\text.txt";
			string outputFilePath = @"..\..\..\output.txt";

			ProcessLines(inputFilePath, outputFilePath);
		}

		public static void ProcessLines(string inputFilePath, string outputFilePath)
		{
			string[] text = File.ReadAllLines(inputFilePath);
			StringBuilder sb = new();

			for (int i = 0; i < text.Length; i++)
			{

				int letterCount = text[i].Count(ch => char.IsLetter(ch));
				int punctCount = text[i].Count(ch => char.IsPunctuation(ch));
				sb.AppendLine($"Line {i + 1}: {text[i]} ({letterCount}) ({punctCount})");
			}
			File.WriteAllText(outputFilePath, sb.ToString());
		}
	}
}
