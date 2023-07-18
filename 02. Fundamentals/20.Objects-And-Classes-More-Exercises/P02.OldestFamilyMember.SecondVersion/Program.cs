using System.Threading.Channels;

namespace P02.SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }

            Person oldePerson = family.GetOldestMember(family.People);
            Console.WriteLine(oldePerson);
        }
    }

    class Family
    {

        public List<Person> People = new List<Person>();

        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMember(List<Person> people)  // we dont need this, can be just ()
        {
            Person oldestPerson = people.OrderByDescending(p => p.Age).First();
            return oldestPerson;
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}