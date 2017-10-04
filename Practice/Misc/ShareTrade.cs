using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Misc
{
    class ShareTrade
    {

        public static void TestShareTrade()
        {
            int[] rates = new int[] { 1, 5, 2, 3, 7, 6, 4, 5 };
            Console.WriteLine(OptimalProfit(rates));
            rates = new int[] { 10, 8, 6, 5, 4, 2 };
            Console.WriteLine(OptimalProfit(rates));
            rates = new int[] { 1, 11, 2, 7, 12, 3, 2, 1 };
            Console.WriteLine(OptimalProfit(rates));
            rates = new int[] { 7, 4, 2, 5, 4, 3, 2, 4 };
            Console.WriteLine(OptimalProfit(rates));
            Console.ReadLine();
        }

        private static int OptimalProfit(int[] rates)
        {
            List<List<int>> splitRates = new List<List<int>>();

            int lastRate = int.MaxValue;
            for (int i = 0; i < rates.Length; i++)
            {
                if(rates[i] < lastRate)
                {
                    splitRates.Add(new List<int>());
                }
                splitRates.Last().Add(rates[i]);

                lastRate = rates[i];
            }

            splitRates = (from List<int> s in splitRates where s.Count > 1 select s).ToList();

            int profit = 0;
            if (splitRates.Count > 0) 
            { 
                foreach(List<int> increasingList in splitRates) 
                {
                    //
                    Console.WriteLine("Buy at {0} Sell at {1}", increasingList.First(), increasingList.Last());
                    profit += increasingList.Last() - increasingList.First();
                }
            }
            else
            {
                Console.WriteLine("No trades.");
            }

            return profit;
        }

    }
}
