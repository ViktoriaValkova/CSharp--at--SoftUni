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

                try
                {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(percentage));
            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}