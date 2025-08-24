namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class MergeTwoSortedLL
{
    public static void Brute()
    {
        int[] a = { 1, 3, 3, 6, 11, 14 };
        int[] b = { 2, 4, 8, 10 };
        Node A = Intro.ArrayToLL(a);
        Node B = Intro.ArrayToLL(b);
        Node res = MergeDummy(A, B);
        Intro.Print(res);
    }

    // Link InterChange Su*****X; Use DummyNode You Dummy
    public static Node Merge(Node A, Node B)
    {
        Node tempA = A;
        Node tempB = B;
        while (tempA != null && tempB != null) // && tempA.next != null && tempB.next != null
        {
            Console.WriteLine(tempA.data);
            Console.WriteLine(tempB.data);
            if (tempA.next != null && tempA.data == tempA.next.data)
            {
                tempA = tempA.next;
                continue;
            }
            if (tempB.next != null && tempB.data == tempB.next.data)
            {
                tempA.next = tempB;
                tempB = tempB.next;
                continue;
            }
            if (tempA.data < tempB.data && tempA.next.data > tempB.data)
            {
                Node front = tempA.next;
                tempA.next = tempB;
                tempA = front;
            }
            else if (tempB.data < tempA.data)
            {
                if (tempB.next == null || tempB.next.data > tempA.data)
                {
                    Node front = tempB.next;
                    tempB.next = tempA;
                    tempB = front;
                }
                else
                {
                    tempB = tempB.next;
                }
            }
        }
        return A;
    }
    public static Node MergeDummy(Node A, Node B)
    {
        Node dummy = new(-1);
        Node temp = dummy;
        Node tempA = A;
        Node tempB = B;
        while (tempA != null && tempB != null)
        {
            if (tempA.data <= tempB.data)
            {
                temp.next = tempA;
                temp = temp.next;
                tempA = tempA.next;
            }
            else
            {
                temp.next = tempB;
                temp = temp.next;
                tempB = tempB.next;
            }
        }
        if (tempA != null)
        {
            temp.next = tempA;
        }
        if (tempB != null)
        {
            temp.next = tempB;
        }
        return dummy.next;
    }
}