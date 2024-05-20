using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Buy 2 Chocolates Coding Problem
 *      
 *      You are given an integer array prices representing the prices of various chocolates in a store. 
 *      You are also given a single integer money, which represents your initial amount of money.
 *      
 *      You must buy exactly two chocolates in such a way that you still have some non-negative leftover money. 
 *      You would like to minimize the sum of the prices of the two chocolates you buy.
 *      
 *      Return the amount of money you will have leftover after buying the two chocolates. 
 *      If there is no way for you to buy two chocolates without ending up in debt, return money. 
 *      Note that the leftover must be non-negative.
 *      
 *      Constraints:
 *      2 <= prices.length <= 50
 *      1 <= prices[i] <= 100
 *      1 <= money <= 100
 *      
 *      LeetCode Statistics
 *      Difficulty:         Easy
 *      Acceptance Rate:    69.4 %
 *      Submissions:        253.3K
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 71 ms
 *      Memory Efficiency:  47.1 MB
 */

namespace Leet_Code_Examples.Coding_Problems.Easy
{
    internal class BuyTwoChocolates_CodingProblem
    {
        public BuyTwoChocolates_CodingProblem() { }

        public int BuyChoco(int[] prices, int money)
        {
            if (prices.Count() < 2) { return money; }

            Array.Sort(prices);
            if (prices[0] + prices[1] <= money) { return money - prices[0] - prices[1]; }

            return money;
        }
    }
}
