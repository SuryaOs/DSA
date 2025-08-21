namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class DeleteAllOccurenceOfKey {
    public static void Brute()
    {
        int[] a = { 10, 4, 10, 10, 6, 10 };
        Node head = Intro.ArrayToDLL(a);
        Node newHead = Delete(head, 6);
        Intro.Print(newHead);
    }
    private static Node Delete(Node head, int key)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == key)
            {
                Node front = temp.next;
                Node back = temp.back;

                if(front != null) front.back = back;
                if(back != null) back.next = front;
                else head = front;
            }
            temp = temp.next;
        }
        return head;
    }
}