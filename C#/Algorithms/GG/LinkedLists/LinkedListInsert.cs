using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GG.LinkedLists
{
    internal static class LinkedListInsert
    {
        public static void SortedInsert(this LinkedList list,Node node)
        {
          
            if (list.head == null || list.head.data >= node.data)
            {
                node.next = list.head;
                list.head = node;
            }
            else
            {
                Node current = list.head;
                while(current.next != null && current.next.data < node.data)
                {
                    current= current.next;  
                }

                node.next = current.next;
                current.next = node;
            }
        }
    }
}
