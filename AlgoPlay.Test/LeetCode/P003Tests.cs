using AlgoPlay.LeetCode;

namespace AlgoPlay.Test.LeetCode;

public class P003Tests

{
    [Theory]
    [InlineData("aabaab!bb", 3)]
    public void Test(string str, int expected)

    {
        var s = new P003();
        var r = s.LengthOfLongestSubstring(str);
        Assert.Equal(expected, r);
    }
}