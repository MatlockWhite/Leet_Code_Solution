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
    internal class CalculateMoneyInBank_TestCase
    {
        public CalculateMoneyInBank_TestCase() { }


        [TestMethod]
        public void OutputValue(int num)
        {
            CalculateMoneyInBank_CodingProblem bank = new CalculateMoneyInBank_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Saving up for {num} days Hercy will save a total of: ${bank.TotalMoney(num)}, TimeDuration: {s.Elapsed}");
            s.Stop();

        }

        [TestMethod]
        public void TestAll()
        {
            GenericTest1();
            GenericTest2();
            GenericTest3();
            OneDay();
            OneHundredDays();
            OneThousandDays();
        }

        [TestMethod]
        public void GenericTest1()
        {
            OutputValue(4);
        }

        [TestMethod]
        public void GenericTest2()
        {
            OutputValue(10);
        }

        [TestMethod]
        public void GenericTest3()
        {
            OutputValue(20);
        }

        [TestMethod]
        public void OneDay()
        {
            OutputValue(1);
        }

        [TestMethod]
        public void OneHundredDays()
        {
            OutputValue(100);
        }

        [TestMethod]
        public void OneThousandDays()
        {
            OutputValue(1000);
        }
    }
}
