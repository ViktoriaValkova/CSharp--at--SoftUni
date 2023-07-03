namespace P02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int[] liftState = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < liftState.Length; i++)
            {
                if (peopleCnt == 0)
                {
                    break;
                }
                if (liftState[i] == 4)
                {
                    continue;
                }
                int peopleSeated;
                if (peopleCnt >= 4)
                {
                    peopleSeated = 4 - liftState[i];
                    liftState[i] += peopleSeated;
                    peopleCnt -= peopleSeated;
                }
                while (peopleCnt < 4 && peopleCnt > 0 && liftState[i] < 4)
                {
                    liftState[i]++;
                    peopleCnt--;
                }
            }
            bool emptySpace = false;
            for (int i = 0; i < liftState.Length; i++)
            {
                if (liftState[i] < 4)
                {
                    emptySpace = true;
                }
            }
            if (peopleCnt > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleCnt} people in a queue!");
            }
            else if (emptySpace)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(string.Join(' ', liftState));
        }
    }
}