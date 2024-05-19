using Leet_Code_Examples.Coding_Problems.Easy;
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
    internal class RemoveElement_TestCase
    {
        public RemoveElement_TestCase() { }

        [TestMethod]
        private void OutputValue(int[] arrays, string methodName, int val)
        {
            RemoveElement_CodingProblem remove = new RemoveElement_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Removing Element: {val} for Method: {methodName}'s Result is {remove.RemoveElement(arrays, val)} : Total Time to come to this answer: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void TestAll()
        {
            Generic1();
            Generic2();
            NoValue();
            EntireArray();
            LargeTest();
        }

        [TestMethod]
        public void Generic1()
        {
            int[] array = { 3, 2, 2, 3 };
            int val = 3;
            OutputValue(array, "Generic1", val);
        }

        [TestMethod]
        public void Generic2()
        {
            int[] array = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            OutputValue(array, "Generic2", val);
        }

        [TestMethod]
        public void NoValue()
        {
            int[] array = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 5;
            OutputValue(array, "No Value", val);
        }

        [TestMethod]
        public void EntireArray()
        {
            int[] array = { 2,2,2,2,2,2,2,2,2,2 };
            int val = 2;
            OutputValue(array, "Entire Array", val);
        }


        [TestMethod]
        public void LargeTest()
        {
            int[] array = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3,3,3,3,3,3,34,4,4,4,4,5,13,32,1,2,3,5,32,1,4,4,6,6,8,34,42,4,6,7,5,43,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3,3,3,3,2,2,2,2,2,2,2,22,2,22,22,2,22,2,22 };
            int val = 2;
            OutputValue(array, "Large Test", val);
        }
    }
}
