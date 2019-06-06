using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private static int diagonalDifference(int[][] arr)
        {
            var sum0 = 0;
            var sum1 = 0;
            var sum0Index = 0;
            var sum1Index = arr.GetLength(0) - 1;

            for (var rows = 0; rows < arr.GetLength(0);rows++)
            {
                sum0 = sum0 + arr[rows][sum0Index];
                sum1 = sum1 + arr[rows][sum1Index];

                sum0Index++;
                sum1Index--;
            }

            return Math.Abs(sum0 - sum1);
        }
    }
}
