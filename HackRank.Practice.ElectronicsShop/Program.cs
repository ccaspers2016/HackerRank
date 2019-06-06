using System;

namespace HackRank.Practice.ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keyboards = new[] {10,2,3};
            int[] drives = new[] {3,1};
            int b = 9;

            var spent = getMoneySpent(keyboards, drives, b);
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var spent = -1;

            for (int x = 0; x < keyboards.Length; x++)
            {
                for (int y = 0; y < drives.Length; y++)
                {
                    if ((keyboards[x] + drives[y]) > spent && (keyboards[x] + drives[y]) <= b)
                    {
                        spent = keyboards[x] + drives[y];
                    }
                }
            }

            Console.Write(spent);
            return spent;


        }
    }
}
