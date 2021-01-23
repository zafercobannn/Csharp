using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4odev5
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }
        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValue = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            
        }
        public int Length
        {
            get { return keys.Length;}
        }
        public K[] Keys
        {
            get { return keys;}
        }
        public V[] Values
        {
            get { return values; }
        }
            
    }
}
