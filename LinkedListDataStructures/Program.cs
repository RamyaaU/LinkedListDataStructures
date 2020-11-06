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
            Console.WriteLine(list.Search(30));
            list.Display();
        }
    }
}
