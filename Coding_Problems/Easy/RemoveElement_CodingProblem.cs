using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Remove Element
 *      
 *      Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
 *      The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
 *      
 *      Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
 *      
 *      Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
 *      The remaining elements of nums are not important as well as the size of nums.
 *      
 *      Return k.
 *      
 *      
 *      Constraints:
 *      0 <= nums.length <= 100
 *      0 <= nums[i] <= 50
 *      0 <= val <= 100
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    56.9%
 *      Submissions:        5.1 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 98 ms
 *      Memory Efficiency:  45.5 MB
 */

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class RemoveElement_CodingProblem
    {
        public RemoveElement_CodingProblem() { }

        public int RemoveElement(int[] nums, int val)
        {
            List<int> resultList = nums.ToList();
            resultList.RemoveAll(x => x.Equals(val));
            for (int i = 0; i < resultList.Count(); i++)
            {
                nums[i] = resultList[i];
            }
            return resultList.Count();
        }
    }
}
