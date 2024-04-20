namespace AlgoPlay.LeetCode;

//Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
// 
// '?' Matches any single character.
// '*' Matches any sequence of characters (including the empty sequence).
// The matching should cover the entire input string (not partial).
// 
//  
// 
// Example 1:
// 
// Input: s = "aa", p = "a"
// Output: false
// Explanation: "a" does not match the entire string "aa".
// Example 2:
// 
// Input: s = "aa", p = "*"
// Output: true
// Explanation: '*' matches any sequence.
// Example 3:
// 
// Input: s = "cb", p = "?a"
// Output: false
// Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
//  
// 
// Constraints:
// 
// 0 <= s.length, p.length <= 2000
// s contains only lowercase English letters.
// p contains only lowercase English letters, '?' or '*'.

public class P044WildcardMatching
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.IsNullOrWhiteSpace(p.Replace("*", ""));

        if (string.IsNullOrWhiteSpace(p)) return false;
        while (p.IndexOf("**", StringComparison.Ordinal) > -1)
            p = p.Replace("**", "*");

        var isMatch = new bool[p.Length + 1, s.Length + 1];
        isMatch[0, 0] = true;
        var stars = 0;
        for (int pi = 1; pi <= p.Length; pi++)
        {
            if (p[pi - 1] == '*')
            {
                stars += 1;
                if (stars == 1)
                    for (int si = pi - stars; si <= s.Length; si++)
                        isMatch[pi, si] = true;
                else
                    for (int si = pi - stars; si <= s.Length; si++)
                        isMatch[pi, si] = isMatch[pi - 1, si] || isMatch[pi, si - 1];
            }
            else
            {
                var anyMatch = false;
                for (int si = pi - stars; si <= s.Length; si++)
                {
                    isMatch[pi, si] = (p[pi - 1] == s[si - 1] || p[pi - 1] == '?')
                                      && isMatch[pi - 1, si - 1];
                    anyMatch |= isMatch[pi, si];
                }

                if (!anyMatch) return false;
            }
        }

        return isMatch[p.Length, s.Length];
    }


    // recursive 
    public bool IsMatch(string s, int si, string p, int pi)
    {
        if (p[pi] == s[si] || p[pi] == '?')
        {
            if (si == 0 && pi == 0) return true;
            if (si == 0 || pi == 0) return (pi == 1 && p[0] == '*');
            return IsMatch(s, si - 1, p, pi - 1);
        }

        if (p[pi] == '*')
        {
            if (pi == 0) return true;
            if (si == 0) return IsMatch(s, si, p, pi - 1);
            return IsMatch(s, si - 1, p, pi) || IsMatch(s, si, p, pi - 1);
        }

        return false;
    }
}