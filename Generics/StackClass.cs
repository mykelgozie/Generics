using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Generics
{
    class StackClass<T> where T: IComparable
    {

        private List<T> items;

        //creates a new Constructor list
        public StackClass()
        {

            items = new List<T>();
        }

        //Get item from list
        public T GetIndex(int index)
        {
            return items[index];
        }

        //insert item at the end of list
        public void Push(T newitem)
        {
            items.Add(newitem);
        }

        //Get item size
        public int Size()
        {
            return items.Count;
        }

         //Get item at the end of list
        public T Peek()
        {
            int last = items.Count - 1;
            return items[last];
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
            int last = items.Count;
            T element = items[last - 1];
            items.RemoveAt(last - 1);
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
