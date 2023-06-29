namespace P04.ListOperations
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string direction = command[0];
                switch (direction)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (IsIndexValid(numbers.Count, indexToRemove))
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        break;
                    case "Insert":
                        int number = int.Parse(command[1]);
                        int indexToInsertAt = int.Parse(command[2]);
                        if (IsIndexValid(numbers.Count, indexToInsertAt))
                        {
                            numbers.Insert(indexToInsertAt, number);
                        }
                        break;
                    case "Shift":
                        ShiftNumsLeftOrRight(numbers, int.Parse(command[2]), command[1]);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void ShiftNumsLeftOrRight(List<int> numbers, int repetitionCnt, string direction)
        {
            for (int i = 0; i < repetitionCnt; i++)
            {
                if (direction == "left")
                {   // can be done with GetRange,RemoveRange,InsertRange  
                    numbers.Add(numbers.First());
                    numbers.RemoveAt(0);
                }
                else
                {
                    numbers.Insert(0, numbers.Last());
                    int indexLastElement = numbers.Count - 1;
                    numbers.RemoveAt(indexLastElement);
                }
            }
        }

        static bool IsIndexValid(int count, int index)
        {
            if (index < 0 || index > count - 1)
            {
                Console.WriteLine("Invalid index");
                return false;
            }
            return true;
        }
        // Extension methods are done like this 
        static void Shift<T>(this List<T> numbers, string direction, int count)
        {

        }
    }
}