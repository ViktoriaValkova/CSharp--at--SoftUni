using System.Runtime.CompilerServices;

namespace P07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split();
                Person person = people.FirstOrDefault(p => p.ID == info[1]);

                if (person == null)
                {
                    person = new Person(info[0], info[1], int.Parse(info[2]));
                    people.Add(person);
                }
                else
                {
                    person.Name = info[0];
                    person.Age = int.Parse(info[1]);
                }

            }

            foreach (Person person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }
}