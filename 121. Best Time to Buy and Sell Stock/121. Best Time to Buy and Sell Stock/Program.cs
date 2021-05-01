using System;

namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int bestDay = MaxProfit(prices);

            Console.WriteLine(bestDay);
        }

        static int MaxProfit(int[] prices)
        {
            //we want to find the days of the week that will give the lowest buy options and highest sell option
            //go through the array and compare the value to the next value 
            // what is the difference and store it ...
            // you want to iterate through the array and compare the next value to the current value ... nest for loop

            //initialize
            int greatestProfit = 0;
            int highestPrice = 0;
            int lowestPrice = int.MaxValue;

            //loop
            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < lowestPrice)
                {
                    lowestPrice = prices[i];
                }
                else if(prices[i] - lowestPrice > highestPrice)
                {
                    highestPrice = prices[i] - lowestPrice;
                }
            }
            return highestPrice;

            // O(N^2) time ... too long on LeetCode
            /*for (int i = 0; i < prices.Length; i++) // {7,1,5,3,6,4}
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    // we want to compare and store the different
                    if(prices[j] - prices[i] > greatestProfit) // you want to subtract j from i because you are sellign on j and buying on i
                    {
                        greatestProfit = prices[j] - prices[i];
                        buyingPrice = prices[i];
                        sellingPrice = prices[j];
                    }
                }
                
                return greatestProfit;
            }
            */
        }
    }
}
