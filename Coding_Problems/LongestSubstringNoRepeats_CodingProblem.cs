using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Leet_Code_Examples.Coding_Problems
{
    internal class LongestSubstringNoRepeats_CodingProblem
    {
        public LongestSubstringNoRepeats_CodingProblem() { }

        public int LengthOfLongestSubstring(string s)
        {
            List<int> substring = new List<int>();
            int result = 0;
            for (int i = 0; i < s.Count(); i++)
            {
                int value = (int)s[i];

                if (!substring.Contains(value))
                {
                    substring.Add(value);
                }
                else
                {
                    result = Math.Max(substring.Count(), result);
                    //if (s.Any(x => x.Contains(substring.ToString()) && x.IndexOf(substring.ToString()) != i - substring.Count()))
                    //{
                    //    s.(x => x.Equals(substring.ToString()));
                    //}

                    i -= substring.Count() - substring.IndexOf(s[i]);
                    substring.Clear();
                }
            }

            if (result.Equals(0) && s.Count() > 0)
            {
                result = s.Count();
            }

            result = Math.Max(substring.Count(), result);
            return result;
        }
    }
}
