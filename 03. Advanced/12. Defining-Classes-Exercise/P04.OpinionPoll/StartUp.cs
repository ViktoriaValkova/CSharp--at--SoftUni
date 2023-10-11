namespace DefiningClasses
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			Family family = new Family();
			string[] input = new string[2];
			for (int i = 0; i < count; i++)
			{
				input = Console.ReadLine().Split().ToArray();
				Person person = new Person(input[0], int.Parse(input[1]));
				family.AddMember(person);
			}

			List<Person> olderPeople = family.GetPeopleOrderThan30().OrderBy(p=>p.Name).ToList();
			foreach (Person person in olderPeople)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}
		}
	}
}