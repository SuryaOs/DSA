using dsaproblem.Striver.Arrays.Medium;
using StackNQueue.Implementation;
using StackNQueue.Learning;
using StackNQueue.MonotonicStack;
using StackNQueue.PreInPost;

namespace StackNQueue;

public class StackNQueueExtension
{
    public static void Practice()
    {
        // ImplementStackUsingList.Brute();
        // ImplementStackUsingArray.Brute();
        // ImplementQueueUsingArray.Brute();
        // ImplementStackUsingLL.Brute();
        // ImplementQueueUsingLL.Brute();
        // ImplementStackUsingQueue.Brute();
        // ImplementQueueUsingStack.Brute();
        // BalancedParantheses.Brute();
        // Minstack.Brute();
        // InfixToPostFix.Brute();
        // InfixToPrefix.Brute();
        // PostfixToInfix.Brute();
        // PrefixToInfix.Brute();
        // PostfixToPrefix.Brute();
        // PrefixToPostfix.Brute();
        // NextGreaterElement.Brute();
        // NextGreaterElementCircular.Brute();
        // NextSmallerElement.Brute();
        // PreviousSmallerElement.Brute();
        // TrappingRainWater.Brute();
        // SumOfSubArrayMinimum.Brute();
        // SumOfSubArrayMaximum.Brute();
        // SumOfSubArrayRange.Brute();
        // AsteroidCollision.Brute();
        // RemoveKDigits.Brute();
        // StockSpan.Brute();
        // LargestRectangleInHistogram.Brute();
        // MaximalRectangle.Brute();
        // SlidingWindowMaximum.Brute();
        // Celebrity.Brute();
        // LRUCacheFacade.Brute();
        // LFUCacheFacade.Brute();
        Brute();

        /*
            NGE, PGE, NSE, PSE (Monotonic Stack)
            Dequeue
        */
    }

    private static void Brute()
    {
        string s = "++x/*yzwu";
        Console.WriteLine(PostFixToInfix(s));
    }

    private static string PostFixToInfix(string s)
    {
        string ans = "";
        Stack<string> st = new();
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                st.Push(c.ToString());
            }
            else
            {
                var a = st.Pop();
                var b = st.Pop();
                ans = $"({b}{c}{a})";
                st.Push(ans);
            }
        }
        return ans;
    }

    private static int Priority(char a)
    {
        switch (a)
        {
            case '^':
                return 3;
            case '*':
            case '/':
                return 2;
            case '+':
            case '-':
                return 1;
            default:
                return -1;
        }
    }
}
