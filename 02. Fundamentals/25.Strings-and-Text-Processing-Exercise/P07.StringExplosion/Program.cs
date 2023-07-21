using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            StringBuilder result = new StringBuilder();  // so we dont mess with the input Length
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int currentPower = int.Parse(input[i + 1].ToString());
                    power += currentPower;
                    result.Append(input[i]);
                }
                else
                {
                    if (power > 0)
                    {
                        power--; // simulate the removing chars, just not adding them 
                    }
                    else
                    {
                        result.Append(input[i]);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}