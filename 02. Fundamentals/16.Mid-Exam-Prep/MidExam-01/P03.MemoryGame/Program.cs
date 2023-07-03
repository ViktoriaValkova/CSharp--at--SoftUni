namespace P03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            int turnsCnt = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] playersGuess = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                turnsCnt++;
                if (!CheckIndexIsValid(playersGuess, sequence))
                {
                    AddElementsToSequence(sequence, turnsCnt);
                    continue;
                }

                int firstCardIndex = playersGuess[0];
                int secondCardIndex = playersGuess[1];

                if (sequence[firstCardIndex] == sequence[secondCardIndex])
                {
                    string currentELement = sequence[firstCardIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {currentELement}!");
                    sequence.RemoveAll(num => num == currentELement);
                    if (sequence.Count == 0)
                    {
                        Console.WriteLine($"You have won in {turnsCnt} turns!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

            }
            if (input == "end")
            {

                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }

        }

        static void AddElementsToSequence(List<string> sequence, int turnsCnt)
        {
            sequence.Insert(sequence.Count / 2, $"-{turnsCnt}a");
            sequence.Insert(sequence.Count / 2, $"-{turnsCnt}a");

        }

        static bool CheckIndexIsValid(int[] playersGuess, List<string> sequence)
        {
            if (playersGuess[0] == playersGuess[1]
                || playersGuess[0] >= sequence.Count || playersGuess[0] < 0
                || playersGuess[1] >= sequence.Count || playersGuess[1] < 0)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                return false;
            }

            return true;
        }
    }
}