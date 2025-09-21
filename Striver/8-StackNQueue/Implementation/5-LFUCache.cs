namespace StackNQueue.Implementation;

public class LFUCacheFacade
{
    public static void Brute()
    {
        LFUCache lFUCache = new(2);
        lFUCache.Put(1, 10);
        lFUCache.Put(2, 10);
        Console.WriteLine(lFUCache.Get(1));
        lFUCache.Put(3, 30);
        Console.WriteLine(lFUCache.Get(2));
        Console.WriteLine(lFUCache.Get(3));
        lFUCache.Put(4, 40);
        Console.WriteLine(lFUCache.Get(1));
        Console.WriteLine(lFUCache.Get(3));
        Console.WriteLine(lFUCache.Get(4));
    }
}

public class FNode
{
    public int count = 1;

    public int key;
    public int value;
    public FNode next;
    public FNode back;

    public FNode(int key, int value)
    {
        this.key = key;
        this.value = value;
        this.next = null;
        this.back = null;
    }
}

public class DoublyLinkedList
{
    private FNode head = new(-1, -1);
    public FNode tail = new(-1, -1);

    public int size { get; private set; } = 0;

    public DoublyLinkedList()
    {
        head.next = tail;
        tail.back = head;
    }

    public void AddToFront(FNode node)
    {
        node.next = head.next;
        node.back = head;

        head.next.back = node;
        head.next = node;
        size++;
    }

    public void RemoveNode(FNode node)
    {
        node.back.next = node.next;
        node.next.back = node.back;

        size--;
    }

    public void Evict()
    {
        var lru = tail.back;
        RemoveNode(lru);
    }
}

public class LFUCache
{
    private Dictionary<int, DoublyLinkedList> freqMap = new();
    private Dictionary<int, FNode> dict = new();
    private int capacity;
    private int minFreq = 0;

    public LFUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public void Put(int key, int val)
    {
        if (!dict.ContainsKey(key))
        {
            FNode newNode = new(key, val);
            if (dict.Count == capacity)
            {
                var dll = freqMap[minFreq];
                dict.Remove(dll.tail.back.key);
                dll.Evict();
            }
            dict.Add(key, newNode);

            DoublyLinkedList newList;
            if (!freqMap.ContainsKey(newNode.count))
            {
                newList = new DoublyLinkedList();
            }
            else
            {
                newList = freqMap[newNode.count];
            }
            newList.AddToFront(newNode);
            freqMap[newNode.count] = newList;
            minFreq = 1;
        }
        else
        {
            var FNode = dict[key];
            FNode.value = val;
            UpdateNode(FNode);
        }
    }

    public int Get(int key)
    {
        if (!dict.ContainsKey(key))
            return -1;

        var nodeToReturn = dict[key];
        UpdateNode(nodeToReturn);

        return nodeToReturn.value;
    }

    private void UpdateNode(FNode node)
    {
        // get the list from frequency map based on the node freqeuncy
        var currentFreq = node.count;
        var dll = freqMap[node.count];

        // remove the node from list
        dll.RemoveNode(node);

        // if current list is the last list that has lowest frequency and current node is the only node
        // remove entire list and increase min freq by 1
        if (minFreq == currentFreq && dll.size == 0)
        {
            minFreq++;
        }

        // promte the node to next frequency
        node.count++;

        // add current node to another list that has frequency
        // if we do not have list, create new list
        DoublyLinkedList newList;
        if (freqMap.ContainsKey(node.count))
        {
            newList = freqMap[node.count];
        }
        else
        {
            newList = new DoublyLinkedList();
        }
        newList.AddToFront(node);
        freqMap[node.count] = newList;
    }
}
