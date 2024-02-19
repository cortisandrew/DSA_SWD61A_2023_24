using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorImplementations
{
    internal class ArrayBasedVector<T> : IVectorADT
    {
        T[] V = new T[100];

        internal T ElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }
    }
}
