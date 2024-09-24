using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures.Logic
{
    internal class Queue<T> : IQueue<T>
    {

        #region fields
        private Element<T>? _first = null;
        private Element<T>? _last = null;
        #endregion fields

        public int Count
        {
            get // lesendes oder berechnendes
            {
                int result = 0;
                Element<T>? run = _first;

                while (run != null)
                {
                    result++;
                    run = run.Next;
                }
                return result;
            }
        }

        public void Clear()
        {
            _first = null;
            _last = null;
        }

        public T Dequeue()
        {
            if (_first == null)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            Element<T> removeElement = _first;
            _first = _first.Next;

            if (_first == null)
            {
                _last = _first;
            }
                return removeElement.Data;   
            
            
        }

        public void Enqueue(T item)
        {
            if (_first == null)
            {
                _first = new Element<T>(item, null);
                _last = _first;
            }
            else 
            {
                Element<T> newElement = new Element<T>(item, null);
                _last!.Next = newElement;
                _last = newElement;
            }

        }
    }
}
