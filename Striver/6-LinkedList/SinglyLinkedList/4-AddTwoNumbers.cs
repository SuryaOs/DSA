namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class AddTwoNumbers
{
    public static void Brute()
    {
        int[] a = { 2, 4, 6 };
        int[] b = { 3, 8, 7 };
        Node nodeA = Intro.ArrayToLL(a);
        Node nodeB = Intro.ArrayToLL(b);
        Node head = SumNode(nodeA, nodeB);
        Intro.Print(head);
    }

    private static Node SumNode(Node nodeA, Node nodeB)
    {
        Node tempA = nodeA;
        Node tempB = nodeB;
        Node res = new Node(-1);
        Node finalres = res;
        int carry = 0;
        int cnt = 0;
        while (tempA != null || tempB != null || carry != 0)
        {
            int sum = 0;
            sum += carry;
            if (tempA != null)
            {
                sum += tempA.data;
                tempA = tempA.next;
            }

            if (tempB != null)
            {
                sum += tempB.data;
                tempB = tempB.next;
            }
            finalres.next = new Node(sum % 10);
            finalres = finalres.next;
            carry = sum / 10;
        }
        return res.next;
    }
}
