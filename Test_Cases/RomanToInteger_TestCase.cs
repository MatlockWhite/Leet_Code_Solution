using Leet_Code_Solution.Coding_Problems;
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
    internal class RomanToInteger_TestCase
    {
        public RomanToInteger_TestCase() { }

        [TestMethod]
        public void OutputValue(string value) {
            try
            {
                Stopwatch s = new Stopwatch();

                RomanToInteger_CodingProblem romanToInt = new RomanToInteger_CodingProblem();

                s.Start();
                Console.WriteLine($"RomanToInteger: Using Value = {value}, Result = {romanToInt.RomanToInt(value)}, TimeDuration: {s.Elapsed}");
                s.Stop();
            } catch (Exception ex)
            {
                Console.WriteLine($"Could not perform Roman Numeral to Integer conversion for value {value} due to exception {ex.ToString()}");
            }
        }

        [TestMethod]
        public void TooLargeTest()
        {
            OutputValue("4000");
        }


        [TestMethod]
        public void TooLowTest()
        {
            OutputValue("0");
        }

        [TestMethod]
        public void SeriesTest() 
        {
            OutputValue("III");
            OutputValue("LVIII");
            OutputValue("MCMXCIV");
            OutputValue("LIX");
        }
    }
}
