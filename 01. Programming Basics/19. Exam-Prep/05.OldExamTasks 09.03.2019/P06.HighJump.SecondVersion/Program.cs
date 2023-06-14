using System;

namespace P06.HighJump_Alternative
{
    internal class Program
    {
        static void Main()
        {
            int goalHeight = int.Parse(Console.ReadLine());
            bool succeded = false;
            bool failed = false;
            int jumpsCount = 0;
            int failedJumps = 0;
            int beamHeight = goalHeight - 30;

            while (!succeded && !failed)
            {
                int currentJumpHeight = int.Parse(Console.ReadLine());
                jumpsCount++;
                if (currentJumpHeight > beamHeight)
                {
                    beamHeight += 5; failedJumps = 0;
                }
                else failedJumps++;
                if (beamHeight > goalHeight) succeded = true;
                if (failedJumps == 3) failed = true;
            }

            if (succeded) Console.WriteLine($"Tihomir succeeded, he jumped over {beamHeight - 5}cm after {jumpsCount} jumps.");
            if (failed) Console.WriteLine($"Tihomir failed at {beamHeight}cm after {jumpsCount} jumps.");
        }
    }
}