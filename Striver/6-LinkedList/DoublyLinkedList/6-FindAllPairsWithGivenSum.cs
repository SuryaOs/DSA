namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class FindAlPairsWithGivenSum
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 9 };
        Node node = Intro.ArrayToDLL(a);
        var res = FindPairOptial(node, 5);
        foreach (var pair in res)
        {
            Console.WriteLine(pair.Key.data + " : " + pair.Value.data);
        }
    }

    // My own solution
    private static Dictionary<Node, Node> FindPair(Node head, int sum)
    {
        Node tempA = head;
        Node tempB = head.next;
        int res = 0;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        while (tempB != null)
        {
            res = tempA.data + tempB.data;
            if (res == sum)
            {
                map.Add(tempA, tempB);
                tempA = tempA.next;
                tempB = tempA.next;
            }
            else if (res < sum)
            {
                tempB = tempB.next;
            }
            else
            {
                return map;
            }
        }
        return null;
    }
    private static Dictionary<Node, Node> FindPairBrute(Node head, int sum)
    {
        Node tempA = head;
        Node tempB = head;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        while (tempA != null)
        {
            tempB = tempA.next;
            while (tempB != null && tempB.data + tempA.data <= sum)
            {
                if (tempB.data + tempA.data == sum)
                {
                    map.Add(tempA, tempB);
                }
                tempB = tempB.next;
            }
            tempA = tempA.next;
        }
        return map;
    }
    private static Dictionary<Node, Node> FindPairOptial(Node head, int sum)
    {
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        if (head == null) return map;
        Node tempA = head;
        Node tail = head;
        while (tempA != null)
        {
            tail = tempA;
            tempA = tempA.next;
        }
        tempA = head;
        while (tempA.data < tail.data)
        {
            var res = tempA.data + tail.data;
            if (res == sum)
            {
                map.Add(tempA, tail);
                tail = tail.back;
                tempA = tempA.next;
            }
            else if (res > sum)
            {
                tail = tail.back;
            }
            else
            {
                tempA = tempA.next;
            }
        }
        return map;
    }
}