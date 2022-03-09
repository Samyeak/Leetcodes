using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LeetCodes.Problems
{

    /* Two Sum II - Input array is sorted
     Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

    The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

    Note:

        Your returned answers (both index1 and index2) are not zero-based.
        You may assume that each input would have exactly one solution and you may not use the same element twice.

    Example 1:

    Input: numbers = [2,7,11,15], target = 9
    Output: [1,2]
    Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

    Example 2:

    Input: numbers = [2,3,4], target = 6
    Output: [1,3]

    Example 3:

    Input: numbers = [-1,0], target = -1
    Output: [1,2]

 

    Constraints:

        2 <= nums.length <= 3 * 104
        -1000 <= nums[i] <= 1000
        nums is sorted in increasing order.
        -1000 <= target <= 1000

     */
    public class TwoSumSorted
    {
        public static int[] ExecuteBruteforce(int[] numbers, int targetSum)
        {
            int endIndex = numbers.Length;
            for (int i = 0; i < endIndex; i++)
            {
                for (int j = i + 1; j < endIndex; j++)
                {
                    if (numbers[i] + numbers[j] == targetSum)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
        public static int[] ExecuteTwoPointers(int[] numbers, int targetSum)
        {
            int startIndex = 0, endIndex = numbers.Length - 1;

            while (endIndex > startIndex)
            {
                int sum = numbers[startIndex] + numbers[endIndex];
                if (sum == targetSum)
                {
                    return new int[] { startIndex, endIndex };
                }
                else if (sum > targetSum)
                {
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            return new int[] { };
        }

        public static int[] ExecuteBinarySearch(int[] numbers, int targetSum)
        {
            int startIndex = 0, endIndex = numbers.Length - 1;

            while (endIndex > startIndex)
            {
                int sum = numbers[startIndex] + numbers[endIndex];
                if (sum == targetSum)
                {
                    return new int[] { startIndex, endIndex };
                }
                else if (sum > targetSum)
                {
                    endIndex = (startIndex + endIndex) / 2;
                }
                else if((startIndex + endIndex) > 1)
                {
                    startIndex = (startIndex + endIndex) / 2;
                }
                else
                {
                    return new int[] { };
                }
            }
            return new int[] { };
        }

        public static int[] ExecuteDictionary(int[] numbers, int targetSum)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int secondNumber = targetSum - numbers[i];
                if (dictionary.ContainsKey(secondNumber))
                    return new int[] { dictionary[secondNumber], i };
                if (!dictionary.ContainsKey(numbers[i]))
                    dictionary.Add(numbers[i], i);
            }

            return new int[] { };
        }

    }
}
