using AlgoPlay.LeetCode;

namespace AlgoPlay.Test.LeetCode;

public class P042TrappingRainWaterTests
{
    [Theory]
    [InlineData(new[] { 0, 2, 0 }, 0)]
    [InlineData(new[] { 5, 5, 1, 7, 1, 1, 5, 2, 7, 6 }, 23)]
    [InlineData(new[] { 2, 0, 2 }, 2)]
    [InlineData(new[] { 3, 0, 0, 0, 3 }, 9)]
    [InlineData(new[] { 3, 0, 0, 0, 2 }, 6)]
    [InlineData(new[] { 3, 0, 1, 0, 3 }, 8)]
    [InlineData(new[] { 3, 0, 1, 0, 2 }, 5)]
    [InlineData(new[] { 3, 2, 1, 0, 2 }, 3)]
    [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new[] { 5, 4, 1, 2 }, 1)]
    [InlineData(new[]
    {
        6, 4, 2, 0, 3, 2, 0, 3, 1, 4, 5, 3, 2, 7,
        5, 3, 0, 1, 2, 1, 3, 4, 6, 8, 1, 3
    }, 83)]
    public void Test(int[] height, int expected)

    {
        var sut = new P042TrappingRainWater();
        var result = sut.Trap(height);
        Assert.Equal(expected, result);
    }
}