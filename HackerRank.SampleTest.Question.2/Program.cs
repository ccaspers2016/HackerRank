using System;
using System.Collections.Generic;

namespace HackerRank.SampleTest.Question._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1;
            int r = 8;
            var a = oddNumbers(l, r);
        }

        // Complete the oddNumbers function below.
        static List<int> oddNumbers(int l, int r)
        {
            var oddNumberList = new List<int>();

            for (int checkForOdd = l; checkForOdd <= r; checkForOdd++)
            {
                if (Decimal.Remainder(checkForOdd,2)!=0)
                {
                    oddNumberList.Add(checkForOdd);
                    Console.WriteLine(checkForOdd);
                }
            }

            return oddNumberList;
        }
    }
}
