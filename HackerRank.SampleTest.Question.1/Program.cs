﻿using System;
using System.Collections.Generic;

namespace HackerRank.SampleTest.Question._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 2, 3, 1, 5 };
            int k =6;
            findNumber(arr, k);
        }
        static string findNumber(List<int> arr, int k)
        {
            var outputString = "NO";

            foreach (var t in arr)
            {
                if (t == k)
                {
                    outputString = "YES";
                }
            }

            Console.WriteLine(outputString);

            return outputString;
        }
    }
}