namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class FindPalindrome
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 2, 1 };
        Node head = Intro.ArrayToLL(a);
        bool isPalindrome = Palindrome(head);
        Console.WriteLine(isPalindrome);
    }
    // Find Mid Node
    // Reverse Second Half
    // Compare First and Second Half
    // Reverse Second Half (restoring its orignal position) and return true or false
    public static bool Palindrome(Node head)
    {
        // Find Mid Node
        Node fast = head;
        Node slow = head;
        // For Odd   AND      // For Even           
        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        // Reverse Second Half
        Node rHead = slow.next;
        Node sHead = ReverseASLL.ReverseLink(rHead);

        // Compare First Half With Second Half
        Node fHead = head;
        while (sHead != null)
        {
            if (fHead.data != sHead.data)
            {
                ReverseASLL.ReverseLink(rHead);
                return false;
            }
            fHead = fHead.next;
            sHead = sHead.next;
        }

        // Reverse Second Half
        rHead = slow.next;
        sHead = ReverseASLL.ReverseLink(rHead);
        return true;
    }
}