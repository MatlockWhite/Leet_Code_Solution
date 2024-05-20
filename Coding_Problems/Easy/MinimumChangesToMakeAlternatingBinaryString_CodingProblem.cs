using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Minimum Changes to Make Alternating Binary String
 *      
 *      You are given a string s consisting only of the characters '0' and '1'. In one operation, 
 *      you can change any '0' to '1' or vice versa.
 *      
 *      The string is called alternating if no two adjacent characters are equal. 
 *      For example, the string "010" is alternating, while the string "0100" is not.
 *      
 *      Return the minimum number of operations needed to make s alternating.
 *      
 *   
 *      Constraints:
 *     1 <= s.length <= 10^4
 *     s[i] is either '0' or '1'
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    63.8%
 *      Submissions:        224.3K
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 1906 ms
 *      Memory Efficiency:  43.1 MB
 */

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class MinimumChangesToMakeAlternatingBinaryString_CodingProblem
    {
        public MinimumChangesToMakeAlternatingBinaryString_CodingProblem() { }
        public int MinOperations(string s)
        {
            // There is 2 cases either the beginning value is zero or the beginning value is one
            int zeroStartChanges = 0;
            int oneStartChanges = 0;
            for (int i = 0; i < s.Count(); i++)
            {
                if ((i % 2).Equals(0))
                {
                    if (s[i].Equals('0')) { oneStartChanges++; }
                    else { zeroStartChanges++; }
                }
                else
                {
                    if (s[i].Equals('1')) { oneStartChanges++; }
                    else { zeroStartChanges++; }
                }
            }

            return Math.Min(oneStartChanges, zeroStartChanges);
        }
    }
}
