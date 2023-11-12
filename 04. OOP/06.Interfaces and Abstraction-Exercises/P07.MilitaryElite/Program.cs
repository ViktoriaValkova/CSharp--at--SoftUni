using System.Runtime.CompilerServices;
using P07.MilitaryElite.Models;
using P07.MilitaryElite.Models.Enum;
using P07.MilitaryElite.Models.Interfaces;

string input = string.Empty;

List<ISoldier> soldiers = new List<ISoldier>();

while ((input = Console.ReadLine()) != "End")
{
	string[] cmdArgs = input.Split();
	string id = cmdArgs[1];
	string firstName = cmdArgs[2];
	string lastName = cmdArgs[3];

	switch (cmdArgs[0])
	{
		case "Private":
			soldiers.Add(new Private(firstName, lastName, id, decimal.Parse(cmdArgs[4])));
			break;
		case "Commando":
			AddCommando(cmdArgs, soldiers,id,firstName,lastName);
			break;
		case "LieutenantGeneral":
			AddLieutenant(cmdArgs, soldiers, firstName, lastName, id);
			break;
		case "Engineer":
			AddEngineer(cmdArgs, soldiers, id, firstName, lastName);
			break;
		case "Spy":
			soldiers.Add(new Spy(id, firstName, lastName, int.Parse(cmdArgs[4])));
			break;
	}


}
void AddLieutenant(string[] strings, List<ISoldier> list, string s, string lastName1, string id1)
{
	string[] ids = strings[4..];
	List<Private> currentPrivates = new List<Private>();
	foreach (string idPrivate in ids)
	{
		currentPrivates.Add(list.Find(p => p.Id == idPrivate) as Private);
	}

	list.Add(new LieutenantGeneral(s, lastName1, id1, decimal.Parse(strings[4]), currentPrivates.ToArray()));
}

void AddEngineer(string[] cmdArgs1, List<ISoldier> soldiers1, string s1, string firstName1, string lastName2)
{
	string corpsInput = cmdArgs1[5];
	if (!isCorpsValid(corpsInput, out Corps corps))
	{
		return;
	}

	string[] repairsInfo = cmdArgs1[6..];
	List<Repair> repairs = new List<Repair>();
	for (int i = 0; i < repairsInfo.Length; i += 2)
	{
		Repair repair = new Repair(repairsInfo[i], int.Parse(repairsInfo[i+1]));
		repairs.Add(repair);
	}

	soldiers1.Add(new Engineer(s1, firstName1, lastName2, decimal.Parse(cmdArgs1[4]), corps, repairs.ToArray()));
}

bool isCorpsValid(string s, out Corps result)
{
	if (Enum.TryParse(s, out result))
	{
		return true;
	}

	return false;
}

void AddCommando(string[] cmdArgs1, List<ISoldier> soldiers1, string s1, string firstName1, string lastName2)
{
	string[] missionInput = cmdArgs1[6..];
	if (!isCorpsValid(cmdArgs1[5], out Corps corps))
	{
		return;
	}
	List<Mission> missions = new List<Mission>();
	for (int i = 0; i < missionInput.Length; i += 2)
	{
		if (!Enum.TryParse(missionInput[i + 1], out State state))
		{
			continue;
		}
		Mission currentMission = new Mission(missionInput[i], state);
		missions.Add(currentMission);
	}

	soldiers1.Add(new Commando(s1, firstName1, lastName2, decimal.Parse(cmdArgs1[4]), corps, missions.ToArray()));
}


soldiers.ForEach(s => Console.WriteLine(s));