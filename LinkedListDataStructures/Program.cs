using System;

namespace LinkedListDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Linked List!");
            //creating a list
            LinkedList list = new LinkedList();
            //adding items to the list
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            //calling pop function
            Node p = list.Pop();
            Console.WriteLine(p.data);
            //linkedlist sequence = 30->70
            list.Display();
        }
    }
}
