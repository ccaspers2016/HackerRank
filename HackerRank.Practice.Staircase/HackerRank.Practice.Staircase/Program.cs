using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Practice.Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            StringBuilder sb =new StringBuilder();
            var spaces = n - 1;
            var apersands = 1;

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < spaces; y++)
                {
                    sb.Append(" ");
                }

                for (int i = 0; i < apersands; i++)
                {
                    sb.Append("#");
                }

                sb.Append("\n");

                spaces--;
                apersands++;
            }

            Console.Write(sb.ToString());



        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 6;

            staircase(n);
        }
    }
}
