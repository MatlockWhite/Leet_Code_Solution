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
    internal class IsPalindrom_TestCase
    {
        public IsPalindrom_TestCase() { }

        [TestMethod]
        public void OutputValue(int value, string testMethod)
        {
            IsPalindrome_CodingProblem palindrome = new IsPalindrome_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using integer value: '{value}', Is Palindrom Test Method: {testMethod} Result Generated is: {palindrome.IsPalindrome(value)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            NegativeTest();
            SingleValueTest();
            LargeTest();
        }

        [TestMethod]
        public void GenericTest1()
        {
            OutputValue(121, "Generic Test 1");
        }

        [TestMethod]
        public void GenericTest2()
        {
            OutputValue(10, "Generic Test 2");
        }

        [TestMethod]
        public void NegativeTest()
        {
            OutputValue(-121, "Negative Test");
        }


        [TestMethod]
        public void SingleValueTest()
        {
            OutputValue(1, "Single Value Test");
        }

        [TestMethod]
        public void LargeTest()
        {
            OutputValue(123454321, "Large Test");
        }
    }
}
