using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    /*
     *      Largest 3-Same-Digit Number In a String
     *      
     *      You are given a string num representing a large integer. An integer is good if it meets the following conditions:
     *      
     *      It is a substring of num with length 3.
     *      It consists of only one unique digit.
     *      Return the maximum good integer as a string or an empty string "" if no such integer exists.
     *      
     *      Note:
     *      
     *      A substring is a contiguous sequence of characters within a string.
     *      There may be leading zeroes in num or a good integer.
     *      
     *      Constraints:
     *      3 <= num.length <= 1000
     *      num only consists of Digits
     *      
     *      LeetCode Statistics
     *      Difficulty:         Easy
     *      Acceptance Rate:    69.0%
     *      Submissions:        207.8K
     * 
     *      Personal Statistics (Using Leetcode Testcases)
     *      Runtime Efficiency: 56 ms
     *      Memory Efficiency:  39.33 MB
     */

    internal class LargestThreeSameDigitNumberInString_CodingProblem
    {
        public LargestThreeSameDigitNumberInString_CodingProblem() { }

        /// <summary>
        /// For this problem since there is a finite value of possible outcomes I decided to try and reduce the Time complexity
        /// As well as the Memory Complexity as much as possible. 
        /// 
        /// By using this literal interpretation and not using a switch statement or a forloop and string conversion
        /// I was able to successfully beat out 98% of all other submissions resulting in one of the top spots in terms 
        /// of Time Complexity and Memory Complexity for this problem.
        /// 
        /// </summary>
        /// <param name="num">The input string that may or maynot contain 3 sequential numbers</param>
        /// <returns>The string of the largest 3 numbers</returns>
        public string LargestGoodInteger(string num)
        {
            if (num.Contains("999")) { return "999"; }
            else if (num.Contains("888")) { return "888"; }
            else if (num.Contains("777")) { return "777"; }
            else if (num.Contains("666")) { return "666"; }
            else if (num.Contains("555")) { return "555"; }
            else if (num.Contains("444")) { return "444"; }
            else if (num.Contains("333")) { return "333"; }
            else if (num.Contains("222")) { return "222"; }
            else if (num.Contains("111")) { return "111"; }
            else if (num.Contains("000")) { return "000"; }

            return "";
        }
    }
}
