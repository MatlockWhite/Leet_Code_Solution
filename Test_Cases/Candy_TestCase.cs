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
    internal class Candy_TestCase
    {
        public Candy_TestCase() { }


        [TestMethod]
        public void OutputValue(int[] array, string testMethod)
        {
            Candy_CodingProblem candy = new Candy_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Performing Method: {testMethod}, Given Children ages of: {array}, the minimum amount of Candies given out is: {candy.Candy(array)} TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            AllSameAgeTest();
            IncreasingAgesTest();
            DecreasingAgesTest();
            ValleyAgeTest();
            MountainAgeTest();
        }

        [TestMethod]
        public void GenericTest1()
        {
            int[] array = { 1, 0, 2 };
            OutputValue(array, "Generic Test 1");
        }

        [TestMethod]
        public void GenericTest2()
        {
            int[] array = { 1, 2, 2 };
            OutputValue(array, "Generic Test 2");
        }

        [TestMethod]
        public void AllSameAgeTest()
        {
            int[] array = { 2, 2, 2 };
            OutputValue(array, "All Same Age Test");
        }

        [TestMethod]
        public void IncreasingAgesTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            OutputValue(array, "Increasing Ages Test");
        }

        [TestMethod]
        public void DecreasingAgesTest()
        {
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            OutputValue(array, "Decreasing Ages Test");
        }

        [TestMethod]
        public void ValleyAgeTest()
        {
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            OutputValue(array, "Valley Age Test");
        }

        [TestMethod]
        public void MountainAgeTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            OutputValue(array, "Mountain Age Test");
        }
    }
}
