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
            //Creating a simple linked list
            //value = data enetered
            Node head = new Node(56);
            ////new node will have reference of head's next reference
            head.next = new Node(30);
            //and now head will refer to new node
            head.next.next = new Node(70);
        }
    }
}
