using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class SuperList<T>
    {
        private T[] _realArray;
        public int Length => _realArray.Length;

        public SuperList()
        {
            _realArray = new T[0];
        }

        public T Get(int index)
        {
            if(index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _realArray[index];
        }

        //aggiunge un elemento alla fine
        public void Push(T item)
        {
            var originalLegth = _realArray.Length;
            var newArray = new T[originalLegth + 1];
            for (int i = 0; i < originalLegth; i++)
            {
                newArray[i] = _realArray[i];
            }
            newArray[originalLegth] = item;

            _realArray = newArray;
        }

        //toglie l'ultimo e restituisce elemento rimosso
        public T Pop()
        {
            if (_realArray.Length == 0)
            {
                throw new InvalidOperationException("Cannot shift from an empty list.");
            }

            int originalLength = _realArray.Length;
            int newArrayLength = _realArray.Length - 1;
            var newArray = new T[newArrayLength];
            T element = _realArray[originalLength - 1];

            for (int i = 0; i < newArrayLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            _realArray = newArray;
            return element;
        }

        //aggiunge un elemento all'inizio
        public void Unshift(T item)
        {
            var originalLegth = _realArray.Length;
            var newArray = new T[originalLegth + 1];
            newArray[0] = item;
            for (int i = 1; i < originalLegth; i++)
            {
                newArray[i] = _realArray[i - 1];
            }

            _realArray = newArray;
        }

        //toglie il primo e restituisce elemento rimosso
        public T Shift()
        {
            if (_realArray.Length == 0)
            {
                throw new InvalidOperationException("Cannot shift from an empty list.");
            }

            int newArrayLength = _realArray.Length - 1;
            var newArray = new T[newArrayLength];
            T element = _realArray[0];

            for (int i = 1; i < _realArray.Length; i++)
            {
                newArray[i - 1] = _realArray[i];
            }

            _realArray = newArray;
            return element;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException();
            }

            int originalLength = _realArray.Length;
            var newArray = new T[originalLength - 1];
            
            newArray = _realArray.Where((_, i) => i != index).ToArray();

            _realArray = newArray;
        }

        public void Clear()
        {
            _realArray = new T[0];
        }
    }
}
