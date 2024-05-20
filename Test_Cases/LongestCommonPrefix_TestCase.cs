using Leet_Code_Examples.Coding_Problems.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leet_Code_Examples.Test_Cases
{
    [TestClass]
    internal class LongestCommonPrefix_TestCase
    {
        public LongestCommonPrefix_TestCase() { }

        [TestMethod]
        public void OutputValue(List<string[]> arrays, string methodName)
        {
            LongestCommonPrefix_CodingProblem longestPrefix = new LongestCommonPrefix_CodingProblem();

            Stopwatch s = new Stopwatch();
            for (int i = 0; i < arrays.Count; i++)
            {
                s.Restart();
                s.Start();
                Console.WriteLine($"Longest Prefix: The result for {methodName} array at index {i} result is: {longestPrefix.LongestCommonPrefix(arrays[i])}, Time to complete is: {s.Elapsed}");
                s.Stop();
            }

        }

        [TestMethod]
        public void TestAll()
        {
            List<string[]> values = new List<string[]>();

            string[] names1 = { "dog", "racecar", "car"};
            string[] names2 = { "Flower","Flow","Flight"};
            string[] names3 = { "","",""};
            string[] names4 = { };
            string[] names5 = { "power", "people", "fallout", "belief", "placed", "places", "peoples", "trump", "mistake", "flow", "follow", "forgot", "aha", "aloha", "why", "cant", "i", "do", "this", "in", "a", "more", "sensible", "way", "pole", "pocket", "phone"};
            string[] names6 = { "people", "peoples", "pero", "peropero", "polyp"};
            string[] names7 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
            values.Add(names1);
            values.Add(names2);
            values.Add(names3);
            values.Add(names4);
            values.Add(names5);
            values.Add(names6);
            values.Add(names7);
            OutputValue(values, "Full Test");
        }

        [TestMethod]
        public void EmptyStringsTest()
        {
            List<string[]> values = new List<string[]>();
            string[] value = { "", "", "" };
            values.Add(value);
            OutputValue(values, "Empty Test");
        }

        [TestMethod]
        public void NullValuedArrayTest()
        {
            List<string[]> values = new List<string[]>();
            string[] value = { };
            values.Add(value);
            OutputValue(values, "Null Test");
        }

        [TestMethod]
        public void ContainedWordsTest()
        {
            List<string[]> values = new List<string[]>();
            string[] value = { "people", "peoples", "pero", "peropero", "polyp" };
            values.Add(value);
            OutputValue(values, "Contained Word Test");

        }

        [TestMethod]
        public void NoMatchTest()
        {
            List<string[]> values = new List<string[]>();
            string[] value = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
            values.Add(value);
            OutputValue(values, "No Match Test");

        }
    }
}
