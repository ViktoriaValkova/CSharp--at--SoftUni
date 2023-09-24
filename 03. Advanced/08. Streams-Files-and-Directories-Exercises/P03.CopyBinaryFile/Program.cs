namespace CopyBinaryFile
{
	using System;

	public class CopyBinaryFile
	{
		static void Main()
		{
			string inputFilePath = @"..\..\..\copyMe.png";
			string outputFilePath = @"..\..\..\copyMe-copy.png";

			CopyFile(inputFilePath, outputFilePath);
		}

		public static void CopyFile(string inputFilePath, string outputFilePath)
		{
			using (FileStream file = new FileStream(inputFilePath, FileMode.Open))
			{
				using (FileStream output = new FileStream(outputFilePath, FileMode.Create))
				{
					byte[] buf = new byte[1024];
					while (true)
					{
						// Read a chunk of bytes from the binary file into the buffer
						int bytesRead = file.Read(buf);
						if (bytesRead == 0)
						{
							break;
						}
						output.Write(buf, 0, bytesRead);
					}

				}

			}
		}
	}
}
