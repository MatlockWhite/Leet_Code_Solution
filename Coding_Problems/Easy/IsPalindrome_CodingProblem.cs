using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Is Palindrom Problem
 *      
 *      Given an integer x, return true if x is a palindrome, and false otherwise.
 *      
 *      Constraints:
 *      -2^31 <= x <= 2^31 - 1
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    54.6%
 *      Submissions:        8.2 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 53 ms
 *      Memory Efficiency:  37.8 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class IsPalindrome_CodingProblem
    {
        public IsPalindrome_CodingProblem() { }

        public bool IsPalindrome(int x)
        {
            string s = x.ToString();
            for (int i = 0; i < s.Count() / 2; i++)
            {
                if (s[s.Count() - 1 - i] != s[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
