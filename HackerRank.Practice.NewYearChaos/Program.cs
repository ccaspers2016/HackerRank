using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackerRank.Practice.NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            //minimumBribes(new[] { 2, 1, 5, 3, 4 });
            //minimumBribes(new[] { 2, 5, 1, 3, 4 });

            //minimumBribes(new[] { 5,1,2,3,7,8,6,4 });
            //minimumBribes(new[] { 1,2,5,3,7,8,6,4 });

            minimumBribes(new[] { 1,2,5,3,4,7,8,6 });

            //int[] q = new[] {5,1,2,3,7,8,6,4};
            //minimumBribes(q);

            //int[] r = new[] { 1,2,5,3,4,7,8,6};
            //minimumBribes(r);

        }

        private static void minimumBribes(int[] q)
        {
            var swapCount = new List<int>();
            var workingList = new List<int>();
            for (int y = 0;y<q.Length;y++)
            {
                workingList.Add(y + 1);
                swapCount.Add(0);
            }

            bool chaoticFlag = false;

            while (!q.SequenceEqual(workingList))
            {
                for (var x = q.Length - 1; x >= 0; x--)
                {
                    if (workingList[x] != q[x]) //Okay, so we have a swap!!
                    {
                        for (int y = x - 1;y >= 0;y--) //We will swap but need to find an item that does not match and needs swapping
                        {
                            if (workingList[y] == q[y]) continue;
                            //Great!!! We can swap.

                            var swapCountIndex = (q.ToList()).IndexOf(workingList[x]);
                            swapCount[swapCountIndex]++;

                            var temp = workingList[y];
                            workingList[y] = workingList[x];
                            workingList[x] = temp;

                            //x = q.Length;
                            break;
                        }
                    }
                }
            }

            if (swapCount.Max()>2)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(swapCount.Sum());
            }
        }
    }
}
