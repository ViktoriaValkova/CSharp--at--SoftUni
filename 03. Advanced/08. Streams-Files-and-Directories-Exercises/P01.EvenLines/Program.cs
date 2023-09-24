using System.Text;

namespace EvenLines
{
	using System;

	public class EvenLines
	{
		static void Main()
		{
			string inputFilePath = @"..\..\..\text.txt";

			Console.WriteLine(ProcessLines(inputFilePath));
		}

		public static string ProcessLines(string inputFilePath)
		{
			string result = string.Empty;
			using (StreamReader reader = new StreamReader(inputFilePath))
			{
				int counter = 0;
				string sr = string.Empty;

				while ((sr = reader.ReadLine()) != null)
				{
					string[] line = sr.Split(' ');

					if (counter % 2 == 0)
					{
						for (int i = line.Length - 1; i >= 0; i--)
						{
							string word = line[i];
							for (int j = 0; j < word.Length; j++)
							{
								char ch = word[j];
								if (ch == '-' || ch == ',' || ch == '.' || ch == '!' || ch == '?')
								{
									ch = '@';
								}

								result += ch;
							}

							result += ' ';
						}
					result += "\n";
					}
					counter++;
				}
			}
			return result;
		}
	}
}
