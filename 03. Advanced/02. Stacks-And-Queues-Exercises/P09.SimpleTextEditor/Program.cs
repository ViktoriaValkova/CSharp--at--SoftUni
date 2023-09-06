using System.Text;

namespace P09.SimpleTextEditor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int cmdCount = int.Parse(Console.ReadLine());
			Stack<string> changes = new Stack<string>();
			string result = string.Empty;

			for (int i = 0; i < cmdCount; i++)
			{
				string[] cmdArg = Console.ReadLine().Split(' ').ToArray();


				switch (cmdArg[0])
				{
					case "1":
						changes.Push(result);
						result += cmdArg[1];
						break;
					case "2":
						changes.Push(result);
						int count = int.Parse(cmdArg[1]);
						result = result.Remove(result.Length - count);
						break;
					case "3":
						int index = int.Parse(cmdArg[1]);
						Console.WriteLine(result[index - 1]);
						break;
					case "4":
						result = changes.Pop();
						break;
				}

			}
		}
	}
}
