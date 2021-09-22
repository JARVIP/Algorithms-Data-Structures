using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{
    public class LinkedListMiddleNode
    {
        private string[] _words;

        public LinkedListMiddleNode(string[] words)
        {
            _words = words;
        }

        public string Solution()
        {
            LinkedList<string> sentence = new LinkedList<string>(_words);

            var last = sentence.First;
            var middle = sentence.First;

            while (last.Next != null && last.Next.Next != null)
            {
                last = last.Next.Next;
                middle = middle.Next;
            }
            return middle.Value;
        }
    }
}
