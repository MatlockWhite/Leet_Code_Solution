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
    internal class BuyTwoChocolates_TestCase
    {
        public BuyTwoChocolates_TestCase() { }


        [TestMethod]
        public void OutputValue(int[] array, int money, string testMethod)
        {
            BuyTwoChocolates_CodingProblem buy = new BuyTwoChocolates_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Buy2Chocolates TestMethod: {testMethod} Using prices: '{array}' with a spending alottment of ${money}, Money Left Over is: ${buy.BuyChoco(array, money)}, TimeDuration: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            NoPurchaseTest();
            LargeArrayTest();
            OneDollarTest();
            DuplicatePricesTest();
        }

        [TestMethod]
        public void GenericTest1()
        {
            int[] array = { 1, 2, 2 };
            int value = 3;
            OutputValue(array, value, "Generic Test 1");
        }


        [TestMethod]
        public void GenericTest2()
        {
            int[] array = { 3,2,3 };
            int value = 3;
            OutputValue(array, value, "Generic Test 2");
        }

        [TestMethod]
        public void NoPurchaseTest()
        {
            int[] array = { 5,6,7 };
            int value = 4;
            OutputValue(array, value, "No Purchase Test");
        }


        [TestMethod]
        public void LargeArrayTest()
        {
            int[] array = { 12,3,123,1,23,124,123,451,51,1,23,123,1,24,15,1,234,135,346,45,75,67858,6,79,345,243,5123,41,4,1643,63,465,376,4678,576,85,67,4567,23,4,1234,23,535,75,78,679,78,97,89,1431,345,12,123,123,2,32,45,123,32,12,23,151,61,13,65,87,4,9,324,2,1,875,12,213,7645,112,6,54467,123,5643,76,87,9,8234,12,34346,98,797,345,23,42,4,647,567,58,63,5,324567,347,1234,45,568,657,834,2,3345,256,2,457,2,1234,123,4123,7,1,23,54,437,567,2,34,23,4,576,56,4,2345,24,6524,1,12 };
            int value = 56;
            OutputValue(array, value, "LargeArrayTest");
        }

        [TestMethod]
        public void OneDollarTest()
        {
            int[] array = { 5, 6, 7 };
            int value = 1;
            OutputValue(array, value, "No Purchase Test");
        }


        [TestMethod]
        public void DuplicatePricesTest()
        {
            int[] array = { 2,2,3,3,4,5,5,4,7,7,8,8,2,2 };
            int value = 56;
            OutputValue(array, value, "Duplicate Prices Test");
        }
    }
}
