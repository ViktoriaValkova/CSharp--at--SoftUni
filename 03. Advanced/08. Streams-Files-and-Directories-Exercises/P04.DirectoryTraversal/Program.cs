using System.Text;

namespace DirectoryTraversal
{
	using System;

	public class DirectoryTraversal
	{
		static void Main()
		{
			string path = Console.ReadLine();
			string reportFileName = @"\report.txt";

			string reportContent = TraverseDirectory(path);
			Console.WriteLine(reportContent);

			WriteReportToDesktop(reportContent, reportFileName);
		}

		public static string TraverseDirectory(string inputFolderPath)
		{
			SortedDictionary<string, List<FileInfo>> allFilesByDir = new SortedDictionary<string, List<FileInfo>>();
			string[] files = Directory.GetFiles(inputFolderPath);

			foreach (string currentFile in files)
			{
				FileInfo fileInfo = new FileInfo(currentFile);

				string extension = fileInfo.Extension;

				if (!allFilesByDir.ContainsKey(extension))
				{
					allFilesByDir[extension] = new List<FileInfo>();
				}
				allFilesByDir[extension].Add(fileInfo);
			}
			StringBuilder result = new StringBuilder();

			foreach (var kvp in allFilesByDir.OrderByDescending(x => x.Value.Count))
			{
				result.Append(kvp.Key + "\n");
				List<FileInfo> currentFiles = kvp.Value;

				foreach (var file in currentFiles.OrderBy(x => x.Length))
				{
					result.Append($"--{file.Name}{file.Extension} - {(double)file.Length / 1024}kb\n");
				}
			}
			return result.ToString();
		}

		public static void WriteReportToDesktop(string textContent, string reportFileName)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

			path += reportFileName;

			File.WriteAllText(path, textContent);
		}
	}
}