using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class MyDictionary<TKey,TVal>
    {
        TKey[] keys;
        TVal[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TVal[0];
        }
        public void Add(TKey key, TVal value)
        {
            TKey[] tempKeys = keys;
            TVal[] tempVals = values;
            keys = new TKey[keys.Length + 1];
            values = new TVal[values.Length + 1];

            for (int i = 0; i < keys.Length-1; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempVals[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void Yazdir(TKey key)
        {
            int index = List<TKey>.FindIndex(keys, key);
            //Console.WriteLine(values[index]);
        }

        public int Count
        {
            get { return keys.Length; }
            
        }

    }
}
