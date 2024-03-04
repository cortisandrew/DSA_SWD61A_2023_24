using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class Queue_implemented_using_ABV<T> : IQueueADT<T>
    {
        private const int DEFAULT_LENGTH = 128;
        private ArrayBasedVector<T> abv;

        public Queue_implemented_using_ABV(int initialLength = DEFAULT_LENGTH)
        {
            abv = new ArrayBasedVector<T>(initialLength);
        }

        public int Size
        {
            get { return abv.Size;}
        }

        public T Dequeue()
        {
            return abv.RemoveAtRank(Size - 1);
            // return abv.RemoveAtRank(0);
        }

        public void Enqueue(T element)
        {
            // Enqueue would be fast, but Dequeue would be slow....
            // abv.Append(element);

            // Dequeue would be fast, but Enqueue is slow...
            abv.InsertAtRank(0, element);
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
