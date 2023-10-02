namespace dsaproblem.Striver.Arrays.Medium;

public class StockBuyandSell
{
    public static void BuyAndSell(int[] a)
    {
        int buyIndex = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[buyIndex] > a[i])
                buyIndex = i;
        }
        Console.WriteLine(buyIndex);

        if (buyIndex == a.Length - 1)
        {
            Console.WriteLine("no transactions are done and the max profit = 0.");
        }
        else
        {

            int sellIndex = buyIndex;
            for (int i = buyIndex + 1; i < a.Length; i++)
            {
                if (a[sellIndex] < a[i])
                    sellIndex = i;
            }
            int profit = a[sellIndex] - a[buyIndex];

            Console.WriteLine($"Buy on Day {buyIndex + 1} - {a[buyIndex]} and Sell on Day {sellIndex + 1} - {a[sellIndex]} and Profit is {profit}");
        }
    }

    public static void BuyAndSellOptimal(int[] a)
    {
        int buyIndex = 0;
        int sellIndex = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[buyIndex] > a[i])
            {
                buyIndex = i;
                sellIndex = i;
            }

            if (i > buyIndex && a[i] > a[sellIndex])
            {
                sellIndex = i;
            }
        }
        
        if (buyIndex == sellIndex)
            Console.WriteLine("no transactions are done and the max profit = 0.");
        else
        {
            int profit = a[sellIndex] - a[buyIndex];
            Console.WriteLine($"Buy on Day {buyIndex + 1} - Price ({a[buyIndex]}) and Sell on Day {sellIndex + 1} - Price({a[sellIndex]}) and Profit is {profit}");
        }
    }
}