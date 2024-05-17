using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *      Best Pricing Problem
 *      
 *      You are given an array prices where prices[i] is the price of a given stock on the ith day.
 *      You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
 *      Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
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

namespace Best_Pricing_Problem
{
    internal class BestPricing_CodingProblem
    {
        public BestPricing_CodingProblem() { }

        public int MaxProfit(int[] prices)
        {
            int highestProfit = 0;
            int minPrice = prices[0];
            for (int i = 1; i < prices.Count(); i++)
            {
                highestProfit = Math.Max(highestProfit, prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }

            return highestProfit;
        }
    }
}
