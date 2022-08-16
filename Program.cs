internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var linkedList = new LinkedList(new Node(1));
        linkedList.Insert(new Node(3));
        linkedList.Insert(new Node(6));
        linkedList.Insert(new Node(10));
        linkedList.Insert(new Node(17));
        linkedList.DeleteAt(3);
        linkedList.GetAll();
    }
}

public class LinkedList{
    public LinkedList(Node? head=null)
    {
        Head = head;
        _count = head is null ? 0 : 1;
    }

    private int _count;
    private bool _isEmpty => _count == 0;
    public Node? Head { get; set;}

    // methods
    public void GetAll(){
        if ( _isEmpty ){
            Console.WriteLine("No nodes in list");
            return;
        }
        var currentNode = Head;
        do{
            Console.Write(currentNode.Value + " -> ");
            currentNode = currentNode.Next;
        }while(currentNode is not null);
        Console.Write("null");
    }
    public int Count {get{
        return _count;
    }}
    public int? GetNodeData(Node node){
        return node is not null ? node.Value : null;
    }
    public void Insert(Node data){ // O(1)
        data.Next = Head;
        Head = data;
        _count++;
    }
    public Node? Find(int val){
        if ( _isEmpty ){
            Console.WriteLine("No nodes in list");
            return null;
        }

        var currentNode = Head;
        while(currentNode is not null){ // O(n)
            if (currentNode.Value == val) return currentNode;
            currentNode = currentNode.Next;
        }
        return null;
    }
    public Node? DeleteAt(int index){
        if ( _isEmpty ) return null;
        if ( index > Count - 1 ) return null;
        if ( index == 0 ) {            
            var tempHead = Head;
            Console.WriteLine("Deleting " + tempHead + " at index: 0");
            Head = tempHead.Next;
            _count--;
            return tempHead;
        };

        var currentNode = Head;
        for(int i = 0; i != index - 1 ; i++){ // stop one short of the given index, fix node that points to the toBeDeleted node
            currentNode = currentNode.Next;
        }
        var nodeToDelete = currentNode.Next;
        Console.WriteLine("Deleting " + nodeToDelete.Value + " at index: " + index);
        currentNode.Next = nodeToDelete.Next;
        _count--;
        return nodeToDelete;
    }
}
public class Node{
    public Node(int val, Node? next=null)
    {
        Next = next;
        Value = val;
    }
    public Node? Next { get; set; }
    public int Value { get; set; }
}