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
    internal class FindTheFirstOccurance_TestCase
    {
        public FindTheFirstOccurance_TestCase() { }

        [TestMethod]
        private void OutputValue(string haystack, string methodName, string needle)
        {
            FindTheFirstOccurance_CodingProblem findTheFirstOccurance = new FindTheFirstOccurance_CodingProblem();
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Find The First Occurance: Looking for Needle: {needle} in Haystack: {haystack} for Method: {methodName}'s Results in index {findTheFirstOccurance.StrStr(haystack, needle)} : Total Time to come to this answer: {s.Elapsed}");
            s.Stop();
        }

        [TestMethod]
        public void TestAll()
        {
            Generic1();
            Generic2();
            MissingValue();
            MultipleTest();
            EmptyNeedleTest();
            LargeTest();
        }

        [TestMethod]
        public void Generic1()
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            OutputValue(haystack, "Generic1", needle);
        }

        [TestMethod]
        public void Generic2()
        {
            string haystack = "leetcodetest";
            string needle = "leeto";
            OutputValue(haystack, "Generic2", needle);
        }

        [TestMethod]
        public void MissingValue()
        {
            string haystack = "thevaluewillnotbefound";
            string needle = "thefoundvalue";
            OutputValue(haystack, "Missing Value Test", needle);
        }

        [TestMethod]
        public void MultipleTest()
        {
            string haystack = "testtesttesttest";
            string needle = "test";
            OutputValue(haystack, "MultipleTest", needle);
        }

        [TestMethod]
        public void EmptyNeedleTest()
        {
            string haystack = "leetcodetest";
            string needle = "";
            OutputValue(haystack, "Empty Needle Test", needle);
        }

        [TestMethod]
        public void LargeTest()
        {
            string haystack = "inthislargetestiwilldiscusshowdndcanbeareallyfunpasttimeforallwhoenjoyafunandadventurousgamesetwithothersthatcannotbeconstrainedbyanyadditionalpracticesfurthermorethebestpossibleracetoplayistheaasimarandthebestpossibleclasswouldbetoplaywarlock";
            string needle = "aasimar";
            OutputValue(haystack, "Large Test", needle);
        }
    }
}
