using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRank.Practice.TheFullCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new List<List<string>>
            {
                new List<string> {"0 ab"},
                new List<string> {"6 cd"},
                new List<string> {"0 ef"},
                new List<string> {"6 gh"},
                new List<string> {"4 ij"},
                new List<string> {"0 ab"},
                new List<string> {"6 cd"},
                new List<string> {"0 ef"},
                new List<string> {"6 gh"},
                new List<string> {"0 ij"},
                new List<string> {"4 that"},
                new List<string> {"3 be"},
                new List<string> {"0 to"},
                new List<string> {"1 be"},
                new List<string> {"5 question"},
                new List<string> {"1 or"},
                new List<string> {"2 not"},
                new List<string> {"4 is"},
                new List<string> {"2 to"},
                new List<string> {"4 the"}
            };

            countSort(myArray);
        }

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

            BuildOutput(arr);
        }

        private static void BuildOutput(List<List<string>> arr)
        {
            foreach (var t in arr)
            {
                var split = t[0].Split();
                var output = split.ToList();
                if (output.Count>1)
                {
                    Console.Write(output[1] + " ");
                }
            }
        }


        private static void SortStrings(List<List<string>> arr)
        {
            for (var x = 0; x < arr.Count - 1; x++)
            {
                var split = arr[x][0].Split();
                int added = x + 1;
                var nextSplit = arr[added][0].Split();

                if (Convert.ToInt16(split[0]) <= Convert.ToInt16(nextSplit[0])) continue;

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
    }
}
