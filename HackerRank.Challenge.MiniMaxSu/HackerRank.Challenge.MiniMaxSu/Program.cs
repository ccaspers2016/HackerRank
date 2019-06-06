using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenge.MiniMaxSu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArgs = new[] {256741038, 623958417, 467905213, 714532089, 938071625};
            int[] myArgs = new[] {1,2,3,4,5};

            miniMaxSum(myArgs);
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            int exception=0;
            double mySum;
            List<double> myList = new List<double>();
            List<double> answers = new List<double>();

            for (int i = 0; i < arr.Length; i++)
            {
                myList.Add(Convert.ToDouble(arr[i]));
            }

            double myListSum = myList.Sum();

            for (int x = 0; x < arr.Length; x++)
            {
                answers.Add(myListSum-myList[exception]);
                exception++;
            }

            Console.Write(Convert.ToInt64(answers.Min()));
            Console.Write(" ");
            Console.WriteLine(Convert.ToInt64(answers.Max()));


        }
    }
}
