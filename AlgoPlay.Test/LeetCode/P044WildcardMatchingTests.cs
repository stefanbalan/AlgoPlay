using AlgoPlay.LeetCode;

namespace AlgoPlay.Test.LeetCode;

public class P044WildcardMatchingTests
{
    [Theory]
    [InlineData("", "", true)]
    [InlineData("", "****b***c*", false)]
    [InlineData("", "****", true)]
    [InlineData("a", "a", true)]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "*", true)]
    [InlineData("cb", "?a", false)]
    [InlineData("aabcbcaaa", "aa*bc*aaa", true)]
    [InlineData("aabcbcaaa", "*bc*", true)]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "cddd" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "bcbcaaa", "*cddd*aaaaa*bc*", true)]

    [InlineData("bc", "****b***c*", true)]
    [InlineData("abaabaaaabbabbaaabaabababbaabaabbabaaaaabababbababaabbabaabbbbaabbbbbbbabaaabbaaaaabbaabbbaaaaabbbabb",
        "ab*aaba**abbaaaa**b*b****aa***a*b**ba*a**ba*baaa*b*ab*", false)]
    [InlineData("aab", "c*a*b", false)]
    [InlineData("aab", "*c*a*b", false)]
    [InlineData("mississippi", "m??*ss*?i*pi", false)]
    [InlineData("adceb", "*a*b", true)]
    public void Test(string s, string p, bool expected)
    {
        var solution = new P044WildcardMatching();
        var result = solution.IsMatch(s, p);
        
        Assert.Equal(expected, result);
    }
}