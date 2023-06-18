namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine()!);
            string groupType = Console.ReadLine()!;
            string dayOfWeek = Console.ReadLine()!;
            double price = 0; // with decimal, then it will be 8.45m
            if (groupType == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Saturday": price = 9.8; break;
                    case "Sunday": price = 10.46; break;
                    case "Friday": price = 8.45; break;
                }
                if (peopleCnt >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCnt > 100)
                {
                    peopleCnt -= 10;
                }
                switch (dayOfWeek)
                {
                    case "Friday": price = 10.9; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
            }
            else
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
                if (peopleCnt >= 10 && peopleCnt <= 20)
                {
                    price *= 0.95;
                }
            }
            price *= peopleCnt;
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}