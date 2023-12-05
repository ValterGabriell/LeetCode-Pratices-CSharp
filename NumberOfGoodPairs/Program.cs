using System;
using System.Collections;
using LeetCode._1365_how_many_numbers_are_smaller_than_the_current_number;
using LeetCode._1512_NumberofGoodPairs;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hmnastcn = HMNASTCN();
            string[] toString = Array.ConvertAll(hmnastcn, value => value.ToString());
            string array = string.Join(",", toString);
            Console.WriteLine(array);
        }

        public static int NumberOfGoodPairs()
        {
            var numberOfGoodPais = new NumberOfGoodPairs();
            var array = new[] { 1, 2, 3 };
            var numIdenticalPairs = numberOfGoodPais.NumIdenticalPairs(array);
            return numIdenticalPairs;
        }

        public static int[] HMNASTCN()
        {
            var hmn = new HMNASTCN();
            var array = new[] { 8,1,2,2,3 };
            return hmn.testNumbers(array);
        }
    }
}