using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
   
    class MyDictionary<T>
    {
        T[] _array;

        public MyDictionary()
        {
            _array = new T[0];
           
        }

        public void Add(T item)
        {
            T[] _tempoArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempoArray.Length; i++)
            {
                _array[i]= _tempoArray[i] ;

            }
            _array[_array.Length - 1] = item;
        }
        public void Read()
        { foreach (var item in _array)
            { Console.WriteLine(item); }
        }
        


    }

   
}
