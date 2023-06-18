namespace P06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);
            string numberString = number.ToString();
            int finalResult = 0;
            //int newResult = 1;
            for (int i = 0; i < numberString.Length; i++)
            {

                int digit = (int)Char.GetNumericValue(numberString[i]);

                int result = 1;
                for (int j = 1; j <= digit; j++)
                {
                    result *= j;
                }
                finalResult += result;
            }
            if (finalResult == number) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}