namespace P03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double difference = Math.Abs(numberA - numberB);
            if (difference >= 0.000001) 
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }



        }
    }
}