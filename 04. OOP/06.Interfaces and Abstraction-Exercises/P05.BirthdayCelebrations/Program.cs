using P04.BorderControl.Models.Interfaces;
using P04.BorderControl.Models;
using P05.BirthdayCelebrations.Models.Interfaces;
using P05.BirthdayCelebrations.Models;

namespace P05.BirthdayCelebrations
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string input = string.Empty;
			List<IBirthable> list = new List<IBirthable>();
			while ((input = Console.ReadLine()) != "End")
			{
				string[] cmdArg = input.Split(" ");
				string name = cmdArg[1];
				switch (cmdArg[0])
				{
					case "Citizen":
						list.Add(new Citizen(cmdArg[3], name, int.Parse(cmdArg[2]), cmdArg[4]));
						break;
					case "Pet":
						list.Add(new Pet(name, cmdArg[2]));
						break;
				}
			}

			string year = Console.ReadLine();

			list = list.FindAll(le => le.Birthdate.EndsWith(year));

			list.ForEach(le => Console.WriteLine(le.Birthdate));
		}
	}
}