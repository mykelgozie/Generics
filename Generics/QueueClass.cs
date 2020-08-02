using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Generics
{
    class QueueClass<T> where T: IComparable
    {

        private List<T> items;

        QueueClass()
        {

            items = new List<T>();
        }

        //get element at position
        public T GetIndex(int index)
        {
            return items[index];
        }

        //get the size
        public int Size()
        {
            return items.Count;
        }

        //check if empty
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

        //Add element to queue
        public void Enqueue(T value)
        {
            items.Add(value);

        }

        //remove element
        public  T Dequeue()
        {
            T element = items[0];
            items.RemoveAt(0);
            return element;
        }


        //checked elemnt to remove
        public T Peek()
        {  
            return items[0];
        }

        //return all element
        public void Print()
        {
            if (items.Count > 0)
            {

                for (int i = 0; i <= items.Count-1; i++)
                {
                    Console.WriteLine(items[i]);
                }

            }



        }






    }
}
