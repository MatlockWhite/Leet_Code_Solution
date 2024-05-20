using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      N-Queens II
 *      
 *      The n-queens puzzle is the problem of placing n queens on an n x n 
 *      chessboard such that no two queens attack each other.
 *      
 *      Given an integer n, return the number of distinct solutions to the n-queens puzzle.
 *      
 *      Constraints:
 *      1 <= x <= 9
 *      
 *      LeetCode Statistics
 *      Difficulty:         Hard
 *      Acceptance Rate:    74.0%
 *      Submissions:        522.5K
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 25 ms
 *      Memory Efficiency:  27.3 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Hard
{
    internal class NQueensII_CodingProblem
    {
        public NQueensII_CodingProblem() { }

        public int TotalNQueens(int n)
        {
            return NQueens(n, 0, new List<int>(), new List<int>(), new List<int>());
        }

        public int NQueens(int n, int row, List<int> forwardDiag, List<int> reverseDiag, List<int> cols)
        {
            if (row.Equals(n)) { return 1; }

            int result = 0;
            for (int col = 0; col < n; col++)
            {
                int fD = row - col;
                int rD = row + col;

                if (cols.Contains(col) || forwardDiag.Contains(fD) || reverseDiag.Contains(rD))
                {
                    // This is a non-valid space should continue.
                    continue;
                }

                // Add the queen to the cols and diagonal spaces.
                cols.Add(col);
                forwardDiag.Add(fD);
                reverseDiag.Add(rD);

                // use Recursion to Re-evaluate with the given params
                result += NQueens(n, row + 1, forwardDiag, reverseDiag, cols);

                //Remove the queens before proceeding that way we can check each columns space for the queen
                cols.Remove(col);
                forwardDiag.Remove(fD);
                reverseDiag.Remove(rD);
            }

            return result;
        }
    }
}
