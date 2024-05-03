using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class IntegerValuePair<V>
    {
        public int Key { get; set; }
        public V Value { get; set; }

        public override string ToString()
        {
            if (Value == null)
            {
                return $"[Key: {Key}]";
            }

            return $"[Key: {Key}, Value: {Value.ToString()}]";
        }
    }
}
