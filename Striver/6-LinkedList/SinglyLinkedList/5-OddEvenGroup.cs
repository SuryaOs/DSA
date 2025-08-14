namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class OddEvenGroup
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        Node node = Intro.ArrayToLL(a);
        Node newHead = OddEvenLink(node);
        Intro.Print(newHead);
    }

    private static Node OddEven(Node head)
    {
        Node temp = head;
        List<int> list = new List<int>();

        // odd
        while (temp != null && temp.next != null)
        {
            list.Add(temp.data);
            temp = temp.next.next;
        }

        // above checking temp.next is not null , so the last remaining won't be added if array has odd length
        if (temp != null)
            list.Add(temp.data);

        // even
        temp = head.next;
        while (temp != null && temp.next != null)
        {
            list.Add(temp.data);
            temp = temp.next.next;
        }

        // above checking temp.next is not null , so the last remaining won't be added if array has even length
        if (temp != null)
            list.Add(temp.data);
        temp = head;

        int index = 0;
        while (temp != null)
        {
            temp.data = list[index++];
            temp = temp.next;
        }
        return head;
    }

    private static Node OddEvenLink(Node head)
    {
        if (head == null || head.next == null)
            return head;
        Node odd = head;
        Node eHead = head.next;
        Node even = eHead;

        while (even != null && even.next != null)
        {
            odd.next = odd.next.next;
            odd = odd.next;
            even.next = even.next.next;
            even = even.next;
        }
        odd.next = eHead;
        return head;
    }
}
