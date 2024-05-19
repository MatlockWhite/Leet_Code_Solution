using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 *      Integer to Roman Numeral Problem
 *      
 *      Seven different symbols represent Roman numerals with the following values:
 *      Symbol	Value
 *      I	1
 *      V	5
 *      X	10
 *      L	50
 *      C	100
 *      D	500
 *      M   1000
 *      
 *      For example, 2 is written as II in Roman numeral, just two ones added together. 
 *      12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
 *      
 *      Roman numerals are usually written largest to smallest from left to right. 
 *      However, the numeral for four is not IIII. Instead, the number four is written as IV. 
 *      Because the one is before the five we subtract it making four. 
 *      The same principle applies to the number nine, which is written as IX. 
 *      There are six instances where subtraction is used:
 *      
 *      I can be placed before V (5) and X (10) to make 4 and 9. 
 *      X can be placed before L (50) and C (100) to make 40 and 90. 
 *      C can be placed before D (500) and M (1000) to make 400 and 900.
 *      
 *      Given a roman numeral, convert it to an integer.
 *      
 *      1 <= value given <= 3999
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    61.3%
 *      Submissions:        5.9 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 54ms
 *      Memory Efficiency:  48.8MB
 */



namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class RomanToInteger_CodingProblem
    {
        public RomanToInteger_CodingProblem() { }

        public int RomanToInt(string s)
        {
            int total = 0;
            int prev = 0;

            for (int i = s.Count() - 1; i >= 0; i--)
            {
                int curr = GetValue(s.ElementAt(i));
                if (prev > curr)
                {
                    total -= curr;
                    prev = curr;
                }
                else
                {
                    total += curr;
                    prev = curr;
                }
            }

            return total;
        }

        public int GetValue(char letter)
        {
            int value = 0;
            switch (letter)
            {
                case 'I':
                    value = 1;
                    break;
                case 'V':
                    value = 5;
                    break;
                case 'X':
                    value = 10;
                    break;
                case 'L':
                    value = 50;
                    break;
                case 'C':
                    value = 100;
                    break;
                case 'D':
                    value = 500;
                    break;
                case 'M':
                    value = 1000;
                    break;
                default:
                    break;
            }

            return value;
        }
    }
}
