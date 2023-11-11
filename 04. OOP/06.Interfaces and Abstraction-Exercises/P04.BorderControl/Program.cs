using P04.BorderControl.Models;
using P04.BorderControl.Models.Interfaces;

namespace P04.BorderControl
{
	public class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			List<IIdentifiable> list = new List<IIdentifiable>();
			while ((input = Console.ReadLine()) != "End")
			{
				string[] cmdArg = input.Split(" ");
				string name = cmdArg[0];
				if (cmdArg.Length == 2)
				{
					list.Add(new Robot(cmdArg[1], name));	
				}
				else
				{
					
					list.Add(new Citizen(cmdArg[2], name, int.Parse(cmdArg[1])));
				}
			}

			string fakeDigits = Console.ReadLine();

			list = list.FindAll(le => le.Id.EndsWith(fakeDigits));

			list.ForEach(le=>Console.WriteLine(le.Id));
		}
	}
}