using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Insert Delete GetRandom O(1) Duplicates Allowed
 *      
 *      RandomizedCollection is a data structure that contains a collection of numbers, 
 *      possibly duplicates (i.e., a multiset). 
 *      
 *      It should support inserting and removing specific elements and also reporting a random element.
 *      
 *      Implement the RandomizedCollection class:
 *      
 *      RandomizedCollection() Initializes the empty RandomizedCollection object.
 *      bool insert(int val) Inserts an item val into the multiset, even if the item is already present. 
 *      Returns true if the item is not present, false otherwise.
 *      bool remove(int val) Removes an item val from the multiset if present. 
 *      Returns true if the item is present, false otherwise. 
 *      Note that if val has multiple occurrences in the multiset, we only remove one of them.
 *      int getRandom() Returns a random element from the current multiset of elements. 
 *      The probability of each element being returned is linearly related to the 
 *      number of the same values the multiset contains.
 *      
 *      You must implement the functions of the class such that each function works on average O(1) time complexity.
 *      
 *      Note: The test cases are generated such that getRandom will only be called if there is 
 *      at least one item in the RandomizedCollection.
 *      
 *      Constraints:
 *      -2^31 <= x <= 2^31 - 1
 *      At most 2 * 10^5 calls in total will be made to insert, remove, and getRandom.
 *      There will be at least one element in the data structure when getRandom is called.
 *      
 *      LeetCode Statistics
 *      Difficulty:         Hard
 *      Acceptance Rate:    35.5%
 *      Submissions:        401.6K
 * 
 *      Personal Statistics (Using Leetcode Testcases)
 *      Runtime Efficiency: 1851 ms
 *      Memory Efficiency:  131.02 MB
 */


namespace Leet_Code_Examples.Coding_Problems.Hard
{
    internal class InsertDeleteGetRandomDuplicatesAllowed_CodingProblem
    {
        // The following uses both a List and Dictionary Datastructures sacrificing memory usage in exchange for Runtime Performance.
        List<int> randomSetList;
        Dictionary<int, int> randomSetDictionary;
        Random randomNumber;

        /// <summary>
        /// In The Following solution I chose to sacrifice runtime efficiency to challenge myself with Memory efficiency.
        /// As of 5-19-2024 This solution is the best solution submitted in terms of memory efficiency.
        /// </summary>
        public InsertDeleteGetRandomDuplicatesAllowed_CodingProblem() 
        {
            this.randomSetDictionary = new Dictionary<int, int>();
            this.randomSetList = new List<int>();
            randomNumber = new Random();
        }

        public bool Insert(int val)
        {
            bool result = false;
            if (!this.randomSetDictionary.Any(x => x.Key.Equals(val)))
            {
                this.randomSetDictionary.Add(val, 1);
                this.randomSetList.Add(val);
                result = true;
            }
            else
            {
                if (randomSetDictionary[val].Equals(0))
                {
                    result = true;
                }
                this.randomSetDictionary[val]++;
                this.randomSetList.Add(val);
            }

            return result;
        }

        public bool Remove(int val)
        {
            bool result = false;
            if (this.randomSetDictionary.Any(x => x.Key.Equals(val) && x.Value > 0))
            {
                this.randomSetDictionary[val]--;
                this.randomSetList.Remove(val);
                result = true;
            }

            return result;
        }

        public int GetRandom()
        {
            return this.randomSetList[randomNumber.Next(this.randomSetList.Count())];
        }
    }
}
