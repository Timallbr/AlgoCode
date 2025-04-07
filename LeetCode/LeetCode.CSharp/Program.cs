using LeetCode.CSharp._0000_0999._0000_0099;
using LeetCode.CSharp._0000_0999._0100_0199;
using LeetCode.CSharp._0000_0999._0200_0299;
using LeetCode.CSharp._0000_0999._0300_0399;
using LeetCode.CSharp._0000_0999._0400_0499;
using LeetCode.CSharp._0600_0699;
using LeetCode.CSharp._1000_1099;
using LeetCode.CSharp._1400_1499;
using LeetCode.CSharp._1600_1699;
using LeetCode.CSharp._1700_1799;

var merge = MergeStringsAlternately.MergeAlternately("abc", "pqr");

Console.WriteLine(merge);

var gcdLength = GcdOfStrings.Process("ABCABC", "ABC");

Console.WriteLine(gcdLength);


var candies = GreatestNumberOfCandies.Process([2, 3, 5, 1, 3], 3);
;

var canPlaceFlowers_01 = CanPlaceFlowers.Process([1, 0, 0, 0, 1], 1);
var canPlaceFlowers_02 = CanPlaceFlowers.Process([1, 0, 0, 0, 1], 2);

var reversedVowels = ReverseVowels.Process("leetcode");
;

var reverseWords = ReverseWords.Process("  hello world  ");
;
// 120, 60, 40, 30, 24
var productExceptSelf = ProductExceptSelf.Process(new int[] { 1, 2, 3, 4, 5 });
;

var increasingTriplet_01 = IncreasingTriplet.Process(new int[] { 1, 5, 0, 4, 1, 3 });
var increasingTriplet_02 = IncreasingTriplet.Process(new int[] { 20, 100, 10, 12, 5, 13 });
var increasingTriplet_03 = IncreasingTriplet.Process(new int[] { 1 });
var increasingTriplet_04 = IncreasingTriplet.Process(new int[] { 0, 4, 2, 1, 0, -1, -3 });
var increasingTriplet_05 = IncreasingTriplet.Process(new int[] { 1, 2, 3, 4, 5 });
var increasingTriplet_06 = IncreasingTriplet.Process(new int[] { 5, 4, 3, 2, 1 });
var increasingTriplet_07 = IncreasingTriplet.Process(new int[] { 2, 1, 5, 0, 4, 6 });
;


var stringCompression_01 = StringCompression.Process(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
var stringCompression_02 = StringCompression.Process(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });

MoveZeroes.Process(new int[] { 0, 1, 0, 3, 12 });


var isSubsequence = IsSubsequence.Process("abc", "ahbgdc");

var maxArea_01 = MaxArea.Process([1, 8, 6, 2, 5, 4, 8, 3, 7]);
var maxArea_02 = MaxArea.Process([4, 3, 2, 1, 4]);


var maxOps_01 = MaxOperations.ProcessHashMap([1, 2, 3, 4], 5);
var maxOps_02 = MaxOperations.ProcessHashMap([2, 5, 4, 4, 1, 3, 4, 4, 1, 4, 4, 1, 2, 1, 2, 2, 3, 2, 4, 2], 3);

;