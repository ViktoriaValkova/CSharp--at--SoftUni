namespace P06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');
                string instruction = command[0];
                if (instruction == "Add")
                {
                int number = int.Parse(command[1]);
                numbers.Add(number);

                }
                else if (instruction == "Remove")
                {
                int number = int.Parse(command[1]);
                    numbers.Remove(number);
                }
                else if (instruction == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else //Insert
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index,number);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}