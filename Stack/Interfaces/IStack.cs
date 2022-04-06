using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Interfaces
{
    public interface IStack<T> : IEnumerable<T>
    {
        public int Count { get; }

        T Pop();

        T Peek();

        public void Push(T item);

    }
}
