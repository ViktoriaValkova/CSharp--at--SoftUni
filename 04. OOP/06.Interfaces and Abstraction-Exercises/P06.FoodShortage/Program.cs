using P04.BorderControl.Models;
using P06.FoodShortage.Models;
using P06.FoodShortage.Models.Interfaces;

int count = int.Parse(Console.ReadLine());

List<IBuyer> people = new List<IBuyer>();
int totalFood = 0;

for (int i = 0; i < count; i++)
{
	string[] cmdArg = Console.ReadLine().Split();

	if (cmdArg.Length ==3)
	{
		people.Add(new Rebel(cmdArg[0], int.Parse(cmdArg[1]), cmdArg[2]));
		continue;
	}
	people.Add(new Citizen(cmdArg[0], int.Parse(cmdArg[1]), cmdArg[2], cmdArg[3]));
}

string name = string.Empty;

while ((name = Console.ReadLine()) != "End")
{
	var person = people.Find(p => p.Name == name);
	if (person!=null)
	{
		totalFood+=person.BuyFood();
	}
}

Console.WriteLine(totalFood);
               