using System.Threading.Channels;

namespace P05.FilterByAge
{
	internal class Program
	{
		class Person
		{
			public Person(string name, int age)
			{
				Name = name;
				Age = age;
			}
			public int Age { get; set; }
			public string Name { get; set; }
		}
		static List<Person> people = new List<Person>();
		static void Main(string[] args)
		{
			// Read and add all people to List of new class Person with name and age
			int peopleCount = int.Parse(Console.ReadLine());
			ReadPeople(peopleCount);

			// read filer word and age to filter by 
			string filterWord = Console.ReadLine(); // older or younger
			int ageBorder = int.Parse(Console.ReadLine());

			// create function to filter people by filter word and given age 
			Func<Person, bool> filter = CreateFilter(filterWord, ageBorder);

			// create new list of Person, using Where and the filter to get only people that match the filter
			List<Person> matchingPeople = people.Where(filter).ToList();

			// read the wanted format
			string format = Console.ReadLine();

			// create void function Action to select the model of printing the result 
			Action<Person> printer = CreatePrintModel(format);

			// create a method to print the matchingPeople List by the printer func
			PrintResult(printer, matchingPeople);
		}

		static void ReadPeople(int peopleCount)
		{

			for (int i = 0; i < peopleCount; i++)
			{
				string[] tokens = Console.ReadLine().Split(", ").ToArray();

				string name = tokens[0];
				int age = int.Parse(tokens[1]);

				people.Add(new Person(name, age));
			}
		}
		static Func<Person, bool> CreateFilter(string filterWord, int ageBorder)
		{
			if (filterWord == "younger")
			{
				return p => p.Age < ageBorder;
			}
			return p => p.Age >= ageBorder; // if older

		}
		static Action<Person> CreatePrintModel(string format)
		{
			if (format == "name")
			{
				return p => Console.WriteLine($"{p.Name}");
			}
			if (format == "age")
			{
				return p => Console.WriteLine($"{p.Age}");
			}

			return p => Console.WriteLine($"{p.Name} - {p.Age}");

		}
		private static void PrintResult(Action<Person> printer, List<Person> matchingPeople)
		{
			foreach (Person person in matchingPeople)
			{
				printer(person);
			}
		}



	}
}