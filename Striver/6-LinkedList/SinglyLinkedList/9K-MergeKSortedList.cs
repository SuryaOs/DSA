namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class MergeKSortedList
{
    public static void Brute()
    {
        int[] a = { 2, 4, 6 };
        int[] b = { 1, 5 };
        int[] c = { 1, 1, 3, 7 };
        int[] d = { 8 };
        Node A = Intro.ArrayToLL(a);
        Node B = Intro.ArrayToLL(b);
        Node C = Intro.ArrayToLL(c);
        Node D = Intro.ArrayToLL(d);
        Node[] heads = { A, B, C, D };
        // Merge(heads);
        // Node head = MergeTwo(null, C);
        // Node head = MergeK(heads);
        Node head = Optimal(heads);
        Intro.Print(head);
    }
    public static void Merge(Node[] heads)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < heads.Length; i++)
        {
            Node temp = heads[i];
            while (temp != null)
            {
                list.Add(temp.data);
                temp = temp.next;
            }
        }
        list.Sort();
        int[] arr = list.ToArray();
        Node head = Intro.ArrayToLL(arr);
        Intro.Print(head);
    }
    public static Node MergeK(Node[] heads)
    {
        // My Way 
        // Node dummy = new(-1);
        // Node res = dummy;
        // for (int i = 0; i < heads.Length; i++)
        // {
        //     dummy = MergeTwo(dummy, heads[i]);
        // }
        // return res.next;  No Worry , Just 1 Extra Loop ... You are there :)

        // Striver Way TF
        Node head = heads[0];
        for (int i = 1; i < heads.Length; i++)
        {
            head = MergeTwo(head, heads[i]);
        }
        return head;
    }
    public static Node MergeTwo(Node A, Node B)
    {
        Node dummy = new(-1);
        Node res = dummy;
        while (A != null && B != null)
        {
            if (A.data <= B.data)
            {
                dummy.next = A;
                dummy = dummy.next;
                A = A.next;
            }
            else
            {
                dummy.next = B;
                dummy = dummy.next;
                B = B.next;
            }
        }
        if (A != null)
        {
            dummy.next = A;
        }
        if (B != null)
        {
            dummy.next = B;
        }
        return res.next;
    }
    public static Node Optimal(Node[] heads)
    {
        PriorityQueue<Node, int> pq = new();
        for (int i = 0; i < heads.Length; i++)
        {
            pq.Enqueue(heads[i], heads[i].data);
        }
        Node dummy = new(-1);
        Node temp = dummy;
        int count = 0;
        while (pq.Count > 0)
        {
            var x = pq.Dequeue();
            temp.next = x;
            temp = temp.next;
            if (temp.next != null)
            {
                pq.Enqueue(temp.next, temp.next.data);
            }
        }
        return dummy.next;
    }
}