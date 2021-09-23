using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{
    public class MaxInStack
    {
        private Stack<int> _mainStack = new Stack<int>();
        private Stack<int> _maxStack = new Stack<int>();


        public void Push(int value)
        {
            _mainStack.Push(value);
            if(_maxStack.Count == 0)
            {
                _maxStack.Push(value);
            }
            else
            {
                if(value > _maxStack.Peek())
                {
                    _maxStack.Push(value);
                }
                else
                {
                    _maxStack.Push(_maxStack.Peek());
                }
            }
        }

        public int Pop()
        {
            _maxStack.Pop();
            return _mainStack.Pop();
        }

        public int Max()
        {
            return _maxStack.Peek();
        }
    }
}
