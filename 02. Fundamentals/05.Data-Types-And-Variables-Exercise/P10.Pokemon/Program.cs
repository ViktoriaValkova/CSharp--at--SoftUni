namespace P10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int currentPokePower = pokePower;
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCnt = 0;
            while (currentPokePower >= distanceBetweenTargets)
            {
                pokeCnt++;
                currentPokePower -= distanceBetweenTargets;

                if (currentPokePower == pokePower /2 && exhaustionFactor!=0)
                {
                    currentPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(pokeCnt);
        }
    }
}