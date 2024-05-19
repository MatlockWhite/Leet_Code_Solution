using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 *              Max Area of a Container Problem
 * 
 * 
 * 
 * You are given an integer array height of length n. 
 * There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
 * Find two lines that together with the x-axis form a container, such that the container contains the most water.
 * Return the maximum amount of water a container can store.
 * 
 *      LeetCode Statistics
 *      Difficulty:         Medium
 *      Acceptance Rate:    55.3%
 *      Submissions:        5.3 Million
 *      
 *      
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 276ms
 *      Memory Efficiency:  54.9MB
 */

namespace Leet_Code_Examples.Coding_Problems.Medium
{
    internal class MaxArea_CodingProblem
    {
        public MaxArea_CodingProblem() { }

        public int MaxArea(int[] height)
        {
            // Find the area base * height
            int leftIndex = 0;
            int rightIndex = height.Count() - 1;
            int leftValue = 0;
            int rightValue = 0;
            int total = 0;
            int maxValue = 0;
            List<int> values = new List<int>();

            while (leftIndex < rightIndex && leftIndex < height.Count() - 1 && rightIndex > 0)
            {
                // Need to evaluate depending on if the left most value is lower or the rightmost value
                leftValue = height[leftIndex];
                rightValue = height[rightIndex];
                total = 0;

                if (leftValue > rightValue)
                {
                    // We need to decrement the rightIndex and find the Area of the given setup
                    total = rightValue * (rightIndex - leftIndex);
                    rightIndex--;
                }
                else
                {
                    total = leftValue * (rightIndex - leftIndex);
                    leftIndex++;
                }

                values.Add(total);
                maxValue = Math.Max(maxValue, total);
            }

            maxValue = Math.Max(maxValue, values.Max());

            if (maxValue.Equals(0) && leftIndex < height.Count() - 1 && rightIndex > 0 && height[leftIndex] > 0 && height[rightIndex] > 0)
            {
                maxValue = Math.Min(height[leftIndex], height[rightIndex]);
            }

            return maxValue;
        }
    }
}
