using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes.Problems
{
    /*
     * 1. Two Sum

        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Output: Because nums[0] + nums[1] == 9, we return [0, 1].

        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]

        Example 3:

        Input: nums = [3,3], target = 6
        Output: [0,1]

        Constraints:

            2 <= nums.length <= 105
            -109 <= nums[i] <= 109
            -109 <= target <= 109
        Only one valid answer exists.
     */
    public class TwoSum
    {
        public static int[] Execute(int[] input, int sum)
        {
            Console.WriteLine("Let the party start");

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == sum)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }

        public static int[] ExecuteWithHashTable(int[] input, int sum)
        {
            Dictionary<int,int> dictionary = new Dictionary<int, int>(input.Length);
            for(int i = 0; i < input.Length; i++)
            {
                int secondNumber = sum - input[i];
                if (dictionary.ContainsKey(secondNumber))
                {
                    return new int[] { i, dictionary[secondNumber]};
                }
                dictionary.Add(input[i], i);
            }

            return new int[] { };
        }
    }
}
