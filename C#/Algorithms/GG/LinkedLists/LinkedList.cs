using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GG.LinkedLists
{
    internal class LinkedList
    {
        internal Node head;

        internal void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal Node NewNode(int data)
        {
            Node x = new Node(data);
            return x;
        }
    }
}
