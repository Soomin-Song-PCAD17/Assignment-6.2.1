/// 1. Write a C# program to implement a stack by using array with push and pop operations. 
/// 

var stack = new Stack();
stack.Pop();
stack.Pop();
stack.Pop();
Console.WriteLine("Popped from empty stack.");
stack.Display();

stack.Push(1);
stack.Push("two");
stack.Push('a');
stack.Push(4);
Console.WriteLine("Pushed 1, 2, 'a', 4");
stack.Display();

stack.Pop();
stack.Push(5);
Console.WriteLine("Popped 4, then pushed 5");
stack.Display();

stack.Peek();
Console.WriteLine("Peeked top, should be no change");
stack.Display();


Console.ReadKey();


class Stack
{
    public int Size { get; set; }
    public Node? Top { get; set; }

    
    public Stack()
    {
        Size = 0;
        Top = null;
    }

    public void Push(object num)
    {
        Top = new Node(num,Top);
        Size++;
    }

    public object Pop()
    {
        if (Top == null) { return null; }
        object num = Top.Data;
        Top = Top.Next;
        Size--;
        return num;
    }

    public object Peek()
    {
        if(Top == null) { return null; }
        return Top.Data;
    }

    public bool IsEmpty()
    {
        return Top == null;
    }

    public void Display()
    {
        Console.WriteLine("\t-Stack-");
        Node pointer = Top;
        while (pointer != null)
        {
            Console.WriteLine(pointer.Data);
            pointer = pointer.Next;
        }
    }
}

public class Node
{
    public object Data;
    public Node Next;
    public Node(object data, Node next)
    {
        Data = data;
        Next = next;
    }
}
