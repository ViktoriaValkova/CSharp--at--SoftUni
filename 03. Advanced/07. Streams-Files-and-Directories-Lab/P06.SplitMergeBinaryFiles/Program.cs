namespace SplitMergeBinaryFile
{
	using System;
	using System.IO;
	using System.Linq;

	public class SplitMergeBinaryFile
	{
		static void Main()
		{
			string sourceFilePath = @"..\..\..\Files\example.png";
			string joinedFilePath = @"..\..\..\Files\example-joined.png";
			string partOnePath = @"..\..\..\Files\part-1.bin";
			string partTwoPath = @"..\..\..\Files\part-2.bin";

			SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
			MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
		}

		public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
		{
			using (FileStream input = new FileStream(sourceFilePath, FileMode.Open))
			{
				using (FileStream outputOne = new FileStream(partOneFilePath, FileMode.Create))
				{
					using (FileStream outputTwo = new FileStream(partTwoFilePath, FileMode.Create))
					{
						byte[] buf = new byte[1];
						int counter = 0;
						while (true)
						{
							// Read a chunk of bytes from the binary file into the buffer
							int bytesRead = input.Read(buf);
							if (bytesRead == 0)
							{
								break;
							}
							if (counter % 2 == 0)
							{
								outputOne.WriteByte(buf[0]);
							}
							else
							{
								outputTwo.WriteByte(buf[0]);
							}
							counter++;
						}
					}
				}
			}
		}

		public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
		{
			using (FileStream inputOne = new FileStream(partOneFilePath, FileMode.Open))
			{
				using (FileStream inputTwo = new FileStream(partTwoFilePath, FileMode.Open))
				{
					using (FileStream output = new FileStream(joinedFilePath, FileMode.Create))
					{
						byte[] bufOne = new byte[1];
						byte[] bufTwo = new byte[1];
						int counter = 0;
						while (true)
						{
							// Read a chunk of bytes from the binary file into the buffer
							int bytesReadFromOne = inputOne.Read(bufOne);
							int bytesReadFromTwo = inputTwo.Read(bufTwo);

							if (bytesReadFromOne == 0)
							{
								break;
							}

							output.WriteByte(bufOne[0]);
							output.WriteByte(bufTwo[0]);

							counter++;
						}
					}
				}
			}
		}
	}
}