using System.Collections;

namespace LeetCode._1365_how_many_numbers_are_smaller_than_the_current_number
{
    public class HMNASTCN
    {
        public int[] testNumbers(int[] nums)
        {
            var result = new int[nums.Length];
            for (var currentIndexToBeTested = 0; currentIndexToBeTested < nums.Length; currentIndexToBeTested++)
            {
                var currentMainlyValue = nums[currentIndexToBeTested];
                var repeatTimes = 0;
                for (var indexToBeTestedWith = 0; indexToBeTestedWith < nums.Length; indexToBeTestedWith++)
                {
                    var currentTestValue = nums[indexToBeTestedWith];
                    if (currentIndexToBeTested == indexToBeTestedWith) continue;
                    if (currentTestValue < currentMainlyValue)
                    {
                        repeatTimes++;
                    }

                    result[currentIndexToBeTested] = repeatTimes;
                }
            }
            return result;
        }
    }
}