using DataStructures.Array.Generic;
using Stack.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private bool isCountZero => Count == 0;

        private readonly Array<T> _array;
        public int Count => _array.Count;
        public ArrayStack()
        {
            _array = new Array<T>();
        }
        public ArrayStack(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Push(item);
            }
        }

        public IEnumerator<T> GetEnumerator() => _array.GetEnumerator();
        


        public T Peek()
        {
            if (isCountZero)
            {
                return default(T);
            }
            return _array.GetValue(_array.Count - 1);
        }

        public T Pop()
        {
            if (isCountZero)
            {
                throw new Exception("Boş Stack");
            }
            var result = _array.Remove();
            return result;
        }

        public void Push(T item) => _array.Add(item);
        

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
