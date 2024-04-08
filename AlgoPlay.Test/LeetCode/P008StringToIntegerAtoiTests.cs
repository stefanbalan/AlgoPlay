using AlgoPlay.LeetCode;

namespace AlgoPlay.Test.LeetCode;

public class P008StringToIntegerAtoiTests

{
    [Theory]
    [InlineData("    -4193 with words", -4193)]
    [InlineData("-91283472332", -4193)]
    [InlineData("3.1425", -4193)]
    [InlineData("   +0 123", -4193)]
    [InlineData("00000-42a1234", -4193)]
    [InlineData("9223372036854775808", -4193)]
    [InlineData("-13+8", -13)]

    public void Test(string str, int expected)

    {
        var s = new P008StringToIntegerAtoi();
        var r = s.MyAtoi(str);
        Assert.Equal(expected, r);
    }
}