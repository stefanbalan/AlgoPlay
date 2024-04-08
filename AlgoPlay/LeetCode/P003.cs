namespace AlgoPlay.LeetCode;

// Given a string s, find the length of the longest 
// substring
//  without repeating characters.
// 
//  
// 
// Example 1:
// 
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:
// 
// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:
// 
// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
//  
// 
// Constraints:
// 
// 0 <= s.length <= 5 * 10^4
// s consists of English letters, digits, symbols and spaces.


public class P003
{
    public int LengthOfLongestSubstring(string s)
    {
        var sub = new Dictionary<char, int>(120);
        int start = 0, end = 0, max = 0, newstart = 0;

        while (end < s.Length)
        {
            if (sub.ContainsKey(s[end]))
            {
                newstart = sub[s[end]];
                for (int i = start; i < newstart; i++)
                    sub.Remove(s[i]);
                start = newstart + 1;
            }

            sub[s[end]] = end;

            if (sub.Count > max) max = sub.Count;

            end += 1;
        }

        return max;
    }

    public int LengthOfLongestSubstring1(string s) // easy
    {
        string sub = string.Empty, max = String.Empty;
        int start = 0, end = 0;

        while (end < s.Length)
        {
            if (sub.Contains(s[end]))
                start = s.IndexOf(s[end], start) + 1;

            sub = s.Substring(start, end - start + 1);
            if (sub.Length > max.Length) max = sub;

            end += 1;
        }

        return max.Length;
    }

}