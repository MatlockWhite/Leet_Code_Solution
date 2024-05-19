using Leet_Code_Examples.Coding_Problems.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Solution.Test_Cases
{
    [TestClass]
    internal class MaxArea_TestCase
    {
        public MaxArea_TestCase() { }

        private void OutputValue(List<int[]> arrays, string methodName)
        {
            MaxArea_CodingProblem maxAreaContainer = new MaxArea_CodingProblem();

            BestPricing_CodingProblem bestPricing = new BestPricing_CodingProblem();
            Stopwatch s = new Stopwatch();
            for (int i = 0; i < arrays.Count; i++)
            {
                s.Restart();
                s.Start();
                Console.WriteLine($"The result for {methodName} array at index {i} result is: {maxAreaContainer.MaxArea(arrays[i])} units, Time to complete is: {s.Elapsed}");
                s.Stop();
            }
        }


        [TestMethod]
        public void FullTest()
        {

            List<int[]> arrays = new List<int[]>();

            arrays.Add(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            arrays.Add(new[] { 1, 1 });
            arrays.Add(new[] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 });
            arrays.Add(new[] { 123, 123, 1, 23, 123, 12, 31, 23, 123, 1, 23, 123, 12, 31, 23, 124, 1, 4, 143, 15, 245, 3, 6542, 34, 1234, 1, 231, 23, 15, 4325, 3, 123, 1, 23, 5, 43, 5, 345, 12, 341, 23, 5, 345, 674, 687, 796, 8, 56, 3, 45, 123, 12, 31, 54, 346, 3457, 456, 73, 45, 234, 1, 234, 135, 1356, 1, 45, 534, 56, 4657, 5, 84, 56, 3, 54, 123, 12, 31, 35, 346, 46, 867, 9, 6789, 56, 7, 456, 345, 2, 34, 235, 3, 5674, 687, 57, 85, 66, 34, 532, 45, 346, 46, 8467, 8, 345678, 4356, 235, 62, 4562, 345, 234, 5245, 7243, 67, 2456, 235, 62134, 5, 13246, 3457, 34, 73, 456, 3245, 634, 573, 45683, 569, 3587, 3456, 73, 567, 3421, 523, 45, 123, 5412, 315, 256, 25, 673, 68, 34578, 4567, 84, 769, 467, 943, 5, 365, 723, 14, 234, 523, 456, 23567, 2345, 6123, 45, 123, 213, 412, 34 });
            arrays.Add(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            arrays.Add(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            arrays.Add(new[] { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 11, 1, 1, 1, 1 });
            OutputValue(arrays, "Full Test");
        }


        [TestMethod]
        public void StandardValues()
        {

            List<int[]> arrays = new List<int[]>();

            arrays.Add(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            arrays.Add(new[] { 1, 1 });
            OutputValue(arrays, "Standard Values");
        }


        [TestMethod]
        public void LargeArrayValues()
        {

            List<int[]> arrays = new List<int[]>();

            arrays.Add(new[] { 123, 123, 1, 23, 123, 12, 31, 23, 123, 1, 23, 123, 12, 31, 23, 124, 1, 4, 143, 15, 245, 3, 6542, 34, 1234, 1, 231, 23, 15, 4325, 3, 123, 1, 23, 5, 43, 5, 345, 12, 341, 23, 5, 345, 674, 687, 796, 8, 56, 3, 45, 123, 12, 31, 54, 346, 3457, 456, 73, 45, 234, 1, 234, 135, 1356, 1, 45, 534, 56, 4657, 5, 84, 56, 3, 54, 123, 12, 31, 35, 346, 46, 867, 9, 6789, 56, 7, 456, 345, 2, 34, 235, 3, 5674, 687, 57, 85, 66, 34, 532, 45, 346, 46, 8467, 8, 345678, 4356, 235, 62, 4562, 345, 234, 5245, 7243, 67, 2456, 235, 62134, 5, 13246, 3457, 34, 73, 456, 3245, 634, 573, 45683, 569, 3587, 3456, 73, 567, 3421, 523, 45, 123, 5412, 315, 256, 25, 673, 68, 34578, 4567, 84, 769, 467, 943, 5, 365, 723, 14, 234, 523, 456, 23567, 2345, 6123, 45, 123, 213, 412, 34 });
            arrays.Add(new[] { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 11, 1, 1, 1, 1 });
            OutputValue(arrays, "Large Array");
        }


        [TestMethod]
        public void RedundancyTest()
        {

            List<int[]> arrays = new List<int[]>();
            arrays.Add(new[] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 });
            arrays.Add(new[] { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 11, 1, 1, 1, 1 });
            OutputValue(arrays, "Redundancy Test");
        }
    }
}
