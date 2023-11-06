namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int linesCnt = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < linesCnt; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}