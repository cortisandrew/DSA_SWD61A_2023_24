using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class Stack_implemented_using_ABV<T> : IStackADT<T>
    {
        private ArrayBasedVector<T> abv;
        public Stack_implemented_using_ABV(int defaultLength = 128)
        {
            abv = new ArrayBasedVector<T>(defaultLength);
        }
        public void Push(T elem)
        {
            // Inefficient
            // abv.InsertAtRank(0, elem);
            
            abv.Append(elem);
        }

        public T Pop()
        {
            // Inefficient!!!
            // return abv.RemoveAtRank(0);

            // Remove the last element from the abv
            return abv.RemoveAtRank(Size - 1);
        }

        public T Peek()
        {
            return abv.ElementAtRank(Size - 1);
        }

        public int Size
        {
            get
            {
                return abv.Size;
            }
        }
    }
}
