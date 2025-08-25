using dsaproblem.Striver.Arrays.Medium.SetMatrixZero;

namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class FlattenLL
{
    public static void Brute()
    {
        int[] a = { 3, 2, 1, 4, 5 };
        var nH = Nodee.ArrayToLL(a);
        nH.next.child = new Nodee(10);
        nH.next.next.child = new Nodee(7, null, new Nodee(11, null, new Nodee(12)));
        nH.next.next.next.child = new Nodee(9);
        nH.next.next.next.next.child = new Nodee(6);
        // BruteForce(nH);
        Optimal(nH);

    }
    private static void BruteForce(Nodee head)
    {
        Nodee temp = head;
        List<int> nums = new();
        // add numbers to list time-(n*m), space-(n*m)
        while (temp != null)
        {
            Nodee t2 = temp;
            while (t2 != null)
            {
                nums.Add(t2.data);
                t2 = t2.child;
            }
            temp = temp.next;
        }
        // sort the list (x log x) where x = n*m
        nums.Sort();

        // covert list to vertical linked list. time ->(n*m), space (n*m)
        Nodee res = new Nodee(nums[0]);
        Nodee nH = res;
        for (int i = 1; i < nums.Count; i++)
        {
            res.child = new Nodee(nums[i]);
            res = res.child;
        }

        // print child nodes 
        while (nH != null)
        {
            Console.WriteLine(nH.data);
            nH = nH.child;
        }
        // time - o(n*m) * 2 + o(xlogx)
        // space - o(n*m) * 2
    }
    private static void Optimal(Nodee head)
    {
        
    }
}

#region PreRequisites
public class Nodee
{
    public int data;
    public Nodee next;
    public Nodee child;
    public Nodee(int data, Nodee next, Nodee child)
    {
        this.data = data;
        this.next = next;
        this.child = child;
    }
    public Nodee(int data, Nodee next)
    {
        this.data = data;
        this.next = next;
        this.child = null;
    }
    public Nodee(int data)
    {
        this.data = data;
        this.next = null;
        this.child = null;
    }
    public static Nodee ArrayToLL(int[] a)
    {
        Nodee head = new(a[0], null);
        Nodee temp = head;
        for (int i = 1; i < a.Length; i++)
        {
            temp.next = new(a[i], null);
            temp = temp.next;
        }
        return head;
    }
    public static Nodee Print(Nodee head)
    {
        Nodee temp = head;
        while (temp != null)
        {
            Console.Write(temp.data);
            Nodee t2 = temp.child;
            while (t2 != null)
            {
                Console.Write(" -> ");
                Console.Write(t2.data);
                t2 = t2.child;
            }
            Console.WriteLine();
            temp = temp.next;
        }
        return temp;
    }
}
#endregion PreRequisites