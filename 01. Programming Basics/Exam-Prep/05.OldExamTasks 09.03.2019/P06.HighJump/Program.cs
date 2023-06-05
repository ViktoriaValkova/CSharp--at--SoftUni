using System;

namespace P06.HighJump  // 09/10.03.2019
{
    internal class Program           
    {
        static void Main(string[] args)
        {
            int goalHeight = int.Parse(Console.ReadLine());
            int currentJumpHeight = 0;
            int jumpCount = 0;
            int newHeight = goalHeight - 30;

            int unsuccessfulJumpsCounter = 0;
            while (unsuccessfulJumpsCounter < 3)
            {

                for (int tryJump = 1; tryJump <= 3; tryJump++)
                {
                    currentJumpHeight = int.Parse(Console.ReadLine());
                    jumpCount++;
                    if (currentJumpHeight > newHeight)
                    {
                        break;
                    }
                   unsuccessfulJumpsCounter++;
                }
                if (unsuccessfulJumpsCounter == 3)
                {
                    Console.WriteLine($"Tihomir failed at {newHeight}cm after {jumpCount} jumps.");
                    break;
                }

                if (newHeight >= goalHeight) //!!!! При достигане на желаната височина и нейното успешно прескачане, тренировката приключва с успех.
                                             // so first the beamHeight must be at or above the goalHeight
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {goalHeight}cm after {jumpCount} jumps.");
                    break;
                }
                newHeight += 5;
                unsuccessfulJumpsCounter = 0;
            }

        }
    }
}
