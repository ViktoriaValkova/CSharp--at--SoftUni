namespace P01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000f; // can be done with double as 1000.0 or 1000d
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}