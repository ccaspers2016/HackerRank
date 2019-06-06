using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.SimpleArraySum
{
    class Program
    {
        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar)
        {
            return ar.Sum();
        }

        static void Main(string[] args)
        {
            int[] ar = new int[]{1,2,3,4,10,11};
            int result = simpleArraySum(ar);
            Console.WriteLine(result);

        }
    }
}
