using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructures
{ 
    //The node of the linked list contains data part and link part
    //The link will contain the address of next node and is initialized to null
    class Node
    {
        //data is entered
        public int data;
        //Next is the pointer to the next node in the list
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}