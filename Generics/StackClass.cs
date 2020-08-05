using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection.Emit;
using System.Text;

namespace Generics
{
    class StackClass<T> : IEnumerable
    {
  
        private List<T> items;

        //creates a new Constructor list
        public StackClass()
        {
            items = new List<T>();
        }

         //get iterable list
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
           
        }


        public T GetIndex(int index)
        {
            return items[index];
        }


        //insert item at the end of list
        public void Push(T newitem)
        {
            items.Insert(0, newitem);
        }

        //Get item size
        public int Size()
        {
            return items.Count;
        }

         //Get item at the end of list
        public T Peek()
        {
       
            return items[0];
        }

        //checked if empty
        public bool IsEmpty()
        {
            if (items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //remove element at the end
        public T Pop()
        {
            T element = items[0];
            items.RemoveAt(0);
            return element;
        }

        //get all elements
        public void Print()
        {
            if (items.Count > 0)
            {
                for (int i = items.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }

    }
}
