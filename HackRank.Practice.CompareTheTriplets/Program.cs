using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HackRank.Practice.CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> {0, 0};

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
