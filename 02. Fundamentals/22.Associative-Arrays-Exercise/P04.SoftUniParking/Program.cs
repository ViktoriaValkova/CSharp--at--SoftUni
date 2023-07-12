namespace P04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkedCars = new Dictionary<string, string>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string command = cmdArg[0];
                string name = cmdArg[1];

                if (command == "register")
                {
                    string license = cmdArg[2];
                    if (parkedCars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkedCars[name]}");
                    }
                    else
                    {
                        parkedCars.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                }
                else
                {
                    if (!parkedCars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parkedCars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var parkedCar in parkedCars)
            {
                Console.WriteLine($"{parkedCar.Key} => {parkedCar.Value}");
            }
        }
    }
}