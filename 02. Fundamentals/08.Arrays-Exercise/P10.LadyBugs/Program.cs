namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());
            int[] startingPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldLength];
            // here we put the ladybugs in the field 
            // can also be done with foreach: foreach (int position in positions) ... field[position] = 1; 
            for (int i = 0; i < startingPositions.Length; i++)
            {
                if (startingPositions[i] >= 0 && startingPositions[i] < fieldLength) // because incorrect indexes can be given - negative or more than board size
                {
                    field[startingPositions[i]] = 1;
                }
            }
            // reading the instructions for ladybug flight
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] instruction = input.Split().ToArray();
                int ladyBugIndex = int.Parse(instruction[0]);
                string direction = instruction[1];
                int flightLength = int.Parse(instruction[2]);
                // checking if data is valid to move 
                if (ladyBugIndex < 0  // if invalid number for an index was given (to low)
                    || ladyBugIndex >= fieldLength// if invalid number for an index was given (to high)
                    || flightLength == 0  //if flight is 0
                    || field[ladyBugIndex] == 0) //if a place in a field was chosen, where there was no ladybug (it had 0 instead of 1)
                {
                    continue;
                }

                int landingIndex = ladyBugIndex;
                if (direction == "right")
                {
                    landingIndex += flightLength;
                }
                else
                {
                    landingIndex-= flightLength;
                }
                /*
                // or without the top if-else
                if (direction == "left")
                {
                    flightLength *= -1;
                }
                */
                field[ladyBugIndex] = 0; //LB flights away 
                while (landingIndex < fieldLength // check if going to the right, LB will be out of field 
                    && landingIndex >= 0) //check if going to the left, LB will be out of field 
                {
                    if (direction == "right")
                    {
                        if (field[landingIndex] == 1)  // index has a ladybug already 
                        {
                            landingIndex += flightLength; //another flight 
                        }
                        else
                        {
                            field[landingIndex] = 1; //index is free 
                            break;
                        }
                    }
                    else //left 
                    {
                        if (field[landingIndex] == 1)
                        {
                            landingIndex -= flightLength;
                        }
                        else
                        {
                            field[landingIndex] = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}