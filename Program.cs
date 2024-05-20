
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
zig.TestAll();

// Longest Prefix
LongestCommonPrefix_TestCase longest = new LongestCommonPrefix_TestCase();
longest.TestAll();

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

// Valid Palindrome (Int)
IsPalindrom_TestCase isPalindrom = new IsPalindrom_TestCase();
isPalindrom.TestAll();

// Buy Two Chocolates
BuyTwoChocolates_TestCase buyTwoChocolates =  new BuyTwoChocolates_TestCase();
buyTwoChocolates.TestAll();

// Largest 3-Same-Digit Number in a String
LargestThreeSameDigitNumberInString_TestCase largestThreeSameDigitNumberInString = new LargestThreeSameDigitNumberInString_TestCase();
largestThreeSameDigitNumberInString.TestAll();

// Minimum Changes To Make Alternating Binary String
MinimumChangesToMakeAlternatingBinaryString_TestCase minimumChangesToMakeAlternatingBinaryString_ = new MinimumChangesToMakeAlternatingBinaryString_TestCase();
minimumChangesToMakeAlternatingBinaryString_.TestAll();

CalculateMoneyInBank_TestCase CalculateMoneyInBank_ = new CalculateMoneyInBank_TestCase();
CalculateMoneyInBank_.TestAll();

// Insert Delete GetRandom O(1) Duplicates Allowed
InsertDeleteGetRandomDuplicatesAllowed_TestCase insertDeleteGetRandomDuplicatesAllowed_ = new InsertDeleteGetRandomDuplicatesAllowed_TestCase();
insertDeleteGetRandomDuplicatesAllowed_.PerformTest();
insertDeleteGetRandomDuplicatesAllowed_.PerformTest2();

// N-Queens II
NQueensII_TestCase nQueensII_ = new NQueensII_TestCase();
nQueensII_.TestAll();

// Candy
Candy_TestCase candy = new Candy_TestCase();
candy.TestAll();