using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 
 *      Converting an Integer to Roman Numeral Problem
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
 *      Roman numerals are formed by appending the conversions of decimal place values from highest to lowest. 
 *      Converting a decimal place value into a Roman numeral has the following rules:
 *      
 *      If the value does not start with 4 or 9, 
 *      select the symbol of the maximal value that can be subtracted from the input, 
 *      append that symbol to the result, subtract its value, and convert the remainder to a Roman numeral.
 *      
 *      If the value starts with 4 or 9,
 *      use the subtractive form representing one symbol subtracted from the following symbol, 
 *      for example, 4 is 1 (I) less than 5 (V): IV and 9 is 1 (I) less than 10 (X): IX. 
 *      
 *      Only the following subtractive forms are used: 4 (IV), 9 (IX), 40 (XL), 90 (XC), 400 (CD) and 900 (CM).
 *      Only powers of 10 (I, X, C, M) can be appended consecutively at most 3 times to represent multiples of 10. 
 *      
 *      You cannot append 5 (V), 50 (L), or 500 (D) multiple times. 
 *      
 *      If you need to append a symbol 4 times use the subtractive form.
 *      
 *      Given an integer, convert it to a Roman numeral.
 *      
 *      1 <= value given <= 3999
 *      
 *      LeetCode Statistics
 *      Difficulty:         Medium
 *      Acceptance Rate:    64.8%
 *      Submissions:        2 Million
 * 
 *      ** Note The following is using the Optimized Test Case **
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 55ms
 *      Memory Efficiency:  46.1MB
 */

namespace Leet_Code_Examples.Coding_Problems.Medium
{
    internal class IntegerToRoman_CodingProblem
    {
        public IntegerToRoman_CodingProblem() { }

        // First Pass at the problem.
        public string IntToRoman(int num)
        {
            // for this problem unlike the previous problem we will be using modulo. o(nlogn) tc
            string result = string.Empty;
            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            int index = values.Count() - 1;
            while (index >= 0 && num > 0)
            {
                for (int i = num / values[index]; i > 0; i--)
                {
                    result += EvaluateToRomanNumeral(values[index]);
                }

                num = num % values[index];
                index--;
            }

            return result;
        }

        // Second and more optimized method using O(n).
        public string OptimizedIntToRoman(int num)
        {

            // New Refined Solution using O(1) timecomplexity.
            string result = string.Empty;
            string[] singles = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM" };

            result = thousands[num / 1000] + hundreds[num % 1000 / 100] + tens[num % 100 / 10] + singles[num % 10];
            return result;
        }

        public string EvaluateToRomanNumeral(int num)
        {
            string c = string.Empty;
            switch (num)
            {
                case 1:
                    c = "I";
                    break;
                case 2:
                    c = "II";
                    break;
                case 3:
                    c = "III";
                    break;
                case 4:
                    c = "IV";
                    break;
                case 5:
                    c = "V";
                    break;
                case 6:
                    c = "VI";
                    break;
                case 7:
                    c = "VII";
                    break;
                case 8:
                    c = "VIII";
                    break;
                case 9:
                    c = "IX";
                    break;
                case 10:
                    c = "X";
                    break;
                case 40:
                    c = "XL";
                    break;
                case 50:
                    c = "L";
                    break;
                case 90:
                    c = "XC";
                    break;
                case 100:
                    c = "C";
                    break;
                case 400:
                    c = "CD";
                    break;
                case 500:
                    c = "D";
                    break;
                case 900:
                    c = "CM";
                    break;
                case 1000:
                    c = "M";
                    break;
                default:
                    break;
            }

            return c;
        }
    }
}
