using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class NthElementOfALinkedList
    {
        public int? Solve(LinkedListNode<int> list, int n)
        {
            var leftPointer = list;
            var rightPointer = list;

            for(int i = 0; i < n; i++)
            {
                if(rightPointer == null)
                {
                    return null;
                }
                rightPointer = rightPointer.Next;
            }

            while(rightPointer != null)
            {
                rightPointer = rightPointer.Next;
                leftPointer = leftPointer.Next;
            }

            return leftPointer.Value;
        }
    }
}
