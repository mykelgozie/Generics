using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class LinkedListClass<T>
    {
        private ListNodeClass<T> Result;
        private ListNodeClass<T> Current;
        private ListNodeClass<T> Head;
        private ListNodeClass<T> Tail;
        int count;

        public int AddItem(T value)
        {
            ListNodeClass<T> adding = new ListNodeClass<T>(value);

            if (Head == null)
            {

                Head = adding;
                Tail = Head;

            }

            if (Head != null)
            {
                Tail.Next = adding;
                adding.Previous = Tail;
                Tail = adding;
                Tail.Next = null;

            }


            count++;
            return count;

        }

        public int size()
        {

            return count;
        }


        public ListNodeClass<T> FindItem(T value)
        {

            Current = Head;

            while (Current != null )
            {
                if (Current.Value.Equals(value))
                {

                    return Current;

                }

                Current = Current.Next;


            }

            return null;

           
    }

        public void Remove(T value)
        {

            ListNodeClass<T> found = FindItem(value);

            if (found != null)
            {
                ListNodeClass<T> previous = found.Previous;
                ListNodeClass<T> next = found.Next;

                if (previous == null)
                {

                    Head = next;

                    if (Head != null)
                    {
                        Head.Previous = null;
                    }

                } else
                {



                    previous.Next = next;
                }
                if (next == null)
                {

                    Tail = previous;

                    if (Tail != null )
                    {
                        Tail.Next = null;
                    }

                }else
                {

                    next.Previous = previous;
                }

                count--;


            }


        }

        public bool Check(T value)
        {

            ListNodeClass<T> found = FindItem(value);

            if (found == null) {

                return false;
            } else
            {

                return true;
            }

        }


        public void InsertAt(int position, ListNodeClass<T> value)
        {
            int number = 0;
            Current = Head;

            while (Current != null)
            {
                
                if (number == position)
                {

                    Result = Current;
                    break;


                }

                Current = Current.Next;

                count++;


            }

            Current.Previous = value.Next;
            Current.Previous.Next = value.Previous;
         

            




        }

        public int IndexItem(T value)
        {
            int position = 0;

            Current = Head;

            while (Current != null && position <= count)
            {
                position++;
                if (Current.Value.Equals(value))
                {

                    return position;

                }

                Current = Current.Next;

               


            }

            return -1;







        }


        public  bool IsEmpty()
        {

            if (count > 0)
            {
                return false;

            }
            else
            {

                return true;
            }
        }

        public T Search(T value)
        {

            ListNodeClass<T> found = FindItem(value);

            return found.Value;

        }

    }
}
