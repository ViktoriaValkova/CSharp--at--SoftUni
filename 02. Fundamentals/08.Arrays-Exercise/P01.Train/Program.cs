namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[numberOfWagons];
            int sum = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                sum += peoplePerWagon[i];
            }
            Console.WriteLine($"{string.Join(" ",peoplePerWagon)}");
            Console.WriteLine(sum);
        }
    }
}