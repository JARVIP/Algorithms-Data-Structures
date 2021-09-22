using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{
    public class ReverseLinkedListInPlace
    {
        private string[] _words;

        public ReverseLinkedListInPlace(string[] words)
        {
            _words = words;
        }

        public LinkedList<string> Solution()
        {
            LinkedList<string> sentence = new LinkedList<string>(_words);

            var first = sentence.First;
            var second = sentence.First.Next;
            //cause System.Collections.Generic.LinkedList Next (next node) doesn't implements set function we can't change references and have to store value in front of nodes
            while (second != null)
            {
                sentence.AddBefore(first, second.Value);
                first = first.Previous;
                var next = second.Next;
                sentence.Remove(second);
                second = next;
            }

            return sentence;
        }
    }
}
