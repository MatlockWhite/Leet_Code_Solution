using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Valid Parenthesis Problem
 *      
 *      Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 *      
 *      An input string is valid if:
 *      
 *      Open brackets must be closed by the same type of brackets.
 *      Open brackets must be closed in the correct order.
 *      Every close bracket has a corresponding open bracket of the same type.
 * 
 *      Constraints
 *      1 <= s.Length <= 10^4
 *      s consists of parenthesis only
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    40.6%
 *      Submissions:        11.3 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 55ms
 *      Memory Efficiency:  39.6MB
 */

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class ValidParenthesis_CodingProblem
    {
        Stack<char> stack;

        public ValidParenthesis_CodingProblem()
        {
            stack = new Stack<char>();
        }

        public bool IsValid(string s)
        {
            stack = new Stack<char>(s.Length);
            foreach (char c in s)
            {
                if (c.Equals('}') || c.Equals(']') || c.Equals(')'))
                {
                    if (!EvaluateStack(c)) { return false; }
                }
                else
                {
                    stack.Push(c);
                }
            }

            if (stack.Contains('{') || stack.Contains('[') || stack.Contains('(')) { return false; }
            return true;
        }

        public bool EvaluateStack(char input)
        {
            char b = '0';
            switch (input)
            {
                case ']':
                    if (!stack.Contains('[')) { return false; }
                    b = stack.Pop();
                    while (stack.Count > 0 && b != '[')
                    {
                        if (b.Equals('{') || b.Equals('(')) { return false; }
                        b = stack.Pop();
                    }
                    break;
                case '}':
                    if (!stack.Contains('{')) { return false; }
                    b = stack.Pop();
                    while (stack.Count > 0 && b != '{')
                    {
                        if (b.Equals('[') || b.Equals('(')) { return false; }
                        b = stack.Pop();
                    }
                    break;
                case ')':
                    if (!stack.Contains('(')) { return false; }
                    b = stack.Pop();
                    while (stack.Count > 0 && b != '(')
                    {
                        if (b.Equals('{') || b.Equals('[')) { return false; }
                        b = stack.Pop();
                    }
                    break;
                default:
                    break;
            }

            return true;
        }
    }
}
