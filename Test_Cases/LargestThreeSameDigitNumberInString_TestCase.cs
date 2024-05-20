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
    internal class LargestThreeSameDigitNumberInString_TestCase
    {
        public LargestThreeSameDigitNumberInString_TestCase() { }


        [TestMethod]
        public void OutputValue(string str)
        {
            LargestThreeSameDigitNumberInString_CodingProblem valid = new LargestThreeSameDigitNumberInString_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using string = '{str}', Largest 3 Same Digit Number In a String Result Generated is: {valid.LargestGoodInteger(str)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            Generic1();
            Generic2();
            Generic3();
            LargeString();
            EmptyString();
            NoSolution();
            MultipleAnswers();
        }

        [TestMethod]
        public void Generic1()
        {
            OutputValue("6777133339");
        }

        [TestMethod]
        public void Generic2()
        {
            OutputValue("2300019");
        }

        [TestMethod]
        public void Generic3()
        {
            OutputValue("42352338");
        }

        [TestMethod]
        public void EmptyString()
        {
            OutputValue("");
        }

        [TestMethod]
        public void NoSolution()
        {
            OutputValue("11223344556677889900");
        }

        [TestMethod]
        public void LargeString()
        {
            OutputValue("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111112122323233434454556466777888999");
        }

        [TestMethod]
        public void MultipleAnswers()
        {
            OutputValue("1112222333444555666777888999");
        }
    }
}
