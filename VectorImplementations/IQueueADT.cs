using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    /// <summary>
    /// An abstract data type to represent a queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueueADT<T>
    {
        int Size { get; }

        /// <summary>
        /// Enqueue - add a new element to the end of the queue
        /// </summary>
        /// <param name="element"></param>
        void Enqueue(T element);

        /// <summary>
        /// Dequeue - remove an element from the front of the queue. The element that has been waiting the longest is the one removed (FIFO)
        /// </summary>
        /// <returns></returns>
        T Dequeue();

        T Peek();
    }
}
