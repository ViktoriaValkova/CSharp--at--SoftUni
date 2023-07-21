using System.Text;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            int remainder = 0;

            if (smallNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder resultingNum = new StringBuilder();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit*smallNumber+remainder;
                resultingNum.Append(product%10);
                remainder = product / 10; 
            }

            if (remainder != 0)
            {
                resultingNum.Append(remainder);
            }

            Console.WriteLine(string.Join("", resultingNum.ToString().Reverse()));
        }
    }
}