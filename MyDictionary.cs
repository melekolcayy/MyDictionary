using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyDictionary<K, V>
    {
        public K[] keys;
        public V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[tempKeys.Length + 1];
            values = new V[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }
    }
}
    

