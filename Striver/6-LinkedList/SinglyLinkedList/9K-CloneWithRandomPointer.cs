namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class CloneWithRandomPointer
{
    public static void Brute()
    {
        int[] a = { 7, 13, 11, 10, 1 };
        RandomNode rn = ToRN(a);
        rn.random = null;
        rn.next.random = rn;
        rn.next.next.random = rn.next.next.next.next;
        rn.next.next.next.random = rn.next.next;
        rn.next.next.next.next.random = rn;

        // var head = CloneWithMap(rn);
        var head = CloneWithoutSpace(rn);
        PrintRN(head);
    }
    public static RandomNode CloneWithMap(RandomNode rn)
    {
        RandomNode temp = rn;
        Dictionary<RandomNode, RandomNode> copyNode = new();
        while (temp != null)
        {
            // copyNode.Add(temp, temp); // Mistake Not Cloning, Copying The Reference Buddy
            copyNode[temp] = new RandomNode(temp.data);
            temp = temp.next;
        }
        // RandomNode dummy = new(-1); // Wrong
        // RandomNode dummyHead = dummy; // Wrong
        temp = rn;
        while (temp != null)
        {
            RandomNode cN = copyNode[temp];
            cN.next = temp.next != null ? copyNode[temp.next] : null;
            cN.random = temp.random != null ? copyNode[temp.random] : null;
            temp = temp.next;
        }
        return copyNode[rn];
    }
    public static RandomNode CloneWithoutSpace(RandomNode rn)
    {
        RandomNode temp = rn;
        // 
        while (temp != null)
        {
            RandomNode copyNode = new(temp.data);
            copyNode.next = temp.next;
            temp.next = copyNode;
            temp = copyNode.next;
        }
        temp = rn;
        while (temp != null)
        {
            RandomNode copyNode = temp.next;
            copyNode.random = temp.random != null ? temp.random.next : null;
            temp = copyNode.next;
        }
        temp = rn;
        RandomNode dummy = new(-1);
        RandomNode dummyHead = dummy;
        while (temp != null)
        {
            RandomNode copyNode = temp.next;
            dummy.next = copyNode;
            dummy = dummy.next;
            temp.next = copyNode.next;
            temp = temp.next;
        }
        return dummyHead.next;
    }
    public static RandomNode ToRN(int[] a)
    {
        RandomNode res = new RandomNode(a[0]);
        RandomNode head = res;
        for (int i = 1; i < a.Length; i++)
        {
            var node = new RandomNode(a[i]);
            res.next = node;
            res = res.next;
        }
        return head;

    }
    public static void PrintRN(RandomNode rn)
    {
        while (rn != null)
        {
            Console.WriteLine($"Data : {rn.data} , Random : {rn.random?.data}");
            rn = rn.next;
        }
    }
}
public class RandomNode
{
    public int data;
    public RandomNode next;
    public RandomNode random;
    public RandomNode(int data)
    {
        this.data = data;
        this.next = null;
        this.random = null;
    }
}