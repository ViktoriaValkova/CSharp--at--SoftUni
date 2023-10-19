namespace P05.ComparingObjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			List<Person> persons = new List<Person>();

			while ((input = Console.ReadLine()) != "END")
			{
				string[] cmdArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
				string name = cmdArg[0];
				int age = int.Parse(cmdArg[1]);
				string town = cmdArg[2];

				persons.Add(new Person(name,age,town));
			}

			int indexToCompare = int.Parse(Console.ReadLine());

			Person personToCompareWith = persons[indexToCompare-1];
			int countEqual = 0;
			int countNotEqual = 0;
			foreach (Person person in persons)
			{
				
				if (person.CompareTo(personToCompareWith) == 0)
				{
					countEqual++;
				}
				else if (person.CompareTo(personToCompareWith)!=0)
				{
					countNotEqual++;
				}
			}

			if (countEqual == 1)
			{
				Console.WriteLine("No matches");
				return;
			}
			Console.WriteLine($"{countEqual} {countNotEqual} {persons.Count}");
		}
	}
}