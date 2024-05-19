using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Remove Duplicate From Sorted Array
 *      
 *      Given an integer array nums sorted in non-decreasing order, 
 *      remove the duplicates in-place such that each unique element appears only once. 
 *      The relative order of the elements should be kept the same. 
 *      Then return the number of unique elements in nums.
 *      
 *      Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
 *      
 *      Change the array nums such that the first k elements of nums contain the unique elements 
 *      in the order they were present in nums initially. The remaining elements of nums are not 
 *      important as well as the size of nums.
 *      
 *      Return k.
 *      
 *      Constraints:
 *      1 <= nums.length <= 3* 10^4
 *      -100 <= nums[i] <= 100
 *      nums is sorted in non-decreasing order.
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    55.8%
 *      Submissions:        7.8 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 126ms
 *      Memory Efficiency:  50.7MB
 */

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class RemoveDuplicatesFromSortedArray_CodingProblem
    {
        public RemoveDuplicatesFromSortedArray_CodingProblem() { }

        public int RemoveDuplicates(int[] nums)
        {

            Dictionary<int, int> numDictionary = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (numDictionary.ContainsKey(i))
                {
                    numDictionary[i]++;
                }
                else
                {
                    numDictionary.Add(i, 1);
                }
            }

            int index = 0;
            foreach (var key in numDictionary)
            {
                int count = 0;
                for (int i = 0; i < key.Value; i++)
                {
                    if (count < 1)
                    {
                        nums[index] = key.Key;
                        count++;
                        index++;
                    }
                }
            }

            return index;
        }
    }
}
