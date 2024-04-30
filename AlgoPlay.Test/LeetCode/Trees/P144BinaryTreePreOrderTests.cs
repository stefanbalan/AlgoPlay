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

    [Theory]
    [MemberData(nameof(MemberData))]
    public void PreorderTraversalTest2(int?[] input, int[] output)
    {
        var root = TreeNode.FromArray(input);
        var p144 = new P144BinaryTreePreOrder();
        var result = p144.PreorderTraversal2(root);
        Assert.Equal(output, result);
    }

    public static IEnumerable<object[]> MemberData()
    {
        yield return [new int?[] { 1, null, 2, 3 }, new int[] { 1, 2, 3 }];
        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 4, 5, 3, 6, 7 }];
        yield return
        [
            new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
            new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 }
        ];
        yield return
        [
            new int?[]
            {
                1,
                21, 22,
                31, 32, 33, 34,
                41, 42, 43, 44, 45, 46, 47, 48,
                51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, null, 66,
                71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96,
                97, 98
            },
            new int[]
            {
                1, 21, 31, 41, 51, 71, 72, 52, 73, 74, 42, 53, 75, 76, 54, 77, 78, 32, 43, 55, 79, 80, 56, 81, 82, 44,
                57, 83, 84, 58, 85, 86, 22, 33, 45, 59, 87, 88, 60, 89, 90, 46, 61, 91, 92, 62, 93, 94, 34, 47, 63, 95,
                96, 64, 97, 98, 48, 66
            }
        ];
        // this example highlights the difference between the two methods
        // the second method doesn't use the stack at all, but it seems that using the stack is faster
        yield return
        [
            new int?[]
            {
                1, 2, null, 3, null, 4, null, 5, null, 6, null, 7, null, 8, null, 9, null, 10, null, 11, null, 12, null,
                13, null, 14, null, 15, null, 16, null, 17, null, 18, null, 19, null, 20, null, 21, null, 22, null, 23,
                null, 24, null, 25, null, 26, null, 27, null, 28, null, 29, null, 30, null, 31, null, 32, null, 33,
                null, 34, null, 35, null, 36, null, 37, null, 38, null, 39, null, 40, null, 41, null, 42, null, 43,
                null, 44, null, 45, null, 46, null, 47, null, 48, null
            },
            new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
                28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48
            }
        ];
    }
}