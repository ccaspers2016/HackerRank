using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace HackRank.Practice.DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 60113;   //number of pages in book
            int p = 8589;    //Page to turn to

            var result = pageCount(n,p);

        }


        static int pageCount(int n, int p)
        {
            //Front to back
            //n=2 then result = 1
            //n=3 then result = 1
            //n=4 then result = 2
            //n=5 then result = 2
            //n=6 then result = 3
            //n=7 then result = 3
            var turns = 0;
            var forward = 0;
            for (int x = 0; x <= n; x++)
            {
                if (p >= x && p <= (x + 1))
                {
                    break;
                }

                forward++;

                x++;
            }

            int backward = 0;

            int nn = n;
            if (n % 2 == 0){
                nn = n + 1;
            }

            for (var y = nn; y >=0; y--)
            {
                if (p >= y-1 && p <= y)
                {
                    break;
                }

                backward++;

                y--;
            }

            turns = forward;
            if (forward > backward)
            {
                turns = backward;

            }

            Console.Write(turns);

            return turns;

        }
    }
}
