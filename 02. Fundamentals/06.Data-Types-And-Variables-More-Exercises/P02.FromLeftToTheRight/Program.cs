namespace P02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineCnt; i++)
            {
                string input = Console.ReadLine();
                string[] twoNumbers = input.Split(' ', 2);

                long numberOne = long.Parse(twoNumbers[0]);
                long numberTwo = long.Parse(twoNumbers[1]);

                long sum = 0;
                if (numberOne > numberTwo)
                {
                    numberOne = Math.Abs(numberOne);
                    while (numberOne > 0)
                    {
                        sum += numberOne % 10;
                        numberOne /= 10;
                    }
                }
                else
                {
                    numberTwo = Math.Abs(numberTwo);
                    while (numberTwo > 0)
                    {
                        sum += numberTwo % 10;
                        numberTwo /= 10;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}