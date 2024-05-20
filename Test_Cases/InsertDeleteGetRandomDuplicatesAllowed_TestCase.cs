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
    internal class InsertDeleteGetRandomDuplicatesAllowed_TestCase
    {
        [TestMethod]
        public void PerformTest()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            // Instantiate Object
            InsertDeleteGetRandomDuplicatesAllowed_CodingProblem insert = new InsertDeleteGetRandomDuplicatesAllowed_CodingProblem();
            Console.WriteLine($"Instantiated Object For Test 1.");

            // Perform Insert
            Console.WriteLine($"Was able to insert value {1} = {insert.Insert(1)}");
            Console.WriteLine($"Was able to insert value {1} = {insert.Insert(1)}");
            Console.WriteLine($"Was able to insert value {2} = {insert.Insert(2)}");

            // Perform GetRandom
            Console.WriteLine($"Performing Get Random returns: {insert.GetRandom()}");

            // Perform Remove
            Console.WriteLine($"Was able to remove value 1 = {insert.Remove(1)}");

            // Perform GetRandom
            Console.WriteLine($"Performing Get Random returns: {insert.GetRandom()}");

            s.Stop();

        }

        [TestMethod]
        public void PerformTest2()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            // Instantiate Object
            InsertDeleteGetRandomDuplicatesAllowed_CodingProblem insert = new InsertDeleteGetRandomDuplicatesAllowed_CodingProblem();
            Console.WriteLine($"Instantiated Object For Test 2.");

            // Perform Insert
            Console.WriteLine($"Was able to insert value {1} = {insert.Insert(1)}");
            Console.WriteLine($"Was able to insert value {2} = {insert.Insert(2)}");
            Console.WriteLine($"Was able to insert value {3} = {insert.Insert(3)}");
            Console.WriteLine($"Was able to insert value {4} = {insert.Insert(4)}");
            Console.WriteLine($"Was able to insert value {5} = {insert.Insert(5)}");
            Console.WriteLine($"Was able to insert value {2} = {insert.Insert(2)}");
            Console.WriteLine($"Was able to insert value {3} = {insert.Insert(3)}");
            Console.WriteLine($"Was able to insert value {5} = {insert.Insert(5)}");

            // Perform GetRandom
            Console.WriteLine($"Performing Get Random returns: {insert.GetRandom()}");

            // Perform Remove
            Console.WriteLine($"Was able to remove value {1} = {insert.Remove(1)}");
            Console.WriteLine($"Was able to remove value {2} = {insert.Remove(2)}");
            Console.WriteLine($"Was able to remove value {2} = {insert.Remove(2)}");
            Console.WriteLine($"Was able to remove value {6} = {insert.Remove(6)}");

            // Perform GetRandom
            Console.WriteLine($"Performing Get Random returns: {insert.GetRandom()}");

            s.Stop();

        }
    }
}
