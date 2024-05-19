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
    /// <summary>
    /// Some mock test cases for the Integer to Roman Numeral Problem.
    /// </summary>
    [TestClass]
    public class IntegerToRoman_TestCase
    {
        [TestMethod]
        public void OutputValue(int value)
        {
            if (value < 1 || value > 3999) { throw new ArgumentOutOfRangeException(); }
            IntegerToRoman_CodingProblem intToRoman = new IntegerToRoman_CodingProblem();

            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using Value = {value}, Result Generated is: {intToRoman.IntToRoman(value)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void OutputValueOptimized(int value) {
            if (value < 1 || value > 3999) { throw new ArgumentOutOfRangeException(); }
            IntegerToRoman_CodingProblem intToRoman = new IntegerToRoman_CodingProblem();

            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using Value = {value}, Result Generated with Optimized Method is: {intToRoman.OptimizedIntToRoman(value)}, TimeDuration: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void ConvertSequenceOfNumbers()
        {
            int value = 3;
            OutputValue(value);
            OutputValueOptimized(value);

            value = 1;
            OutputValue(value);
            OutputValueOptimized(value);

            value = 3749;
            OutputValue(value);
            OutputValueOptimized(value);

            value = 58;
            OutputValue(value);
            OutputValueOptimized(value);

            value = 1994;
            OutputValue(value);
            OutputValueOptimized(value);

            value = 3999;
            OutputValue(value);
            OutputValueOptimized(value);
        }
    }
}
