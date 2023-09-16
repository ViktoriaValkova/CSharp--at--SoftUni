namespace MergeFiles
{
	using System;
	using System.IO;
	public class MergeFiles
	{
		static void Main()
		{
			var firstInputFilePath = @"..\..\..\Files\input1.txt";
			var secondInputFilePath = @"..\..\..\Files\input2.txt";
			var outputFilePath = @"..\..\..\Files\output.txt";

			MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
		}

		public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
		{
			using (StreamReader fileOne = new StreamReader(firstInputFilePath))
			{
				using (StreamReader fileTwo = new StreamReader(secondInputFilePath))
				{
					using (StreamWriter output = new StreamWriter(outputFilePath))
					{
						string firstLine = string.Empty;
						string secondLine = string.Empty;

						while (true)
						{
							if ((firstLine = fileOne.ReadLine()) != null)
							{
								output.WriteLine(firstLine);
							}

							if ((secondLine = fileTwo.ReadLine()) != null)
							{
								output.WriteLine(secondLine);
							}
							if (firstLine == null && secondLine == null)
							{
								break;
							}
						}


					}
				}
			}
		}
	}
}