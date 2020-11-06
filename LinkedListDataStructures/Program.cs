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
            //adding item to the list
            list.Add(56);
            //appending items to the list
            list.Append(30);
            list.Append(70);
            //linkedlist sequence = 56->30->70
            list.Display();
        }
    }
}
