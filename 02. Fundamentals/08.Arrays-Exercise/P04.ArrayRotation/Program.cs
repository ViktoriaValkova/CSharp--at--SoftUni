namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int rotationsCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotationsCnt; i++)
            {
                int placeHolder = numbers[0];

                Array.Copy(numbers, 1, numbers, 0, numbers.Length - 1);
                numbers[numbers.Length - 1] = placeHolder;
            }
            Console.WriteLine(string.Join(" ", numbers));

            // improved for speed 
            int timesToRotate = rotationsCnt%numbers.Length;

            for (int i = 0; i < timesToRotate; i++)
            {
                int placeHolder = numbers[0];

                Array.Copy(numbers, 1, numbers, 0, numbers.Length - 1);
                numbers[numbers.Length - 1] = placeHolder;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}