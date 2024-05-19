using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Trapping Rainwater Problem
 *      
 *      Given n non-negative integers representing an elevation map where the width of each bar is 1, 
 *      compute how much water it can trap after raining.
 *      
 *      Constraints
 *      n == height.length
 *      1 <= n <= 2 * 10^4
 *      0 <= height[i] <= 10^5
 *      
 *      LeetCode Statistics
 *      Difficulty:         Hard
 *      Acceptance Rate:    62.0%
 *      Submissions:        3.4 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 93 ms
 *      Memory Efficiency:  46.5 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Hard
{
    internal class TrappingRainWater_CodingProblem
    {
        public TrappingRainWater_CodingProblem() { }

        public int Trap(int[] height)
        {
            //Get the max value from the array this will be our highest peak
            List<int> blocks = height.ToList();
            int totalWaterCollected = 0;

            int highestPeak = blocks.Max();

            // The Following will determine a Column by Column Solution reducing the complexity initally stated in our Row by Row Solution
            int[] leftValue = new int[height.Count()];
            int[] rightValue = new int[height.Count()];
            int heightLeft = 0;
            int heightRight = 0;
            int indexLeft = 0;
            int indexRight = height.Count() - 1;

            // Establish the highest values for left and right indexes on a given index.
            while (indexRight >= 0)
            {
                heightLeft = Math.Max(heightLeft, height[indexLeft]);
                heightRight = Math.Max(heightRight, height[indexRight]);
                leftValue[indexLeft] = heightLeft;
                rightValue[indexRight] = heightRight;
                indexLeft++;
                indexRight--;
            }

            for (int i = 0; i < blocks.Count() - 1; i++)
            {
                int minValue = Math.Min(leftValue[i], rightValue[i]);
                if (minValue >= height[i])
                {
                    totalWaterCollected += minValue - height[i];
                }
            }

            return totalWaterCollected;
        }
    }
}
