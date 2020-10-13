using System;

namespace study
{
    public partial class Study
    {
        public static int CoinChange(int[] coins, int amount)
        {
            int[] returnBills = new int[3];
            //int[] givenBills = {100, 50, 20};
            // sp holds the subproblems results
            int[] sp = new int[amount + 1];
            int[] usedBills = new int[amount + 1];

            // sp is the array to store the value of our subproblems
            //int[] sp = new int[amount+1];
            for (int i = 0; i < sp.Length; i++)
            {
                sp[i] = amount + 1;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                Console.Write(coins[i] + " ");
            }

            Console.Write("\n");

            // The answer to making change with minimum coins for 0 is 0
            sp[0] = 0;

            // Solve every subproblem from 1 to amount
            for (int i = 1; i <= amount; i++)
            {
                // For each coin
                for (int j = 0; j < coins.Length; j++)
                {
                    // Check if it is possible to use the coin to make change for the amount (i)
                    if (i >= coins[j])
                    {
                        // Find the result of the solved subproblem and add 1;
                        int res = sp[i - coins[j]] + 1;
                        // Take be minimum wich will represent the optimal result for the sub problem

                        if (res <= sp[i])
                        {
                            usedBills[i] = coins[j];
                        }

                        sp[i] = Math.Min(sp[i], res);
                    }
                }
            }

            // sp[amount] holds the result or the initial value (amount + 1) in which case, the solution was not possible
            for (int k = 0; k < usedBills.Length; k++)
            {
                Console.Write(k + " ");
            }

            Console.Write("\n");

            for (int k = 0; k < sp.Length; k++)
            {
                Console.Write(sp[k] + " ");
            }
            Console.Write("\n");

            for (int k = 0; k < usedBills.Length; k++)
            {
                Console.Write(usedBills[k] + " ");
            }


            returnBills[2] = usedBills[amount];
            returnBills[1] = usedBills[amount - returnBills[2]];
            //returnBills[0] = usedBills[amount - returnBills[2] - returnBills[1]];

            Console.WriteLine(returnBills[2]);
            Console.WriteLine(returnBills[1]);
            Console.WriteLine(returnBills[0]);

            return sp[amount] > amount ? -1 : sp[amount];
        }
    }
}
