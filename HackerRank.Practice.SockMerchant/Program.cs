using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace HackerRank.Practice.SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3, 6, 6, 3, 5, 5, 5, 5, 5, 5 };
            sockMerchant(20, ar);
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            var totalPairs = 0;

            for (int checkPairs = 0; checkPairs < n-1; checkPairs++)
            {
                if (ar[checkPairs] == ar[checkPairs + 1])
                {
                    totalPairs++;
                    checkPairs++;
                }
            }

            Console.WriteLine(totalPairs);
            return totalPairs;
        }

        
    }
}
