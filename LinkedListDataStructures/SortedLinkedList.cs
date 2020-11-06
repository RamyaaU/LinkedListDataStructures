using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructures
{
    public class SortedLinkedList
    {
        public Node head;
        /// <summary>
        /// Initializes a new instance of the <see cref="SortedLinkedList"/> class.
        /// </summary>
        public SortedLinkedList()
        {
            this.head = null;
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(int item)
        {
            Node node = new Node(item);
            Node current = head, previous = null;
            while (current != null && current.data < node.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public Node Pop()
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

        /// <summary>
        /// Removes the last node.
        /// </summary>
        /// <returns></returns>
        public Node PopLastNode()

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
                Node poppedNode = temp.next;
                temp.next = null;
                return poppedNode;
            }
        }

        /// <summary>
        /// Deletes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Delete(int item)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == item)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != item)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }

        /// <summary>
        /// Searches the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool Search(int item)
        {
            if (head == null)
                return false;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == item)
                        return true;
                    temp = temp.next;
                }
                return false;
            }
        }
        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
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