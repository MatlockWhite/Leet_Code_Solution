
/*
 * 
 * 
 *          The following will run the test cases for each of the respective coding problems.
 *          For more Coding Challenge information and statistics on each problem refer to the Coding_Problems Folder.
 * 
 * 
*/

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