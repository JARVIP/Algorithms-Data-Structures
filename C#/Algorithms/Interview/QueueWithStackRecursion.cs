using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{
    public class QueueWithStackRecursion<T>
    {
        private Stack<T> _stack;

        public void Enqueue(T value)
        {
            _stack.Push(value);
        }

        public T Dequeue()
        {
            if (_stack.Count() == 1)
                return _stack.Pop();

            T item = _stack.Pop();

            T dequeued_item = Dequeue();

            _stack.Push(item);

            return dequeued_item;
        }
    }
}
