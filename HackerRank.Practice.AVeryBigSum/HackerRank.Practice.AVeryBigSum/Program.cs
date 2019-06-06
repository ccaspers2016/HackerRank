using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //long result = aVeryBigSum(ar);
        }

        private static long aVeryBigSum(long[] ar)
        {
            return ar.Aggregate<long, long>(0, (current, t) => current + t);
        }
    }
}
