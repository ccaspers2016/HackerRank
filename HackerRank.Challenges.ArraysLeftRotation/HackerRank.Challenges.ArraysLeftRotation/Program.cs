using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges.ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] {33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97};
            int d = 13;

            int[] result = rotLeft(a, d);


        }

        private static int[] rotLeft(int[] a, int d)
        {
            var list = a.ToList();
            var shiftList = list;

            for (int x = 0; x < a.Length; x++)
            {
                int newIndex = x - d;
                if (newIndex < 0)
                {
                    newIndex = x + a.Length - d;
                }

                shiftList[newIndex] = a[x];
            }

            foreach (var line in shiftList)
            {
                Console.Write(line);
                Console.Write(" ");
            }

            Console.WriteLine();

            return shiftList.ToArray();
        }
    }
}
