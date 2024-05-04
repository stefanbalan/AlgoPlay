namespace AlgoPlay.Sorting;

public class QuickSort
{
    public static void Iterative(int[] arr)
    {
        if (arr.Length == 0) return;

        var stack = new Stack<(int, int)>(arr.Length / 2 + 1);

        stack.Push((0, arr.Length - 1));

        while (stack.Count > 0)
        {
            var (low, high) = stack.Pop();

            int pi = Partition(arr, low, high);

            if (pi - 1 > low) stack.Push((low, pi - 1));
            if (pi + 1 < high) stack.Push((pi + 1, high));
        }
    }


    public static void Recursive(int[] arr)
    {
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            Sort(arr, low, pi - 1);
            Sort(arr, pi + 1, high);
        }
    }

    private static int PartitionMedian(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}