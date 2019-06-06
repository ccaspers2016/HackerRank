using System;
using System.Linq;

namespace HackerRank.Practice.JumpingOnTheClouds
{
    class Program
    {
        static void Main()
        {
            int[] c = new[] {0, 0, 1, 0, 0, 1, 0};
            //var c = new[] { 0, 0, 0, 0, 1, 0 };

            jumpingOnClouds(c);
        }
        static int jumpingOnClouds(int[] c)
        {
            var jumps = 0;
            var skipped = false;
            var startFound = false;
            var endFound = false;

            var myList = c.ToList();
            myList.Add(-1);
            myList.Add(-1);

            for (var x = 0; x < myList.Count; x++)
            {
                if (myList[x] == 0)
                {
                    if (!startFound)
                    {
                        startFound = true;
                        continue;
                    }
                    else
                    {
                        endFound = true;
                        if (myList[x + 1] == 0)
                        {
                            if (!skipped)
                            {
                                x++;
                            }
                        }
                    }
                }
                else
                {
                    skipped = true;
                }


                if (startFound && endFound)
                {
                    jumps++;
                    endFound = false;
                    skipped = false;
                }
            }

            Console.Write(jumps);
            return jumps;
        }
    }
}
