using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.MinimumSwaps2
{
    class Program
    {
        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            for (int x = 0; x < arr.Length; x++)
            {
                for (int y = arr.Length-1;y >x;y--)
                {
                    if (arr[x] <= arr[y])
                    {
                        continue;
                    }

                    //Swap It!
                    var temp = arr[x];
                    arr[x] = arr[y];
                    arr[y] = temp;
                    swaps++;
                }
            }

            return swaps;
        }

        static void Main(string[] args)
        {
            //int[] arr = new int[]{1,3,5,2,4,6,7};

            int[] arr = new int[]{ 2,31,1,38,29,5,44,6,12,18,39,9,48,49,13,11,7,27,14,33,50,21,46,23,15,26,8,47,40,3,32,22,34,42,16,41,24,10,4,28,36,30,37,35,20,17,45,43,25,19};
            int res = minimumSwaps(arr);
            Console.WriteLine(res);
        }
    }
}
