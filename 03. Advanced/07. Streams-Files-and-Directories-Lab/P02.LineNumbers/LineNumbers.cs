namespace LineNumbers
{
	using System.IO;
	public class LineNumbers
	{
		static void Main()
		{
			string inputPath = @"..\..\..\Files\input.txt";
			string outputPath = @"..\..\..\Files\output.txt";

			RewriteFileWithLineNumbers(inputPath, outputPath);
		}

		public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
		{
			using (StreamReader sr = new StreamReader(inputFilePath))
			{
				using (StreamWriter sw = new StreamWriter(outputFilePath))
				{
					int lineNum = 1;
					string line = string.Empty;
					while ((line = sr.ReadLine()) != null)
					{
						Console.WriteLine($"{lineNum}. {line}");
						lineNum++;
					}
				}
			}
		}
	}
}