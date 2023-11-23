using System;
using LeetCode._1512_NumberofGoodPairs;

namespace LeetCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numberOfGoodPairs = NumberOfGoodPairs();
            Console.WriteLine("Numeros de pares bons: " + numberOfGoodPairs);
        }

        public static int NumberOfGoodPairs()
        {
            var numberOfGoodPais = new NumberOfGoodPairs();
            var array = new[] { 1,2,3};
            var numIdenticalPairs = numberOfGoodPais.NumIdenticalPairs(array);
            return numIdenticalPairs;
        }
    }
}