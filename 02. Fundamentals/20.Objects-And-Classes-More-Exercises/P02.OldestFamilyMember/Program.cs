namespace P02.OldestFamilyMember
{
     class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family newFamily = new Family(); 
            for (int i = 0; i < count; i++)
            {
                string [] data = Console.ReadLine().Split();
                
                string name = data[0];
                int age = int.Parse(data[1]);
                newFamily.AddPerson(name,age);
            }

            Person oldestOne = newFamily.GetOldestPerson();
            Console.WriteLine($"{oldestOne.Name} {oldestOne.Age}");
        }
    }
     class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            People = new List<Person>(); // dont forget to add it here 
        }

        public List<Person> People = new List<Person>();

        public void AddPerson(string name, int age)
        {
            People.Add(new Person(name, age));
        }

        public Person GetOldestPerson()
        {
            
            Person oldestPerson = People.OrderByDescending(a => a.Age).First();
            return oldestPerson;
        }
    }
}