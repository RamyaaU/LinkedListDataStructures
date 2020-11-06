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
            //appending item to the list
            list.Append(70);
            //inserting item to the list at 2nd position
            list.Insert(2, 30);
            list.Insert(4, 80);
            //linkedlist sequence = 56->30->70->80
            list.Display();
        }
    }
}
