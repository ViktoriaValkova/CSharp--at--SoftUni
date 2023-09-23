using System.Diagnostics.CodeAnalysis;

namespace FolderSize
{
	using System;
	using System.IO;
	public class FolderSize
	{
		static void Main(string[] args)
		{
			string folderPath = @"..\..\..\Files\TestFolder";
			string outputPath = @"..\..\..\Files\output.txt";

			GetFolderSize(folderPath, outputPath);
		}

		public static void GetFolderSize(string folderPath, string outputFilePath)
		{
			double size = 0;

			DirectoryInfo folders = new DirectoryInfo(folderPath);
			FileInfo[] infos = folders.GetFiles("*", SearchOption.AllDirectories);

			foreach (var i in infos)
			{
				size += i.Length;
			}

			size/= 1024;

			File.WriteAllText(outputFilePath, size.ToString());
		}
	}
}