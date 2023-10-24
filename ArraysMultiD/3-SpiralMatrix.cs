namespace dsaproblem.ArraysMultiD;

public class SprialMatrix
{
    public static void Sprial(int[,] a)
    {
        // int[,] a = {
        //     {0, 1, 1},
        //     {7, 0, 1},
        //     {8, 0, 9}
        // };
        //00 01 02 12 22 21 20 10 11
        int left = 0;
        int right = a.GetLength(1) - 1; //2
        int top = 0;
        int bottom = a.GetLength(0) - 1; //2
        List<int> nums = new();
        //To Print top row, Left to Right
        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                nums.Add(a[top, i]);
            }
            top++; //1
                   //To print right col, top to bottom
            for (int i = top; i <= bottom; i++)
            {
                nums.Add(a[i, right]);
            }
            right--; //1

            if (top <= bottom)
            {
                //To print bottom row, right to left
                for (int i = right; i >= left; i--)
                {
                    nums.Add(a[bottom, i]);
                }
                bottom--; //1
            }

            if (left <= right)
            {
                //To print left column, bottom to up

                for (int i = bottom; i >= top; i--)
                {
                    nums.Add(a[i, left]);
                }
                left++; //1
            }
        }
        nums.ForEach(x => Console.Write(x));

    }
}