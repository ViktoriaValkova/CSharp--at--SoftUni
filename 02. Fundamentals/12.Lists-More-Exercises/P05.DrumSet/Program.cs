namespace P05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            List<int> initialDrumsState = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); 

            List<int>workingList = new List<int>(initialDrumsState);

            string input;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hittingPower = int.Parse(input); 

                DecreaseQuality(workingList,hittingPower);
                CheckForBrokenDrumm(initialDrumsState, workingList,ref budget);
            }

            Console.WriteLine(string.Join(" ",workingList));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");

        }
         static void DecreaseQuality(List<int> workingList, int hittingPower)
        {
            for (int i = 0; i < workingList.Count; i++)
            {
                workingList[i]-=hittingPower;
            }
        }

         static void CheckForBrokenDrumm(List<int> initialDrumsState, List<int> workingList,ref decimal budget)
        {
            for (int i = 0; i < workingList.Count; i++)
            {
                
                if (workingList[i] <= 0)
                {
                    int drummPrice = initialDrumsState[i] * 3;
                    if (TryToReplaceBrokeDrumm(workingList, drummPrice, ref budget))
                    {
                        workingList[i] = initialDrumsState[i];
                    }
                    else
                    {
                        workingList.RemoveAt(i);
                        initialDrumsState.RemoveAt(i);
                    }
                }
            }
            
        }

         static bool TryToReplaceBrokeDrumm(List<int> workingList, int drummPrice, ref decimal budget)
         {
             if (drummPrice <= budget)
             {
                 budget -= drummPrice;
                 return true;
             }
             return false;
         }


    }
}