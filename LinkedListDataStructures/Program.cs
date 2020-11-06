using System;

namespace LinkedListDataStructures
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Linked List!");
            //creating a list
            LinkedList list = new LinkedList();
            //adding items to the list
            list.Add(70);
            list.Add(30);
            list.Add(56);
            //linkedlist sequence = 56->30->70
            list.Display();
        }
    }
}
