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

        public SuperList()
        {
            _realArray = new T[0];
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

        public T Get(int index)
        {
            if(index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _realArray[index];
        }

        //toglie l'ultimo e lo restituisce anche
        public T Pop()
        {
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
    }
}
