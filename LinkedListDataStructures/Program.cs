using System;
using System.Collections.Generic;

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
            //popping last element from the list
            list.PopLastNode();
            //linkedlist sequence = 56->30
            list.Display();
        }
    }
}