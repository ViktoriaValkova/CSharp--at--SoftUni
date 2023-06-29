namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] guestDecision = Console.ReadLine().Split();
                string guestName = guestDecision[0];

                if (guestDecision[2] == "not") // if (guestDecision.Count = 4
                {
                    RemovePersonFromList(guestList, guestName);
                }
                else
                {
                    AddPersonToList(guestList, guestName);
                }
            }
            Console.WriteLine(string.Join("\n", guestList));
        }

        static void RemovePersonFromList(List<string> guestList, string guestName)
        {
            if (guestList.Contains(guestName))
            {
                guestList.Remove(guestName);
            }
            else
            {
                Console.WriteLine($"{guestName} is not in the list!");
            }
        }
        static void AddPersonToList(List<string> guestList, string guestName)
        {
            if (!guestList.Contains(guestName))
            {
                guestList.Add(guestName);
            }
            else
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }
        }
    }
}