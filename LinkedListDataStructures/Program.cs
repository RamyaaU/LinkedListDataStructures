using System;

namespace LinkedListDataStructures
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
/        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Linked List!");
            //creating a list
            LinkedList list = new LinkedList();
            //appending the items to list
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Append(100);
            //inserting item to list
            list.Insert(4, 12);
            Console.WriteLine(list.Search(10));
            ////linkedlist sequence = 56->30->40->70
            list.Display();
        }
    }
}
