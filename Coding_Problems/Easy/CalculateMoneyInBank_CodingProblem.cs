using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Calculating Money in Bank
 *      
 *      Hercy wants to save money for his first car. He puts money in the Leetcode bank every day.
 *      
 *      He starts by putting in $1 on Monday, the first day. 
 *      Every day from Tuesday to Sunday, he will put in $1 more than the day before. 
 *      On every subsequent Monday, he will put in $1 more than the previous Monday.
 *      
 *      Given n, return the total amount of money he will have in the Leetcode bank at the end of the nth day.
 *      
 *      Constraints:
 *      1 <= n <= 1000
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    78.3%
 *      Submissions:        201.4K
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 28 ms
 *      Memory Efficiency:  26.75 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class CalculateMoneyInBank_CodingProblem
    {
        public CalculateMoneyInBank_CodingProblem() { }
        public int TotalMoney(int n)
        {
            int total_saved = 0;
            int current_payment = 0;
            int offset = 5;
            int count = 1;
            bool next = false;

            while (count <= n)
            {
                if (next)
                {
                    current_payment -= offset;
                    next = false;
                }
                else
                {
                    current_payment++;
                }

                total_saved += current_payment;
                if (count % 7 == 0)
                {
                    next = true;
                }

                count++;
            }
            return total_saved;
        }
    }
}
