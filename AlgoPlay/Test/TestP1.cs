namespace AlgoPlay.Test;

public class TestP1
{
    public int solution(int[] A)
    {
        int n = A.Length; // length of the array
        int i = n - 1; // last index of the array
        int result = -1; // default result value
        int k = 0, maximal = 0;
        while (i > 0)
        {
            if (A[i] == 1)
            {
                k = k + 1;
                if (k >= maximal)
                {
                    maximal = k;
                    result = i;
                }
            }
            else
                k = 0;

            i = i - 1;
        }

        if (A[i] == 1 && k + 1 >= maximal)
            result = 0;
        return result;
    }
}