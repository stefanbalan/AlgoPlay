namespace AlgoPlay.Test.LeetCode;

public class P518CoinChangeTests
{
    [Theory]
    [InlineData(5, new[] { 1, 2, 5 }, 4)]
    [InlineData(3, new[] { 2 }, 0)]
    [InlineData(10, new[] { 10 }, 1)]
    [InlineData(500, new[] { 3, 5, 7, 8, 9, 10, 11 }, 35502874)]
    public void TestIterative(int amount, int[] coins, int expected)

    {
        var s = new P518CoinChange.Solution();
        var r = s.Change(amount, coins);
        Assert.Equal(expected, r);
    }


    //// the recursive version is too slow! it's not practical to test it
    //// for the last test case, it takes 10 seconds to run
    //[Theory]
    //[InlineData(5, new[] { 1, 2, 5 }, 4)]
    //[InlineData(3, new[] { 2 }, 0)]
    //[InlineData(10, new[] { 10 }, 1)]
    //[InlineData(500, new[] { 3, 5, 7, 8, 9, 10, 11 }, 35502874)]
    //public void TestRecursive(int amount, int[] coins, int expected)
    //{
    //    var s = new P518CoinChange.Solution1();
    //    var r = s.Change(amount, coins);
    //    Assert.Equal(expected, r);
    //}
}