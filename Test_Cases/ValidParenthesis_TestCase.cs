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
    internal class ValidParenthesis_TestCase
    {
        public ValidParenthesis_TestCase() { }

        [TestMethod]
        public void OutputValue(string str)
        {
            ValidParenthesis_CodingProblem valid = new ValidParenthesis_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Using string = '{str}', Valid Parenthesis Result Generated is: {valid.IsValid(str)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            OutputValue("");
            OutputValue("()");
            OutputValue("(){}[]");
            OutputValue("))");
            OutputValue("((((()");
            OutputValue("{{{[[[]]]}}}");
            OutputValue("(}");
            OutputValue("({[]})");
            OutputValue("()(]{[]})");
        }


        [TestMethod]
        public void EmptyTest()
        {
            OutputValue("");
        }

        [TestMethod]
        public void AllValidTest()
        {
            OutputValue("()");
            OutputValue("(){}[]");
            OutputValue("{{{[[[]]]}}}");
            OutputValue("({[]})");
        }

        [TestMethod]
        public void AllInvalidTest()
        {
            OutputValue("))");
            OutputValue("((((()");
            OutputValue("(}");
            OutputValue("()(]{[]})");
        }


        [TestMethod]
        public void MixMatchTest()
        {
            OutputValue("(}");
            OutputValue("()(]{[]})");
        }

    }
}
