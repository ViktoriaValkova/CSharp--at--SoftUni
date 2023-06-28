namespace P02.ChangeList
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
                string[] instruction = input.Split();

                switch (instruction[0])
                {
                    case "Delete":
                        int element = int.Parse(instruction[1]);
                        numbers.RemoveAll(num => num == element);
                        break;
                    case "Insert":
                        int number = int.Parse(instruction[1]);
                        int index = int.Parse(instruction[2]);
                        numbers.Insert(index, number);
                        break;

                }
            }

            Console.Write(string.Join(" ", numbers));
        }
    }
}