using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    public class Stack<T>
    {
        private ArrayBasedVector<T> abv;
        public Stack(int defaultLength = 128) {
            abv = new ArrayBasedVector<T>(defaultLength);
        }
        public void Push(T elem)
        {
            abv.Append(elem);
        }

        public T Pop()
        {
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
