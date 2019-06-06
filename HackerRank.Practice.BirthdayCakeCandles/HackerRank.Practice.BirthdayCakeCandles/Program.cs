using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new []{3,2,1,3};
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
        }

        private static int birthdayCakeCandles(int[] ar)
        {
            int result = 0;

            var highest = ar.Max();
            result = ar.Count(x => x == highest);





            return result;
        }
    }
}
