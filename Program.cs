internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
    }
}

public class LinkedList{
    public LinkedList(Node? head=null)
    {
        Head = head;
        Tail = head;
        _count = head is null ? 0 : 1;
    }

    private int _count;
    public Node? Head { get; set;}
    public Node? Tail { get; set;}
    

    // methods
    public int Count {get{
        return _count;
    }}
    public int? GetNodeData(Node node){
        return node is not null ? node.Value : null;
    }
    public void Insert(Node data){
        //TODO
    }
    public Node? Find(int val){
        //TODO
        return null;
    }
    public Node? DeleteAt(int index){
        //TODO
        return null;
    }
}
public class Node{
    public Node(int val, Node? previous=null, Node? next=null)
    {
        Previous = previous;
        Next = next;
        Value = val;
    }
    public Node? Previous { get; set; }
    public Node? Next { get; set; }
    public int Value { get; set; }
}