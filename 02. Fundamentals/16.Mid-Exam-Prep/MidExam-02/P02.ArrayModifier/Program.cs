namespace P02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            // result is long 
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }
                else
                {
                    string[] command = input.Split();
                    string operation = command[0];
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    long placeHolder = 0;
                    if (operation == "swap")
                    {
                        placeHolder = numbers[firstIndex];
                        numbers[firstIndex] = numbers[secondIndex];
                        numbers[secondIndex] = placeHolder;
                    }
                    if (operation == "multiply")
                    {
                        numbers[firstIndex] *= numbers[secondIndex];
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}