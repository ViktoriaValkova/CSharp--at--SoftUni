namespace P04.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCnt = int.Parse(Console.ReadLine());

            for (int i = 0;i<rotationsCnt;i++)
            {
                int firstElement = numbers[0];

                for (int j = 1;j<numbers.Length;j++)
                {
                    numbers[j-1] = numbers[j];
                }
                numbers[numbers.Length-1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}