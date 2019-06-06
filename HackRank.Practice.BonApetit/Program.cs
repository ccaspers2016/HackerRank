using System;
using System.Collections.Generic;
using System.Linq;

namespace HackRank.Practice.BonApetit
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = 1;  //not shared item
            var b = 7;  //Amount charged Ann
            var bill = new List<int> {3, 10, 2, 9};

            bonAppetit(bill, k, b);
        }
        static void bonAppetit(List<int> bill, int k, int b)
        {
            double billSum = 0;
            foreach (var i in bill) billSum = billSum + i;

            var sharedItems = (billSum - bill[k])/2;


            if (b > sharedItems)
            {
                Console.Write(b-sharedItems);
            }
            else
            {
                Console.Write("Bon Appetit");
            }
        }
    }
}
