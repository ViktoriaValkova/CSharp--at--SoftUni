namespace P02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> gaussList = new List<int>();
            for (int i = 0; i < (numbers.Count / 2); i++)
            {
                gaussList.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 != 0)
            {
                gaussList.Add(numbers[numbers.Count / 2]);
            }

            Console.Write(string.Join(" ", gaussList));

            //List<decimal> numbers = Console.ReadLine()
            //    .Split()
            //    .Select(decimal.Parse)
            //    .ToList();
            //int originalLength = numbers.Count; // because Count gets smaller, we need to save the count in another variable
            //for (int i = 0; i < originalLength / 2; i++)
            //{
            //    numbers[i] += numbers[numbers.Count - 1];
            //    numbers.RemoveAt(numbers.Count - 1);
            //}

            //Console.Write(string.Join(" ", numbers));
        }
    }
}