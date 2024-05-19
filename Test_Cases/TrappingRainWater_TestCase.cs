using Leet_Code_Examples.Coding_Problems.Easy;
using Leet_Code_Examples.Coding_Problems.Hard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Examples.Test_Cases
{
    [TestClass]
    internal class TrappingRainWater_TestCase
    {
        public TrappingRainWater_TestCase() { }



        [TestMethod]
        private void OutputValue(int[] arrays, string methodName)
        {
            TrappingRainWater_CodingProblem trapping = new TrappingRainWater_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Trapping Rainwater: for Method: {methodName}'s Most Rainwater Trapped for Array {arrays} is {trapping.Trap(arrays)} units of rainwater : Total Time to come to this answer: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void TestAll()
        {
            Generic1();         // should be 6
            Generic2();         // should be 9
            FlatTest();
            MountainTest();
            ValleyTest();
            LargeTest();
        }

        [TestMethod]
        public void Generic1()
        {
            int[] array = { 4, 2, 0, 3, 2, 5 };
            OutputValue(array, "Generic 1 Test");
        }

        [TestMethod]
        public void Generic2()
        {
            int[] array = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            OutputValue(array, "Generic 2 Test");
        }

        [TestMethod]
        public void FlatTest()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            OutputValue(array, "Flat Test");
        }

        [TestMethod]
        public void MountainTest()
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,8,7,6,5,4,3,2,1 };
            OutputValue(array, "Mountain Test");
        }

        [TestMethod]
        public void ValleyTest()
        {
            int[] array = { 9,8,7,6,5,4,3,2,1,2,3,4,5,6,7,8,9 };
            OutputValue(array, "Valley Test");
        }

        [TestMethod]
        public void LargeTest()
        {
            int[] array = { 1,3,2,5,65,2,46,67,12,34,12,56,43,1,34,67,87,3,5,6,78,23,5634,342,784,123,45,32,1234,1,123,11,645,234,2,123,3,54,25,2,6,547,424,6,23,354,2,62,64,457,423,6,34,63,35,354,67,5463,24,191,432,87,9,87,7,5,45245,23,4,56,56,5467,5,1,42,123,45,234,5,2 };
            OutputValue(array, "Large Test");
        }
    }
}
