using P09.ExplicitInterfaces.Models;
using P09.ExplicitInterfaces.Models.Interfaces;

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
	string[] citizenInfo = input.Split();

	IPerson citizen = new Citizen(citizenInfo[0], citizenInfo[1], int.Parse(citizenInfo[2]));
	IResident resident = new Citizen(citizenInfo[0], citizenInfo[1], int.Parse(citizenInfo[2]));
	Console.WriteLine(citizen.GetName());
	Console.WriteLine(resident.GetName());
}