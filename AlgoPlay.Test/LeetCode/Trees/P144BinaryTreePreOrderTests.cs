using AlgoPlay.LeetCode.Trees;

namespace AlgoPlay.Test.LeetCode.Trees;

public class P144BinaryTreePreOrderTests
{
    [Theory]
    [MemberData(nameof(MemberData))]
    public void PreorderTraversalTest1(int?[] input, int[] output)
    {
        var root = TreeNode.FromArray(input);
        var p144 = new P144BinaryTreePreOrder();
        var result = p144.PreorderTraversal(root);
        Assert.Equal(output, result);
    }

    public static IEnumerable<object[]> MemberData()
    {
        yield return new object[] { new int?[] { 1, null, 2, 3 }, new int[] { 1, 2, 3 } };
        yield return new object[] { new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 4, 5, 3, 6, 7 } };
        yield return new object[] { new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 } };
    }
}