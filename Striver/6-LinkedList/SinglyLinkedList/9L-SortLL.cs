namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class SortLL
{
    public static void Brute()
    {
        int[] a = { 3, 1, 7, 5, 2 };
        Node A = Intro.ArrayToLL(a);
        Node sort = MergeSort(A);
        Intro.Print(sort);
    }
    // Huuu Huuuuuuu I Solved By Myself, After Seeing Comment Section (MergeSort, FindMiddle, MergeTwoSortedLL)
    public static Node MergeSort(Node head)
    {
        if (head.next == null) return head;
        Node mid = FindMiddle(head);
        Node front = mid.next;
        mid.next = null;
        Node A = MergeSort(head);
        Node B = MergeSort(front);
        return MergeTwoSortedLL.MergeDummy(A, B);
    }
    private static Node FindMiddle(Node head)
    {
        Node slow = head;
        Node fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}