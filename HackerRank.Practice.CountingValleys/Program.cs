using System;

namespace HackerRank.Practice.CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = countingValleys(8, "UDDDUDUU");
        }

        static int countingValleys(int n, string s)
        {
            int result = 0;
            bool mountainFlag = false;
            bool valleyFlag = false;
            int walkHeight = 0;

            for (var x = 0; x < n; x++)
            {
                var checkString = s.Substring(x, 1);

                switch (checkString)
                {
                    case "U":
                    {
                        if (walkHeight == 0 && valleyFlag == false)
                        {
                            mountainFlag = true;
                        }
                        walkHeight++;
                        break;
                    }

                    case "D":
                    {
                        if (walkHeight == 0 && mountainFlag == false)
                        {
                            valleyFlag = true;
                        }
                        walkHeight--;
                        break;
                    }
                }

                if (valleyFlag & walkHeight == 0)
                {
                    result++;
                    valleyFlag = false;
                }

                if (mountainFlag & walkHeight == 0)
                {
                    mountainFlag = false;
                }

            }

            Console.WriteLine(result);
            return result;
        }
    }
}
