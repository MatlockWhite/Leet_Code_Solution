
/*
 * 
 * 
 *          The following will run the test cases for each of the respective coding problems.
 *          For more Coding Challenge information and statistics on each problem refer to the Coding_Problems Folder.
 * 
 * 
*/

using Leet_Code_Examples.Test_Cases;
using Leet_Code_Solution.Test_Cases;

// Best Pricing
BestPricing_TestCase bestP = new BestPricing_TestCase();
bestP.RunCompleteBestPricing();
bestP.RunGenericBestPricing();
bestP.RunOverFlowBestPricing();
bestP.RunSpeedTestBestPricing();

// Convert Integer to Roman Numeral
IntegerToRoman_TestCase intToRoman = new IntegerToRoman_TestCase();
intToRoman.ConvertSequenceOfNumbers();

// Max Area 
MaxArea_TestCase maxArea = new MaxArea_TestCase();
maxArea.FullTest();
maxArea.StandardValues();
maxArea.LargeArrayValues();
maxArea.RedundancyTest();

// Convert Roman Numeral to Integer
RomanToInteger_TestCase rom = new RomanToInteger_TestCase();
rom.TooLowTest();
rom.TooLargeTest();
rom.SeriesTest();


// Zig-Zag
ZigZagConversion_TestCase zig = new ZigZagConversion_TestCase();
zig.CompleteTest();

// Longest Prefix
LongestCommonPrefix_TestCase longest = new LongestCommonPrefix_TestCase();
longest.FullTest();

// Longest Substring            ********* Need to get the information from my other acct *********
LongestSubstringNoRepeats_TestCase longestSub = new LongestSubstringNoRepeats_TestCase();

// Valid Parenthesis
ValidParenthesis_TestCase valid = new ValidParenthesis_TestCase();
valid.TestAll();

// Remove Duplicates
RemoveDuplicatesFromSortedArray_TestCase removeDuplicate = new RemoveDuplicatesFromSortedArray_TestCase();
removeDuplicate.TestAll();

// Remove Element
RemoveElement_TestCase removeElement = new RemoveElement_TestCase();
removeElement.TestAll();

// Find the First Occurance in a String
FindTheFirstOccurance_TestCase findTheFirst =  new FindTheFirstOccurance_TestCase();
findTheFirst.TestAll();

// Trapping Rainwater
TrappingRainWater_TestCase trappingRain = new TrappingRainWater_TestCase();
trappingRain.TestAll();