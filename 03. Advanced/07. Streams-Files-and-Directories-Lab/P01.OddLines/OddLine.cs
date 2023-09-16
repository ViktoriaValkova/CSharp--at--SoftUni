namespace OddLines
{
	public class OddLines
	{
		static void Main()
		{
			string inputFilePath = @"..\..\..\Files\input.txt";
			string outputFilePath = @"..\..\..\Files\output.txt";

			ExtractOddLines(inputFilePath, outputFilePath);
		}

		public static void ExtractOddLines(string inputFilePath, string outputFilePath)
		{
			using (StreamReader text = new StreamReader(inputFilePath))
			{
				using (StreamWriter outputText = new StreamWriter(outputFilePath))
				{
					int lineCnt = 0;
					string line = string.Empty;
					while ((line = text.ReadLine()) != null)
					{
						if (lineCnt % 2 == 1)
						{
							outputText.WriteLine(line);
						}
						lineCnt++;

					}
				}
			}
		}
	}
}