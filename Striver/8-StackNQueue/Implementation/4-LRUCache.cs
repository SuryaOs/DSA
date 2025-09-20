using System.Runtime.CompilerServices;

namespace StackNQueue.Implementation;

public class Node
{
    public int key;
    public int value;
    public Node next;
    public Node back;

    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
        this.next = null;
        this.back = null;
    }
}

public class LRUCacheFacade
{
    public static void Brute()
    {
        LRUCache lRUCache = new(2);
        lRUCache.Put(1, 1); // cache is {1=1}

        lRUCache.Put(2, 2); // cache is {1=1, 2=2}

        System.Console.WriteLine(lRUCache.Get(1));
        ; // return 1

        lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}

        System.Console.WriteLine(lRUCache.Get(2)); // returns -1 (not found)

        lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}

        System.Console.WriteLine(lRUCache.Get(1));
        ; // return -1 (not found)

        System.Console.WriteLine(lRUCache.Get(3));
        ; // return 3

        System.Console.WriteLine(lRUCache.Get(4));
        ; // return 4
    }
}

public class LRUCache
{
    private readonly Dictionary<int, Node> dict = new();
    private readonly int capacity;
    private readonly Node head = new(-1, -1);
    private readonly Node tail = new(-1, -1);

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        head.next = tail;
        tail.back = head;
    }

    public void Put(int key, int value)
    {
        if (!dict.ContainsKey(key))
        {
            if (dict.Count == capacity)
            {
                Node LRU = tail.back;
                RemoveNode(LRU);
                dict.Remove(LRU.key);
            }
            AddNewNode(key, value);
        }
        else
        {
            Node node = dict[key];
            node.value = value;

            MoveToFront(node);
        }
    }

    public int Get(int key)
    {
        if (dict.ContainsKey(key))
        {
            Node node = dict[key];
            MoveToFront(node);
            return node.value;
        }
        return -1;
    }

    private void AddNewNode(int key, int value)
    {
        Node newNode = new(key, value);
        dict.Add(key, newNode);

        AddToFront(newNode);
    }

    private void MoveToFront(Node node)
    {
        RemoveNode(node);
        AddToFront(node);
    }

    private void RemoveNode(Node node)
    {
        node.back.next = node.next;
        node.next.back = node.back;
    }

    private void AddToFront(Node newNode)
    {
        newNode.next = head.next;
        newNode.back = head;

        head.next.back = newNode;
        head.next = newNode;
    }

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.key} - {temp.value}");
            temp = temp.next;
        }
    }
}
