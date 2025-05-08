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
        public T[] Array { get { return _realArray; } }
        public int Length => _realArray.Length;

        public SuperList()
        {
            _realArray = System.Array.Empty<T>();  
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _realArray[index];
        }

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

        public void Unshift(T item)
        {
            var newArrayLength = _realArray.Length + 1;
            var newArray = new T[newArrayLength];
            newArray[0] = item;

            for (int i = 0; i < _realArray.Length; i++)
            {
                newArray[i + 1] = _realArray[i];
            }

            _realArray = newArray;
        }

        public T? ShiftNull()
        {
            return default;
        }

        public T Shift()
        {
            if (_realArray.Length == 0)
            {
                throw new InvalidOperationException("Cannot shift from an empty list.");
            }

            var newArrayLength = _realArray.Length - 1;
            var newArray = new T[newArrayLength];

            for (int i = 1; i < _realArray.Length; i++)
            {
                newArray[i - 1] = _realArray[i];
            }

            var element = _realArray[0];
            _realArray = newArray;
            return element;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var newArray = _realArray.Where((_, i) => i != index).ToArray();
            _realArray = newArray;
        }
    }
}
