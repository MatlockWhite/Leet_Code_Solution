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
    internal class NQueensII_TestCase
    {
        public NQueensII_TestCase() { }

        [TestMethod]
        public void OutputValue(int numQueens)
        {
            NQueensII_CodingProblem valid = new NQueensII_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"NQueens: Placing '{numQueens}' on a {numQueens}x{numQueens} chessboard returns {valid.TotalNQueens} of distinct solutions. TimeDuration: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            MaxTest9();
            MinTest1();
        }

        [TestMethod]
        public void GenericTest1()
        {
            OutputValue(4);
        }

        [TestMethod]
        public void GenericTest2()
        {
            OutputValue(3);
        }

        [TestMethod]
        public void MaxTest9()
        {
            OutputValue(9);
        }

        [TestMethod]
        public void MinTest1()
        {
            OutputValue(1);
        }
    }
}
