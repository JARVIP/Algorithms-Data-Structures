using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{
    public class QueueWithStack<T>
    {
        private Stack<T> _enqueueStack;
        private Stack<T> _dequeueStack;

        public void Enqueue(T value)
        {
            _enqueueStack.Push(value);
        }

        public T Dequeue()
        {
            if(_dequeueStack.Count() > 0)
            {
                return _dequeueStack.Pop();
            }
            else
            {
                while(_enqueueStack.Count > 0)
                {
                    _dequeueStack.Push(_enqueueStack.Pop());
                }
                return _dequeueStack.Pop();
            }
        }
    }
}
