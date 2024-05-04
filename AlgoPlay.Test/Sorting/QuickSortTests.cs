using AlgoPlay.Sorting;

namespace AlgoPlay.Test.Sorting
{
    public class QuickSortTests
    {
        [Theory, MemberData(nameof(TestData))]
        public void IterativeTest(int[] arr, int[] exp)
        {
            QuickSort.Iterative(arr);
            Assert.Equal(exp, arr);
        }

        [Theory, MemberData(nameof(TestData))]
        public void RecursiveTest(int[] arr, int[] exp)
        {
            QuickSort.Recursive(arr);
            Assert.Equal(exp, arr);
        }


        public static IEnumerable<object[]> TestData()
        {
            yield return [new int[] { }, new int[] { }];
            yield return [new int[] { 1 }, new int[] { 1 }];
            yield return [new int[] { 1, 1 }, new int[] { 1, 1 }];
            yield return [new int[] { 1, 2 }, new int[] { 1, 2 }];
            yield return [new int[] { 2, 1 }, new int[] { 1, 2 }];
            yield return
            [
                new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            ];
        }
    }
}