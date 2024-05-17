using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 *      Zig-Zag Conversion Problem
 * 
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
 * NOTE: (you may want to display this pattern in a fixed font for better legibility)
 * 
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * And then read line by line: "PAHNAPLSIIGYIR"
 * 
 * Write the code that will take a string and make this conversion given a number of rows:
 * 
 * string convert(string s, int numRows);
 * 
 * 
 *      LeetCode Statistics
 *      Difficulty:         Medium
 *      Acceptance Rate:    48.0%
 *      Submissions:        2.8 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 505ms
 *      Memory Efficiency:  105.4MB
 */

namespace Leet_Code_Solution.Coding_Problems
{
    internal class ZigZagConversion_CodingProblem
    {
        public ZigZagConversion_CodingProblem() { }

        // The following is the first pass
        public string Convert(string s, int numRows)
        {
            // Note this way is terrible in terms of Efficiency for the problem.
            // It does have potential for robust expansion unlike the optimal solution found at the bottom.
            int rowOffset = 0;
            int rowValue = 1;
            string result = String.Empty;
            Dictionary<int, List<string>> rows = new Dictionary<int, List<string>>();

            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new List<string>();
            }

            for (int i = 0; i < s.Count(); i++)
            {
                rows[rowOffset].Add(s.ElementAt(i).ToString());
                if (numRows > 1)
                {
                    if (rowOffset + rowValue < 0)
                    {
                        rowValue = 1;
                    }
                    else if (rowOffset + rowValue >= numRows)
                    {
                        rowValue = -1;
                    }

                    rowOffset += rowValue;
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                foreach (var j in rows[i])
                {
                    result += j.ToString();
                }
            }

            return result;
        }

        // The following is a more optimized way
        public string Optimized(string s, int numRows)
        {
            string result = String.Empty;
            int offset = numRows * 2 - 2;

            if (numRows <= 1 || numRows >= s.Count()) { return s; }
            for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
            {
                for (int stringIndex = rowIndex; stringIndex < s.Count(); stringIndex += offset)
                {
                    result += s.ElementAt(stringIndex).ToString();
                    if (rowIndex != 0 && rowIndex != numRows - 1 && stringIndex + offset - 2 * rowIndex < s.Count())
                    {
                        result.Remove(result.Count() - 1);
                        result += s.ElementAt(stringIndex + offset - 2 * rowIndex).ToString();
                    }
                }
            }
            return result;
        }
    }
}
