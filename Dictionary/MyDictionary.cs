using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K, V, Q>  //Generic Class
    {
        K[] Key;
        K[] _tempKey;

        V[] Value;
        V[] _tempValue;

        Q[] Quantity;
        Q[] _tempQuantity;

        public MyDictionary()
        {           
            Key = new K [0] ;           
            Value = new V [0] ;
            Quantity = new Q [0] ;
        }

        public void Add(K Keys, V Values, Q Quantities)
        {
            _tempKey = Key;
            Key = new K[Key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                Key[i] = _tempKey[i];
            }
            Key[Key.Length - 1] = Keys;

            _tempValue = Value;
            Value = new V[Value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                Value[i] = _tempValue[i];
            }
            Value[Value.Length - 1] = Values;

            _tempQuantity = Quantity;
            Quantity = new Q[Quantity.Length +1];
            for (int i = 0; i < _tempQuantity.Length; i++)
            {
                Quantity[i] = _tempQuantity[i];
            }
            Quantity[Quantity.Length - 1] = Quantities;
        }
        public int Count
        {
            get { return Key.Length; }
        }

        public K[] _keys
        {
            get { return Key; }
        }
        public V[] _value
        {
            get { return Value; }
        }
        public Q[] _quantity
        {
            get { return Quantity; }
        }

    }
}
