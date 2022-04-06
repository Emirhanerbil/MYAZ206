using DataStructures.LinkedList.DoublyLinkedList;
using Queue.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _linkedList;
        public LinkedListQueue()
        {
            _linkedList = new DoublyLinkedList<T>();
        }
        public int Count => _linkedList.Count;
        public LinkedListQueue(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                EnQueue(item);
            }
        }
        public T DeQueue()
        {
            if (Count==0)
            {
                throw new EmptyQueueException();
            }
            
            return _linkedList.RemoveFirst();
        }

        public void EnQueue(T value)
        {
            _linkedList.AddLast(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        public T Peek()
        {
            return Count==0 ? default(T) :  _linkedList.Head.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
