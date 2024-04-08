// https://leetcode.com/problems/coin-change-ii/description/

namespace AlgoPlay;

// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
// 
// Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.
// 
// You may assume that you have an infinite number of each kind of coin.
// 
// The answer is guaranteed to fit into a signed 32-bit integer.
// 
//  
// 
// Example 1:
// 
// Input: amount = 5, coins = [1,2,5]
// Output: 4
// Explanation: there are four ways to make up the amount:
// 5=5
// 5=2+2+1
// 5=2+1+1+1
// 5=1+1+1+1+1
// Example 2:
// 
// Input: amount = 3, coins = [2]
// Output: 0
// Explanation: the amount of 3 cannot be made up just with coins of 2.
// Example 3:
// 
// Input: amount = 10, coins = [10]
// Output: 1
//  
// 
// Constraints:
// 
// 1 <= coins.length <= 300
// 1 <= coins[i] <= 5000
// All the values of coins are unique.
// 0 <= amount <= 5000


public class P518CoinChange
{
    public class Solution
    {
        public int Change(int amount, int[] coins)
        {
            int[] amountStack = new int[amount + 1];
            
            // zero amount = no money, no problem
            amountStack[0] = 1; 

            foreach (var coin in coins)
            {
                for (var i = coin; i <= amount; i++)
                {
                    amountStack[i] += amountStack[i - coin];
                }
            }

            return amountStack[amount];
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