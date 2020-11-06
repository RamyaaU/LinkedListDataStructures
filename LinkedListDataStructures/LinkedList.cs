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
