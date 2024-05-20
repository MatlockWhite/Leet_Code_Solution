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
    internal class MinimumChangesToMakeAlternatingBinaryString_TestCase
    {
        public MinimumChangesToMakeAlternatingBinaryString_TestCase() { }


        [TestMethod]
        public void OutputValue(string str)
        {
            MinimumChangesToMakeAlternatingBinaryString_CodingProblem min = new MinimumChangesToMakeAlternatingBinaryString_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using string = '{str}', The Minimum Changes Required to Make Alternating Binary String: {min.MinOperations(str)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            GenericTest3();
            Test0();
            Test1();
            InverseTest();
            PairTest();
            LongTest();
        }

        [TestMethod]
        public void GenericTest1()
        {
            OutputValue("0100");
        }

        [TestMethod]
        public void GenericTest2()
        {
            OutputValue("10");
        }

        [TestMethod]
        public void GenericTest3()
        {
            OutputValue("1111");
        }

        [TestMethod]
        public void Test0()
        {
            OutputValue("000000");
        }

        [TestMethod]
        public void Test1()
        {
            OutputValue("111111");
        }

        [TestMethod]
        public void InverseTest()
        {
            OutputValue("1111100000");
        }

        [TestMethod]
        public void PairTest()
        {
            OutputValue("0011001100110011");
        }

        [TestMethod]
        public void LongTest()
        {
            OutputValue("11001100110011001010101010100110011010100101010100001101110010101010101101010010101010100101010101001011011001001010010101001010101001010100101010010101010010100101010000101010101001011110101010101010010101010010101010010101");
        }
    }
}
