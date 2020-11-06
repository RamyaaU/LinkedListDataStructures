using System;

namespace LinkedListDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Linked List!");
            SortedLinkedList list = new SortedLinkedList();
            //adds items to list
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(40);
            Console.WriteLine("List size is: " ,list.Size());
            ///linkedlist sequence = 30->40->56->70
            list.Display();
        }
    }
}
