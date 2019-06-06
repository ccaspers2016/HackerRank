using System;
using System.Collections.Generic;
using System.Linq;

namespace HackRank.Practice.TheFullCountingSort
{
    public class Solution
    {

        // Complete the countSort function below.
        static void countSort(List<List<string>> arr)
        {
            var middle = Math.Truncate((decimal)arr.Count / 2);

            //Trim lines
            foreach (var t in arr)
            {
                t[0].TrimEnd();
            }

            //Replace string portion with Dash for first half of array list (silly but there it is)
            ReplaceToDashes(arr, middle);

            //Sort this stuff
            SortStrings(arr);

            Console.WriteLine(BuildOutput(arr));
        }


        private static string BuildOutput(List<List<string>> arr)
        {
            //Output
            var sb = string.Empty;

            foreach (var t in arr)
            {
                var split = t[0].Split(' ');
                if (split.Length > 1)
                {
                    sb = sb + split[1] + " ";
                }
            }

            var result = sb.TrimEnd();
            return result;
        }

        private static void SortStrings(List<List<string>> arr)
        {
            for (var x = 0; x < arr.Count - 1; x++)
            {
                var split = arr[x][0].Split();
                int added = x + 1;
                var nextSplit = arr[added][0].Split(' ');

                if (Convert.ToInt32(split[0]) <= Convert.ToInt32(nextSplit[0])) continue;

                //Swap
                var temp = arr[x][0];
                arr[x][0] = arr[added][0];
                arr[added][0] = temp;
                x = -1;
            }
        }

        private static void ReplaceToDashes(List<List<string>> arr, decimal middle)
        {
            for (var x = 0; x < middle; x++)
            {
                var split = arr[x][0].Split();
                if (split.Length > 1)
                {
                    split[1] = "-";
                    arr[x][0] = split[0] + " " + split[1] + " ";
                }
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<string>> arr = new List<List<string>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
            }

            countSort(arr);
        }
    }
}