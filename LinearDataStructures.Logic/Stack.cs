using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures.Logic
{
    internal class Stack<T> : IStack<T>
    {

        #region fields
        private Element<T>? _first = null;
        #endregion fields

        public bool IsEmpty => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }
    }
}
