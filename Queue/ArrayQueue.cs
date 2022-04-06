using Queue.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> innerarray;
        public int Count => innerarray.Count;
        public ArrayQueue()
        {
            innerarray = new List<T>();
        }

        public ArrayQueue(IEnumerable<T> collection): this()
        {
            foreach (var item in collection)
            {
                EnQueue(item);
            }
        }
        public T DeQueue()
        {
            if (Count == 0)
            {
                throw new EmptyQueueException();
            }
            var temp = innerarray[0];
            innerarray.RemoveAt(0);
            return temp;
        }

        public void EnQueue(T value)
        {
            innerarray.Add(value);
        }

        public T Peek()
        {
            if (Count ==0)
            {
                return default(T);
            }
            return innerarray[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            return innerarray.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
