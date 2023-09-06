using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace P05.FashionBoutique
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] clothes = Console.ReadLine()
				.Split()
				.Select(x=>int.Parse(x))
				.ToArray();

			int capacity = int.Parse(Console.ReadLine());
			
			Stack<int> box = new Stack<int>(clothes);

			int sum = 0;
			int rackCount =1;

			while (box.Count > 0)
			{

				if (sum + box.Peek() <= capacity)
				{
					sum+=box.Pop();
				}
				else
				{
					rackCount++;
					sum = box.Pop();
				}
			}

			Console.WriteLine(rackCount);
		}
	}
}