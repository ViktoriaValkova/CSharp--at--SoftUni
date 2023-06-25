namespace P09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int sequenceCnt = 0;
            int bestSequenceCnt = 0;
            int bestSequenceLength = 0;
            int[] bestSequence = new int[sequenceLength];
            int bestSum = 0;
            int bestStartingIndex = sequenceLength;

            while ((input = Console.ReadLine()) != "Clone them!")
            {

                int[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();  //several ! possible, which will lead to several empty spaces 
                sequenceCnt++;
                int consecutiveOnesCnt = 1;
                int sumOnes = 0;
                int startingIndex = 0;
                int tempLength = 0;
                int tempIndex = 0;
                for (int j = 0; j < sequenceLength; j++) // has to be separate, because otherwise it doesnt get the last digit 
                    // can be avoided by adding the last element in the end of the for loop 
                {
                    sumOnes += sequence[j]; // doesnt matter if all is added becasue 0 doesnt change 
                }

                for (int i = 0; i < sequenceLength - 1; i++)
                {

                    if (sequence[i] == sequence[i + 1] && sequence[i] != 0)  // for if 00
                    {
                        consecutiveOnesCnt++;

                        if (consecutiveOnesCnt == 2)
                        {
                            startingIndex = i;
                        }
                    }
                    else
                    {
                        consecutiveOnesCnt = 1;
                    }
                    if (consecutiveOnesCnt > tempLength)
                    {
                        tempLength = consecutiveOnesCnt;
                        tempIndex = startingIndex;

                    }
                }
                if (tempLength > bestSequenceLength ||
                    tempLength == bestSequenceLength && tempIndex < bestStartingIndex ||
                    tempLength == bestSequenceLength && tempIndex == bestStartingIndex && sumOnes > bestSum)

                {
                    bestSequenceLength = tempLength;
                    bestSequence = sequence.ToArray(); // here inst needed, but otherwise if we change the one array it will change the othere as well (pointing to the same place if .ToArray();)
                    bestStartingIndex = startingIndex;
                    bestSum = sumOnes;
                    bestSequenceCnt = sequenceCnt;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceCnt} with sum: {bestSum}.");
            Console.Write(string.Join(" ", bestSequence));
        }
    }
}