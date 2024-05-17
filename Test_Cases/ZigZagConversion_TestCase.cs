using Best_Pricing_Problem;
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
    internal class ZigZagConversion_TestCase
    {
        public ZigZagConversion_TestCase() { }
        
        [TestMethod]
        private void OutputValue(string value, int rows)
        {
            ZigZagConversion_CodingProblem zig = new ZigZagConversion_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Restart();
            s.Start();
            Console.WriteLine($"Zig-Zag Conversion for Value: {value} at a row count of {rows}, Converts To: {zig.Convert(value, rows)} Time: {s.Elapsed}"); 
            s.Stop();
        }

        [TestMethod]
        private void OutputOptimizedValue(string value, int rows)
        {
            ZigZagConversion_CodingProblem zig = new ZigZagConversion_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Restart();
            s.Start();
            Console.WriteLine($"Zig-Zag's Optimized Conversion for Value: {value} at a row count of {rows}, Converts To: {zig.Convert(value, rows)} Time: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void GenericTests()
        {
            OutputValue("NONONSENSEALLOWED", 3);
            OutputOptimizedValue("NONONSENSEALLOWED", 3);
            OutputValue("MAYBEJUSTALITTLE", 4);
            OutputOptimizedValue("MAYBEJUSTALITTLE", 4);
        }

        [TestMethod]
        public void EmptyTest()
        {
            OutputValue("", 3);
            OutputOptimizedValue("", 3);
        }

        [TestMethod]
        public void SingleCharTest()
        {
            OutputValue("A", 1);
            OutputOptimizedValue("A", 1);
        }

        [TestMethod]
        public void LongStringTest()
        {
            OutputValue("SALLYSOLDSEASHELLSBYTHESEASHOREIFSALLYSOLDSIXSEASHELLSHOWMANYSEASHELLSDIDSALLYSELLDOWNBYTHESEASHORE", 7);
            OutputOptimizedValue("SALLYSOLDSEASHELLSBYTHESEASHOREIFSALLYSOLDSIXSEASHELLSHOWMANYSEASHELLSDIDSALLYSELLDOWNBYTHESEASHORE", 7);
        }

        [TestMethod]
        public void CompleteTest()
        {
            EmptyTest();
            SingleCharTest();
            GenericTests();
            LongStringTest();
        }
    }
}
