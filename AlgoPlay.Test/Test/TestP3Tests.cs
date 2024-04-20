namespace AlgoPlay.Test.Test;

public class TestP3Tests
{

    [Theory]
    [InlineData("CBACD", "C")]
    [InlineData("ADBCABDACB", "")]
    public void TestWeight(string s, string exp)
    {
        var solution = new TestP3();
        var result = solution.Solution(s);
        Assert.Equal(exp, result);

    }
}