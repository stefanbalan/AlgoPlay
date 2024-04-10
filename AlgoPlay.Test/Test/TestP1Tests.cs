namespace AlgoPlay.Test.Test;

public class TestP1Tests
{
    [Theory]
    [InlineData(new[] { 1, 1, 1, 0, 1, 1, 1 }, 0)]
    [InlineData(new[] { 1, 0, 1, 0, 1, 0, 1, 0 }, 0)]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, -1)]
    public void Test1(int[] A, int exp)
    {
        var solution = new TestP1();
        var result = solution.solution(A);
        Assert.Equal(exp, result);

    }
}