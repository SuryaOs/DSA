namespace dsaproblem.Striver.LinkedList.SinglyLinkedList
{
    public class AddOneToLL
    {
        public static void Brute()
        {
            int[] a = { 1, 5, 9 };
            Node head = Intro.ArrayToLL(a);
            // Node newHead = AddOneToSLL(head);
            Node newHead = AddOneToSLLRecurse(head, 1);
            Intro.Print(newHead);

        }
        private static Node AddOneToSLL(Node head)
        {
            Node temp = head;
            Node newHead = ReverseASLL.ReverseLink(temp);
            temp = newHead;
            int sum = 1;
            while (temp != null && sum != 0)
            {
                sum += temp.data;
                temp.data = sum % 10;
                sum = sum / 10;

                temp = temp.next;
            }
            newHead = ReverseASLL.ReverseLink(newHead);
            if (sum != 0)
            {
                newHead = new Node(sum, newHead);
            }
            return newHead;
        }
        private static Node AddOneToSLLRecurse(Node temp, int sum)
        {
            int carry = RecurseIt(temp, sum);
            if (carry != 0)
            {
                temp = new Node(carry, temp);
            }
            return temp;
        }
        private static int RecurseIt(Node temp, int sum)
        {
            if (temp == null) return sum;
            sum = RecurseIt(temp.next, sum);
            sum += temp.data;
            temp.data = sum % 10;
            sum = sum / 10;
            return sum;
        }
    }
}