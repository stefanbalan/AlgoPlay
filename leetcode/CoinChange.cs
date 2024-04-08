// https://leetcode.com/problems/coin-change-ii/description/

// to read:
// https://textbooks.cs.ksu.edu/cc310/6-recursion/8-converting-recursion-to-iteration/
// https://www.baeldung.com/cs/factorial-recursion-to-iteration
// https://www.baeldung.com/cs/convert-recursion-to-iteration
// https://www.baeldung.com/cs/tail-vs-non-tail-recursion

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var r = s.Change(500, [3, 5, 7, 8, 9, 10, 11]);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(r);
            Console.BackgroundColor = ConsoleColor.Black;
        }



        public class Solution
        {
            public int Change(int amount, int[] coins)
            {
                int[] dp = new int[amount + 1];
                dp[0] = 1; // Base case: There's one way to make change for 0.

                foreach (int coin in coins)
                {
                    for (int i = coin; i <= amount; i++)
                    {
                        dp[i] += dp[i - coin];
                    }
                }

                return dp[amount];
            }
        }

        public class Solution1
        {
            public int Change(int amount, int[] coins)
            {
                int solutions = 0;

                Greedy(amount, coins, coins.Length - 1, ref solutions);

                return solutions;
            }

            public void Greedy(int amount, int[] coins, int maxIndex, ref int solutions)
            {
                if (amount == 0)
                {
                    solutions += 1;
                    return;
                }

                if (amount < 0) return;

                for (int i = maxIndex; i >= 0; i--)
                {
                    Greedy(amount - coins[i], coins, i, ref solutions);
                }
            }
        }
    }
}