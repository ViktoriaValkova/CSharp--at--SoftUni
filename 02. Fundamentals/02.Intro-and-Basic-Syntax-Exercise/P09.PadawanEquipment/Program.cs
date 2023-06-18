namespace P09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ammountMoney = double.Parse(Console.ReadLine()!);
            int studentsCnt = int.Parse(Console.ReadLine()!);
            double lighsabersPrice = double.Parse(Console.ReadLine()!);
            double robePrice = double.Parse(Console.ReadLine()!);
            double beltPrice = double.Parse(Console.ReadLine()!);

            double totalSumLightsabers = Math.Ceiling(studentsCnt * 1.1) * lighsabersPrice;
            double totalSumRobes = studentsCnt * robePrice;
            int freeBelt = studentsCnt / 6;
            double totalSumBelt = (studentsCnt - freeBelt) * beltPrice;
            double sumTotal = totalSumLightsabers + totalSumRobes + totalSumBelt;
            if (sumTotal <= ammountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {sumTotal:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sumTotal - ammountMoney:f2}lv more.");
            }
        }
    }
}