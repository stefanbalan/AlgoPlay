namespace AlgoPlay.Test.Test;

public class TestP2Tests
{

    [Theory]
    [InlineData(9, new[] { 9, 9, 8, 2, 1, 1, 1 }, 3)]
    [InlineData(10, new[] { 1, 9, 2, 1, 1, 1, 1 }, 1)]
    [InlineData(9, new[] { 3, 8, 2, 2, 2, 2, 2, 2 }, 1)]
    [InlineData(9, new[] { 9, 8, 2, 2, 2, 2, 2, 8 }, 3)]
    [InlineData(9, new[] { 3, 8, 2, 2, 2, 2, 2, 11 }, 2)]
    [InlineData(9, new[] { 3, 8, 2, 2, 2, 2, 2, 8 }, 2)]
    [InlineData(9, new[] { 1, 8, 2, 2, 2, 2, 2, 8 }, 2)]
    [InlineData(9, new[] { 9, 9, 9 }, 3)]
    public void TestWeight(int U, int[] weight, int exp)
    {
        var solution = new TestP2();
        var result = solution.solution(U, weight);
        Assert.Equal(exp, result);

    }
}