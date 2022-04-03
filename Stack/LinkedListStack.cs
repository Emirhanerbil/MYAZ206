using DataStructures.LinkedList.SinglyLinkedList;
using Stack.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private bool isCountZero => Count == 0;


        private readonly SinglyLinkedList<T> _list;
        public LinkedListStack()
        {
            _list = new SinglyLinkedList<T>();
        }
        public LinkedListStack(IEnumerable<T> collection) :this()
        {
            foreach (var item in collection)
            {
                Push(item);
            }
        }
        public int Count => _list.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public T Peek()
        {
            if (isCountZero) 
            {
                return default(T);
            }
            return _list.Head.Value;
            
        }

        public T Pop()
        {
            if (isCountZero)
            {
                throw new Exception();
            }
            return _list.RemoveFirst();
        }

        public void Push(T item)
        {
             _list.AddFirst(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}
