namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCnt = 0;
            int ammountLeftPerDay = 0; // ammount exctracted minus what is consumed 
            int totalExtracted = 0;
            while (yield >= 100)
            {
                dayCnt++;
                ammountLeftPerDay = yield - 26;
                totalExtracted += ammountLeftPerDay;
                //  totalExtracted += extractedSpices;
                //  totalExtracted -= 26;
                yield -= 10;
            }
            if (totalExtracted >= 26)
            {
                totalExtracted -= 26;
            }

            Console.WriteLine(dayCnt);
            Console.WriteLine(totalExtracted);
        }
    }
}