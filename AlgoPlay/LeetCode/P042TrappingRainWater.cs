namespace AlgoPlay.LeetCode
{
    //Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
    // 
    //  
    // 
    // Example 1:
    // 
    // |       *
    // |   *---**-*
    // |_*-**-******
    // 
    // Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
    // Output: 6
    // Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
    // Example 2:
    // 
    // Input: height = [4,2,0,3,2,5]
    // Output: 9
    //  
    // 
    // Constraints:
    // 
    // n == height.length
    // 1 <= n <= 2 * 10^4
    // 0 <= height[i] <= 10^5

    public class P042TrappingRainWater
    {
        public int Trap(int[] height)
        {
            if (height.Length <= 2) return 0;

            var peaks = new int[height.Length];
            var peaksIndex = -1;

            // determine the peaks
            if (height[0] >= height[1])
            {
                peaks[0] = 0;
                peaksIndex = 0;
            }

            for (int i = 1; i < height.Length - 1; i += 1)
            {
                var currentHeight = height[i];
                if (currentHeight > height[i - 1] && currentHeight >= height[i + 1])
                    //try to add it as a peak
                {
                    while (peaksIndex > 0 &&
                           currentHeight >= height[peaks[peaksIndex]] &&
                           height[peaks[peaksIndex - 1]] > height[peaks[peaksIndex]])
                    {
                        peaksIndex -= 1;
                    }

                    peaksIndex += 1;
                    peaks[peaksIndex] = i;
                }
            }

            if (height[^1] >= height[^2])
                //try to add it as a peak
            {
                while (peaksIndex > 0 &&
                       height[^1] > height[peaks[peaksIndex]] &&
                       height[peaks[peaksIndex]] < height[peaks[peaksIndex - 1]])
                {
                    peaksIndex -= 1;
                }

                peaksIndex += 1;
                peaks[peaksIndex] = height.Length - 1;
            }

            // calculate the water volume
            if (peaksIndex == 0) return 0;
            var result = 0;
            int h;
            for (int i = 0; i < peaksIndex - 1; i += 1)
            {
                h = Math.Min(height[peaks[i]], height[peaks[i + 1]]);
                for (int j = peaks[i] + 1; j < peaks[i + 1]; j += 1)
                {
                    if (height[j] < h)
                        result += h - height[j];
                }
            }

            h = Math.Min(height[peaks[peaksIndex - 1]], height[peaks[peaksIndex]]);
            for (int j = peaks[peaksIndex - 1] + 1; j < peaks[peaksIndex]; j += 1)
            {
                if (height[j] < h)
                    result += h - height[j];
            }

            return result;
        }
    }
}