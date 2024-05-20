using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Candy
 *      
 *      There are n children standing in a line. 
 *      Each child is assigned a rating value given in the integer array ratings.
 *      
 *      You are giving candies to these children subjected to the following requirements:
 *      
 *      Each child must have at least one candy.
 *      Children with a higher rating get more candies than their neighbors.
 *      Return the minimum number of candies you need to have to distribute the candies to the children.
 *      
 *      Constraints:
 *      n == ratings.length
 *      1 <= n <= 2 * 10^4
 *      0 <= rating[i] <= 2 * 10^4
 *      
 *      LeetCode Statistics
 *      Difficulty:         Hard
 *      Acceptance Rate:    43.3%
 *      Submissions:        1.2 Million
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 111 ms
 *      Memory Efficiency:  46.9 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Hard
{
    internal class Candy_CodingProblem
    {
        public Candy_CodingProblem() { }

        public int Candy(int[] ratings)
        {
            int total = 0;
            int[] resultingCandies = new int[ratings.Count()];
            if (ratings.Count() < 2) { return ratings.Count(); }
            if (ratings.Count().Equals(2))
            {
                if (ratings[0].Equals(ratings[1])) { return 2; }
                return 3;
            }

            for (int i = 0; i < resultingCandies.Count(); i++)
            {
                resultingCandies[i] = 1;
            }

            for (int i = 1; i < ratings.Count(); i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    resultingCandies[i] = resultingCandies[i - 1] + 1;
                }
            }

            for (int i = ratings.Count() - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    resultingCandies[i] = Math.Max(resultingCandies[i], resultingCandies[i + 1] + 1);
                }
            }

            total = resultingCandies.Sum(x => x);
            return total;
        }
    }
}
