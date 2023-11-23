using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._1512_NumberofGoodPairs
{
    public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var countByValue = new Dictionary<int, int>();
            var goodPairs = 0;

            foreach (var num in nums)
            {
                if (countByValue.ContainsKey(num))
                {
                    goodPairs += countByValue[num];
                    countByValue[num]++;
                }
                else
                {
                    countByValue[num] = 1;
                }
            }

            return goodPairs;
        }
    }
}