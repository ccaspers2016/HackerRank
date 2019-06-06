using System;
using System.Linq;

namespace HackerRank.Practice.RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = repeatedString("a", 1000000000000);
            var result = repeatedString("aba", 10);
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long result = 0;
            decimal multiply = (Math.Floor(Convert.ToDecimal(n)/s.Length));

            long count = s.Where((t, x) => s.Substring(x, 1) == "a").Count();

            result = (long) (count * multiply);

            var remainder = Convert.ToInt16(n - (s.Length * multiply));
            var remainderString = s.Substring(0, remainder);

            count = 0;
            for (var y = 0; y < remainderString.Length; y++)
            {
                if (s.Substring(y, 1) == "a")
                {
                    count++;
                }
            }

            result = result + count;

            Console.Write(result);

            return result;
        }
    }
}

