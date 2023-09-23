namespace ExtractSpecialBytes
{
	using System;
	using System.IO;
	public class ExtractSpecialBytes
	{
		static void Main()
		{
			string binaryFilePath = @"..\..\..\Files\example.png";
			string bytesFilePath = @"..\..\..\Files\bytes.txt";
			string outputPath = @"..\..\..\Files\output.bin";

			ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
		}

		public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
		{
			List<byte> byteList = new List<byte>();

			// Open a StreamReader to read the list of bytes to extract from a text file
			using (StreamReader bytes = new StreamReader(bytesFilePath))
			{
				string bytesLine = string.Empty;

				// Read each line from the text file and parse it as a byte, then add it to the list
				while ((bytesLine = bytes.ReadLine()) != null)
				{
					byteList.Add(byte.Parse(bytesLine));
				}
			}

			// Open a FileStream to read the binary file
			using (FileStream input = new FileStream(binaryFilePath, FileMode.Open))
			{
				// Open a FileStream to write the extracted bytes to the output file
				using (FileStream output = new FileStream(outputPath, FileMode.Create))
				{
					byte[] buf = new byte[1024];
					while (true)
					{
						// Read a chunk of bytes from the binary file into the buffer
						int bytesRead = input.Read(buf);
						if (bytesRead == 0)
						{
							break;
						}

						foreach (var b in buf)
						{
							if (byteList.Contains(b))
							{
								output.WriteByte(b);
							}
						}
					}
				}
			}
		}
	}
}