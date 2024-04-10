﻿namespace AlgoPlay.Test;

public class TestP2
{
    public int solution(int U, int[] weight)
    {
        if (weight.Length == 0) return 0;
        if (weight.Length == 1) return weight[0] > U ? 1 : 0;

        var turned = 0;
        var passing = new int[weight.Length];
        passing[0] = weight[0];
        int i = 0, j = 1;

        while (j < weight.Length - 1)
        {
            if (passing[i] + weight[j] <= U)
            {
                i += 1;
                j += 1;
                passing[i] = weight[j];
                continue;
            }

            turned += 1; // turn back one car, decide below which one
            if (passing[i] > weight[j])
            {
                passing[i] = weight[j];
                j += 1;
            }
            else
            {
                j += 1;
            }
        }

        if (passing[i] + weight[j] > U) turned += 1;
        return turned;
    }
}