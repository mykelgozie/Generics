using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ListNodeClass<T>
    {

        public T Value;
        public ListNodeClass<T> Previous;
        public ListNodeClass<T> Next;
         public ListNodeClass(T value)
        {
            Value = value;
  

        }



    }
}
