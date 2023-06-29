namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command.Length > 1) //Add+number
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else // number only 
                {
                    FillPassengers(wagons, int.Parse(command[0]), maxCapacityOfWagon);
                }
            }

            Console.Write(string.Join(" ", wagons));
        }

        static void FillPassengers(List<int> wagons, int newPassangers, int maxCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (newPassangers + wagons[i] <= maxCapacity)
                {
                    wagons[i] += newPassangers;
                    return;
                }
            }
        }
    }
}