var list = new CustomLinkedList();
list.Head = new ListNode(10);
list.Head.Next = new ListNode(15);
list.Head.Next.Next = new ListNode(20);

list.Head= ReverseLinkedList(list.Head);
PrintList(list.Head);
Console.ReadLine();




static ListNode ReverseLinkedList(ListNode head)
{
    if (head == null) return head;

    ListNode current = head, previous = null, next = null;

    while (current != null)
    {
        next = current.Next; 
        current.Next = previous; 
        previous = current; 
        current = next; 
    }

    return previous;

}

static void PrintList(ListNode head)
{
    ListNode current = head;
    while (current != null)
    {
        Console.Write(current.Value + " ");
        current = current.Next;
    }
    Console.WriteLine();
}

public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }
    public ListNode(int value)
    {
        Value = value;
        Next = null;
    }
}
public class CustomLinkedList
{
    public ListNode Head { get; set; }
    public CustomLinkedList()
    {
        Head = null;
    }
}