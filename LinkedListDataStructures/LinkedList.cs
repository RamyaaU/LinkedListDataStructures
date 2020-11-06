using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructures
{

    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public LinkedList()
        {
            this.head = null;
        }

        /// UC 2
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        internal void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        /// UC 3
        /// <summary>
        /// Appends the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        internal void Append(int item)
        {
            Node node = new Node(item);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// UC 4
        /// <summary>
        /// Inserts the element at specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="item">The item.</param>
        internal void Insert(int position, int item)
        {
            Node node = new Node(item);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                try
                {
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("Position out of range");
                }
            }
        }


        /// UC 5
        /// <summary>
        /// Pops this element at instance.
        /// </summary>
        /// <returns></returns>
        internal Node Pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            else
            {
                Node popped = head;
                head = head.next;
                return popped;
            }
        }

        /// UC 6
        /// <summary>
        /// Pops the last node.
        /// </summary>
        /// <returns></returns>
        internal Node PopLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node PopLastNode = temp.next;
                temp.next = null;
                return PopLastNode;
            }
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

    }
}
