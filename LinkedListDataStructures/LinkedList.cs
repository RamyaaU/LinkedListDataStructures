using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructures
{
    public class LinkedList
    {
        public Node head;
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
        public void Add(int item)
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
        public void Append(int item)
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

        /// UC 4 AND UC 8
        /// <summary>
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="item">The item.</param>
        public void Insert(int position, int item)
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
                    System.Console.WriteLine("Index out of bounds");
                }
            }
        }

        /// UC 5
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

        /// UC 6
        /// <summary>
        /// Removes the last node.
        /// </summary>
        /// <param name="remove">The remove.</param>
        /// <returns></returns>
        public Node PopLastNode(int remove)

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

        /// UC 7
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

        /// UC 9
        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int size = 0;
            Node n = head;
            if (head == null)
            {
                Console.WriteLine($"Linked List is Empty, Size is {size}");
            }
            else
            {
                size = 1;
                while (n.next != null)
                {
                    n = n.next;
                    size++;
                }
                Console.WriteLine($"Linked List Size is {size}");
            }
            return size;
        }

        /// UC 9
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

