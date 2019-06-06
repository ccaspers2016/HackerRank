using System;

namespace HackerRank.Practice.PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            var args2 = new[] {-4, 3, -9, 0, 4, 1};

            PlusMinus(args2);
        }

        private static void PlusMinus(int[] arr)
        {
            decimal positive = 0;
            decimal negative = 0;
            decimal zero = 0;

            decimal positiveFraction = 0;
            decimal negativeFraction = 0;
            decimal zeroFraction = 0;

            for (int x = 0; x < arr.Length - 1; x++)
            {
                if (arr[x] < 0)
                {
                    negative++;
                }

                if (arr[x] > 0)
                {
                    positive++;
                }

                if (arr[x] == 0)
                {
                    zero++;
                }
            }

            if (arr.Length != 0)
            {
                positiveFraction = positive / arr.Length;
                negativeFraction = negative / arr.Length;
                zeroFraction = zero / arr.Length;
            }

            Console.WriteLine(positiveFraction);
            Console.WriteLine(negativeFraction);
            Console.WriteLine(zeroFraction);
        }
    }
}
