namespace StackNQueue.Implementation;

public class Celebrity
{
    /*
    celebrity is known by all and knows none
        Knows = 0
        Knows Me = N - 1
    */
    public static void Brute()
    {
        int[,] a =
        {
            { 0, 1, 0, 0 },
            { 0, 0, 0, 0 },
            { 1, 1, 0, 0 },
            { 0, 1, 0, 0 }
        };
        Optimal(a); // TC : O(3N), SC : O(N)
        MoreOptimale(a); // TC : O(2N), SC : O(1)
    }

    private static void Optimal(int[,] a)
    {
        Stack<int> participants = new(); // SC : O(N)
        for (int i = 0; i < a.GetLength(0); i++) // TC : O(N)
        {
            participants.Push(i);
        }
        int candidate = -1;
        while (participants.Count > 1) // TC : O(N)
        {
            int cA = participants.Pop();
            int cB = participants.Pop();
            if (Knows(a, cA, cB))
            {
                candidate = cB;
                participants.Push(cB);
            }
            else
            {
                candidate = cA;
                participants.Push(cA);
            }
        }
        for (int i = 0; i < a.GetLength(0); i++) // TC : O(N)
        {
            if (candidate != i)
            {
                if (Knows(a, candidate, i) || !Knows(a, i, candidate))
                {
                    participants.Pop();
                    break;
                }
            }
        }
        if (participants.Count == 0)
            Console.WriteLine("No Celebrities");
        else
            Console.WriteLine($"{candidate} is celebrity");
    }

    private static void MoreOptimale(int[,] a)
    {
        int top = 0;
        int bottom = a.GetLength(1) - 1;
        while (top < bottom)
        {
            if (Knows(a, top, bottom))
            {
                top++;
            }
            else if (Knows(a, bottom, top))
            {
                bottom--;
            }
            else
            {
                top++;
                bottom--;
            }
        }
        bool celebrityExists = true;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            if (i != top)
            {
                if (Knows(a, top, i) || !Knows(a, i, top))
                {
                    celebrityExists = false;
                    break;
                }
            }
        }
        if (celebrityExists)
        {
            Console.WriteLine($"{top} is the celebrity");
        }
        else
        {
            Console.WriteLine("No Celebrity");
        }
    }

    private static bool Knows(int[,] a, int candidate, int i)
    {
        return a[candidate, i] == 1;
    }
}
