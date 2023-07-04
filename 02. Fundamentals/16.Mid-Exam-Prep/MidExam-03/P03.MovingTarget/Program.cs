namespace P03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                switch (command)
                {
                    case "Shoot":
                        int power = int.Parse(cmdArgs[2]);
                        if (CheckValidIndex(targets, index))
                        {
                            ShootTarget(targets, index, power);
                        }
                        break;
                    case "Add": 
                        int value = int.Parse(cmdArgs[2]); 
                        if (CheckValidIndex(targets, index))
                        {
                            targets.Insert(index,value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                            break;
                    case "Strike":
                        int radius = int.Parse(cmdArgs[2]);
                        if (CheckValidIndex(targets, index) && CheckValidIndex(targets, index, radius))
                        {
                            targets.RemoveRange( index - radius, radius * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                            break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static void ShootTarget(List<int> targets, int index, int power)
        {
            targets[index] -= power;
            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }

        static bool CheckValidIndex(List<int> targets, int index)
        {
            if (index < 0 || index >= targets.Count)
            {
                return false;
            }
            return true;
        }
        static bool CheckValidIndex(List<int> targets, int index, int radius)
        {
            if (index - radius < 0 || index + radius >= targets.Count)
            {
                return false;
            }
            return true;
        }
    }
}