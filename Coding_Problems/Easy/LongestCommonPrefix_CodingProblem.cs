using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    /*
     * 
     *      Longest Common Prefix Problem
     * 
     * 
     *  Write a function to find the longest common prefix string amongst an array of strings.
     * 
     *  If there is no common prefix, return an empty string "".
     *  
     *
     *      LeetCode Statistics
     *      Difficulty:         Easy
     *      Acceptance Rate:    42.8%
     *      Submissions:        7.7 Million
     *      
     *      
     *      Personal Statistics (Using Leetcode Testcases)
     *      Runtime Efficiency: 124ms
     *      Memory Efficiency:  43.6MB
     */

    internal class LongestCommonPrefix_CodingProblem
    {
        public LongestCommonPrefix_CodingProblem() { }

        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            if (strs.Length < 1) {  return result; }
            for (int i = 0; i < strs[0].Length; i++)
            {
                if (strs.Any(x => x.Length - 1 < i || x.Length > i && x.ElementAt(i) != strs[0].ElementAt(i)))
                {
                    return result;
                }
                else
                {
                    result += strs[0].ElementAt(i);
                }
            }
            return result;
        }
    }
}
