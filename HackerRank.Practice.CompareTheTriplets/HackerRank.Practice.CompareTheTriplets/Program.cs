using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Practice.CompareTheTriplets
{
    class Program
    {
        static void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH") ?? throw new InvalidOperationException(), true);

            var a = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            var b = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            var result = CompareTriplets(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        private static IEnumerable<int> CompareTriplets(IReadOnlyList<int> a, IReadOnlyList<int> b)
        {
            var result = new List<int> { 0, 0 };

            for (int x = 0; x < a.Count; x++)
            {
                if (a[x] > b[x])
                {
                    result[0]++;
                }
                else
                {
                    if (a[x] < b[x])
                    {
                        result[1]++;
                    }
                }
            }

            return result;
        }
    }
}
