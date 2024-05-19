using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *      Find The First Occurance in a String
 *      
 *      Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, 
 *      or -1 if needle is not part of haystack.
 *      
 *      
 *      Constraints:
 *      1 <= Haystack.length, needle.length <= 10^4
 *      Haystack and needle characters consist of only lowercase characters
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    42.4%
 *      Submissions:        5.8 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 45 ms
 *      Memory Efficiency:  39.5 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class FindTheFirstOccurance_CodingProblem
    {
        public FindTheFirstOccurance_CodingProblem() { }

        public int StrStr(string haystack, string needle)
        {
            int index = -1;
            if (haystack.Contains(needle))
            {
                index = haystack.IndexOf(needle);
            }

            return index;
        }
    }
}
