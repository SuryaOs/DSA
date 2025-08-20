namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class FindIntersectPoint
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };
        int[] b = { 1, 2, 1, 3 };
        int[] common = { 7, 8, 9 };
        Node nodeA = Intro.ArrayToLL(a);
        Node nodeB = Intro.ArrayToLL(b);
        Node nodeC = Intro.ArrayToLL(common);
        nodeA.next.next = nodeC;
        nodeB.next.next = nodeC;

        // Node head = FindIntersect(nodeA, nodeB);
        // Node head = FindIntersectNoExtraSpace(nodeA, nodeB);
        Node head = Optimal(nodeA, nodeB);
        Intro.Print(head);
    }
    private static Node FindIntersect(Node headA, Node headB)
    {
        HashSet<Node> set = new();
        while (headA != null)
        {
            set.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            if (set.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
    private static Node FindIntersectNoExtraSpace(Node headA, Node headB)
    {
        Node tempA = headA;
        Node tempB = headB;
        int cA = 0, cB = 0;
        cA = Intro.LengthOfLL(tempA);
        cB = Intro.LengthOfLL(tempB);

        return cA < cB ? FindIt(tempB, tempA, cB - cA)
        : FindIt(tempA, tempB, cA - cB);
    }
    private static Node FindIt(Node t1, Node t2, int diff)
    {
        while (diff-- > 0)
        {
            t1 = t1.next;
        }
        while (t1 != null)
        {
            if (t1 == t2)
            {
                return t1;
            }
            t1 = t1.next;
            t2 = t2.next;
        }
        return null;
    }
    private static Node Optimal(Node tempA, Node tempB)
    {
        while (tempA != tempB)
        {
            tempA = tempA.next;
            tempB = tempB.next;
            if (tempA == tempB)
                return tempA;

            if (tempA == null) tempA = tempB;
            if (tempB == null) tempB = tempA;
        }
        return null;
    }
}